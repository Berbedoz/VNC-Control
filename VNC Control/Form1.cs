using System;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

// Версия 0.0.9

namespace VNC_Control
{
    public partial class Form1 : Form
    {
        private Point dragStartLocation;
        public SQLiteConnection DB;
        public static Form1 SelfRef { get; set; }

        public Form1()
        {
            SelfRef = this;
            InitializeComponent();

            tvGroups.Nodes.Clear(); // Clear group table

            //DragDrop in TreeView
            tvGroups.AllowDrop = true;
            tvGroups.ItemDrag += new ItemDragEventHandler(tvGroups_ItemDrag);
            tvGroups.DragEnter += new DragEventHandler(tvGroups_DragEnter);
            tvGroups.DragOver += new DragEventHandler(tvGroups_DragOver);
            tvGroups.DragDrop += new DragEventHandler(tvGroups_DragDrop);
            //end DragDrop

            // SQLite
            dbInit();
            groupAdd();
            makeDGVList();
            dgvList.Columns["id"].Visible = false;
            dgvList.Columns["parent_group_id"].Visible = false;
            dgvList.Columns["password"].Visible = false;
            //dgvList.RowHeadersVisible = false;
            // end SQLite

            // Context menu
            // Создание элементов меню
            ToolStripMenuItem addGroupTV = new ToolStripMenuItem("Добавить группу");
            ToolStripMenuItem delGroupTV = new ToolStripMenuItem("Удалить группу");
            ToolStripMenuItem ReloadTV = new ToolStripMenuItem("Обновить");
            ToolStripMenuItem renameGroupTV = new ToolStripMenuItem("Переименовать группу");
            ToolStripMenuItem addItemsDGV = new ToolStripMenuItem("Добавить запись");
            ToolStripMenuItem delItemsDGV = new ToolStripMenuItem("Удалить запись");
            ToolStripMenuItem renameItemsDGV = new ToolStripMenuItem("Изменить запись");

            // Добавление элементов в меню
            cmsTVgroupsSelectedItem.Items.AddRange(new[] { addGroupTV, renameGroupTV, delGroupTV, ReloadTV });
            cmsDGVSelectedItem.Items.AddRange(new[] { addItemsDGV, renameItemsDGV, delItemsDGV });

            // Ассоциируем контекмтное меню с TreeView
            tvGroups.ContextMenuStrip = cmsTVgroupsSelectedItem;
            // Ассоциируем контекмтное меню с DataGridView
            dgvList.ContextMenuStrip = cmsDGVSelectedItem;

            // Установка оброботчиков событий для контекстного меню
            addGroupTV.Click += AddGroupTV_Click;
            delGroupTV.Click += DelGroupTV_Click;
            renameGroupTV.Click += RenameGroupTV_Click;
            ReloadTV.Click += ReloadTV_Click;
            addItemsDGV.Click += AddItemsDGV_Click;
            delItemsDGV.Click += DelItemsDGV_Click;
            renameItemsDGV.Click += RenameItemsDGV_Click;

            // end Context menu
        }

        #region ContextMenu
        private void DelItemsDGV_Click(object sender, EventArgs e) // Вызов функции удаления записи из контекстного меню DataGridView
        {
            delItems();
        }
        private void RenameItemsDGV_Click(object sender, EventArgs e) // Вызов функции удаления записи из контекстного меню DataGridView
        {
            if (dgvList.SelectedRows.Count > 0) // Проверяем есть ли выделенная строка
            {
                DataGridViewSelectedRowCollection row = dgvList.SelectedRows;
                string id = dgvList.Rows[row[0].Index].Cells[0].Value.ToString();
                string pg = dgvList.Rows[row[0].Index].Cells[1].Value.ToString();
                string nm = dgvList.Rows[row[0].Index].Cells[2].Value.ToString();
                string ip = dgvList.Rows[row[0].Index].Cells[3].Value.ToString();
                string ps = dgvList.Rows[row[0].Index].Cells[4].Value.ToString();

                RenameItemDGV RenameItemForm = new RenameItemDGV(this);
                RenameItemForm.Show();
                RenameItemForm.tbRenameItemDGVName.Text = nm;
                RenameItemForm.tbRenameItemDGVIP.Text = ip;
                RenameItemForm.tbRenameItemDGVPass.Text = ps;
                RenameItemForm.id = id;
                RenameItemForm.pg = pg;
            }
            else
            {
                MessageBox.Show("Выберите элемент для Изменения!");
            }

        }

        public void RenameItems(string id, string pg, string itmname, string ip, string pass)
        {
            DataGridViewSelectedRowCollection row = dgvList.SelectedRows;
            string updateItems = $"UPDATE vnc_items SET name = '{itmname}', ip = '{ip}', password = '{pass}' WHERE id = {id};";
            dbExecNonQuery(updateItems);                                            //Обновляем выбранный элемент DGV в БД
            makeDGVdynamic(pg);                                                     // Обновляем список в выбранной группе
        }

        private void AddItemsDGV_Click(object sender, EventArgs e) // Вызов функции добавления записи из контекстного меню DataGridView
        {
            AddItemDGV addItemForm = new AddItemDGV(this);
            addItemForm.Show();
        }

        private void RenameGroupTV_Click(object sender, EventArgs e)    // Вызов функции переименования группы из контекстного меню TreeView
        {
            string pgi = tvGroups.SelectedNode.Text.ToString(); //Определяем выбранную группу
            try
            {
                SQLiteDataReader SQL = dbExecReader($"SELECT group_id FROM groups WHERE group_name='{pgi}'");
                if (SQL.HasRows)
                {
                    while (SQL.Read())
                    {
                        pgi = SQL["group_id"].ToString();

                    }
                }
                RenameNodeTV renameNodeForm = new RenameNodeTV(this);
                renameNodeForm.pgi = pgi;
                renameNodeForm.Show();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show($"Ошибка запроса к БД:\n {err}");
            }
        }

        private void DelGroupTV_Click(object sender, EventArgs e)   // Вызов функции удаления группы из контекстного меню TreeView
        {
            delNode();
        }

        private void AddGroupTV_Click(object sender, EventArgs e)   // Вызов функции добавления группы из контекстного меню TreeView
        {
            string pgi = "";
            if (tvGroups.SelectedNode != null)
            {
                pgi = tvGroups.SelectedNode.Text.ToString(); //Определяем выбранную группу
                try
                {
                    SQLiteDataReader SQL = dbExecReader($"SELECT group_id FROM groups WHERE group_name='{pgi}'");
                    if (SQL.HasRows)
                    {
                        while (SQL.Read())
                        {
                            pgi = SQL["group_id"].ToString();
                        }
                    }

                }
                catch (SQLiteException err)
                {
                    MessageBox.Show($"Ошибка запроса к БД:\n {err}");
                }
            }
            else
            {
                pgi = "0";
            }
            AddNodeTV addNodeForm = new AddNodeTV(this);
            addNodeForm.pgi = pgi;
            addNodeForm.Show();

        }
        #endregion ContextMenu

        #region SQLite

        private void dbInit()   // Создаем БД (если она не существует)
        {
            if (!System.IO.File.Exists("vncc.db"))
            {
                SQLiteConnection.CreateFile("vncc.db");
            }
            DB = new SQLiteConnection("Data Source=vncc.db; Version=3;");
            SQLiteCommand command = new SQLiteCommand(DB);
            string sql_groups = "CREATE TABLE IF NOT EXISTS 'groups' ('group_id' INTEGER NOT NULL UNIQUE, 'parent_id' INTEGER NOT NULL, 'group_name' TEXT NOT NULL, PRIMARY KEY('group_id' AUTOINCREMENT));";
            string sql_items = "CREATE TABLE IF NOT EXISTS 'vnc_items' ('id' INTEGER NOT NULL UNIQUE, 'parent_group_id'	INTEGER NOT NULL,	'name'	TEXT NOT NULL,	'ip' TEXT NOT NULL, 'password' TEXT, PRIMARY KEY('id' AUTOINCREMENT));";
            DB.Open();
            command.CommandText = sql_items;
            command.ExecuteNonQuery();
            command.CommandText = sql_groups;
            command.ExecuteNonQuery();
            DB.Close();
        }

        private void dbExecNonQuery(string queryToDB)   // Функция для запросов к БД не предпологающая возврата значений
        {
            try
            {
                DB = new SQLiteConnection("Data Source=vncc.db; Version=3;");
                SQLiteCommand command = new SQLiteCommand(DB);
                DB.Open();
                command.CommandText = queryToDB;
                command.ExecuteNonQuery();
                DB.Close();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show($"Ошибка запроса к БД:\n {err}");
            }
        }

        private SQLiteDataReader dbExecReader(string sqlquery)    // Функция для запросов к БД возвращающая значение объект SQLiteDataReader
        {
            DB = new SQLiteConnection("Data Source=vncc.db; Version=3;");
            DB.Open();
            SQLiteCommand CMD = DB.CreateCommand();
            CMD.CommandText = sqlquery;
            SQLiteDataReader SQL = CMD.ExecuteReader();
            return SQL;
        }

        public void groupAdd()     // Добавление списка групп из БД
        {
            try
            {
                DataTable DT = new DataTable();
                DB = new SQLiteConnection("Data Source=vncc.db; Version=3;");
                SQLiteCommand command = new SQLiteCommand(DB);
                DB.Open();
                SQLiteCommand sql_cmd = DB.CreateCommand();
                sql_cmd.CommandText = "SELECT * FROM groups";
                SQLiteDataAdapter DA = new SQLiteDataAdapter(sql_cmd.CommandText, DB);

                DA.Fill(DT);

                DB.Close();

                Int64 parentID = 0;
                MakeTree(parentID, tvGroups.Nodes, DT);

                tvGroups.ExpandAll();
            }
            catch (SQLiteException err)
            {
                MessageBox.Show($"Ошибка запроса к БД:\n {err}");
            }
        }

        public void MakeTree(Int64 parentID, TreeNodeCollection parentNode, DataTable DT)       // Построение дерева групп
        {
            foreach (DataRow row in DT.AsEnumerable().Where(x => x.Field<Int64>("parent_id") == parentID))
            {
                string name = row.Field<string>("group_name");
                int id = (int)row.Field<Int64>("group_id");
                TreeNode node = new TreeNode(name, 0, 1);
                parentNode.Add(node);
                MakeTree(id, node.Nodes, DT);
            }
            
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ip = dgvList.Rows[e.RowIndex].Cells[3].Value.ToString();
            string pass = dgvList.Rows[e.RowIndex].Cells[4].Value.ToString();
            VncExec(ip, cbSendPass.Checked, pass);
        }

        private void makeDGVList()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * FROM vnc_items";

            try
            {
                using (DB = new SQLiteConnection("Data Source=vncc.db; Version=3;"))
                {
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, DB))
                    {
                        da.Fill(ds);
                        dgvList.DataSource = ds.Tables[0].DefaultView;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ошибка запроса к БД:\n {err}");
            }
        }

        private void makeDGVdynamic(string selectedNode)
        {
            DataSet ds = new DataSet();
            string sql = $"SELECT * FROM vnc_items WHERE parent_group_id='{selectedNode}';";
            try
            {
                using (DB = new SQLiteConnection("Data Source=vncc.db; Version=3;"))
                {
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, DB))
                    {
                        da.Fill(ds);
                        dgvList.DataSource = ds.Tables[0].DefaultView;

                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        public void addItems(string itmname, string ip, string pass) // Добавление новых элементов в группу
        {
            if (tvGroups.SelectedNode == null)  // Если не выбрана группа то выбирается корневая группа
            { 
                tvGroups.SelectedNode = tvGroups.TopNode; 
            }
            
                string pgi = tvGroups.SelectedNode.Text.ToString(); //Определяем выбранную группу
                try
                {
                SQLiteDataReader SQL = dbExecReader($"SELECT group_id FROM groups WHERE group_name='{pgi}'");
                if (SQL.HasRows)
                    {
                        while (SQL.Read())
                        {
                            pgi = SQL["group_id"].ToString();   // находим ID выбранной группы

                        }

                    }
                }
                catch (SQLiteException err)
                {
                    MessageBox.Show($"Ошибка запроса к БД:\n {err}");
                }

                try
                {
                    dbExecNonQuery($"INSERT INTO vnc_items(parent_group_id, name, ip, password) VALUES('{pgi}', '{itmname}', '{ip}', '{pass}')");
                    DB.Close();
                    makeDGVdynamic(pgi);
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            
        }

        private void delItems()     // Удаление выделенных элементов
        {
            if (dgvList.SelectedRows.Count > 0) // Проверяем есть ли выделенная строка
            {
                DataGridViewSelectedRowCollection row = dgvList.SelectedRows;
                string nm = dgvList.Rows[row[0].Index].Cells[0].Value.ToString();

                dbExecNonQuery($"DELETE FROM vnc_items WHERE id = {nm}");               // Удаляем запись из БД
                makeDGVdynamic(dgvList.Rows[row[0].Index].Cells[1].Value.ToString());   // Обновляем список в выбранной группе
            }
            else
            {
                MessageBox.Show("Выберите элемент для удаления!");
            }
        }


        public void addNode(string gn, string pgi)     // Добавление групп
        {
                try
                {
                    dbExecNonQuery($"INSERT INTO groups(parent_id, group_name) VALUES('{pgi}', '{gn}');");
                    DB.Close();
                    tvGroups.Nodes.Clear();
                    groupAdd();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }

        }

        public void renameNode(string gn, string pgi)     // Переименование групп
        {
            try
            {
                dbExecNonQuery($"UPDATE groups SET group_name = '{gn}' WHERE group_id = '{pgi}';");
                DB.Close();
                tvGroups.Nodes.Clear();
                groupAdd();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        }



        private void delNode()     // Удаление выделенных элементов
        {

            DialogResult dialogResult = MessageBox.Show("Удаление группы повлечет за собой удаление всех, входящих в нее, элементов. Уверены?", "Удалить группу", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string parentgid = "";
                string pgi = tvGroups.SelectedNode.Text.ToString(); //Определяем выбранную группу

                try
                {
                    SQLiteDataReader SQL = dbExecReader($"SELECT parent_id FROM groups WHERE group_name='{pgi}'");
                    if (SQL.HasRows)
                    {
                        while (SQL.Read())
                        {
                            parentgid = SQL["parent_id"].ToString();   // находим ID родительской группы

                        }

                    }
                }
                catch (SQLiteException err)
                {
                    MessageBox.Show($"Ошибка запроса к БД:\n {err}");
                }

                if (tvGroups.SelectedNode != null) // Проверяем есть ли выделенная строка
                {
                    
                    if (parentgid == "0")
                    {
                        MessageBox.Show("Это корневая группа, не нужно её удалять! Можно просто переименовать", "Осторожно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {

                            SQLiteDataReader SQL = dbExecReader($"SELECT group_id FROM groups WHERE group_name='{pgi}'");
                            if (SQL.HasRows)
                            {
                                while (SQL.Read())
                                {
                                    pgi = SQL["group_id"].ToString();

                                }
                                DB.Close();
                            }
                        }
                        catch (SQLiteException err)
                        {
                            MessageBox.Show($"Ошибка запроса к БД:\n {err}");
                        }

                        try
                        {

                            dbExecNonQuery($"DELETE FROM groups WHERE group_id = '{pgi}'; DELETE FROM vnc_items WHERE parent_group_id = '{pgi}';");
                            DB.Close();
                            tvGroups.Nodes.Clear();
                            groupAdd();
                            try
                            {
                                DataGridViewSelectedRowCollection row = dgvList.SelectedRows;
                                makeDGVdynamic(dgvList.Rows[row[0].Index].Cells[1].Value.ToString());
                            }
                            catch
                            {

                            }

                        }
                        catch (SQLiteException ex)
                        {
                            MessageBox.Show("Ошибка: " + ex.Message);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберите элемент для удаления!");
                }
            }

        }

        #endregion SQLite

        #region Main functions

        private void ReloadTV_Click(object sender, EventArgs e)
        {
            tvGroups.Nodes.Clear();
            groupAdd();
        }
        private void btReloadTV_Click(object sender, EventArgs e)
        {
            ReloadTV_Click(null, null);
        }

        void tvGroups_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (dragStartLocation == Point.Empty || dragStartLocation == e.Location)
            {
                dragStartLocation = Point.Empty;
                tvGroups.SelectedNode = e.Node;
                string text = e.Node.Text;

                try
                {
                    SQLiteDataReader SQL = dbExecReader($"SELECT group_id FROM groups WHERE group_name='{text}'");
                    if (SQL.HasRows)
                    {
                        while (SQL.Read())
                        {
                            makeDGVdynamic(SQL["group_id"].ToString());
                        }
                    }
                }
                catch (SQLiteException err)
                {
                    MessageBox.Show($"Ошибка запроса к БД:\n {err}");
                }

            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btConnect_Click(object sender, EventArgs e)    // Подключение по кнопке "Подключить" выбранного элемента из списка DGV
        {
            if (dgvList.SelectedRows.Count > 0) // Проверяем есть ли выделенная строка
            {
                DataGridViewSelectedRowCollection row = dgvList.SelectedRows;
                string ip = dgvList.Rows[row[0].Index].Cells[3].Value.ToString();
                string pass = dgvList.Rows[row[0].Index].Cells[4].Value.ToString();
                VncExec(ip, cbSendPass.Checked, pass);
            }
            else
            {
                MessageBox.Show("Выберите элемент для подключения!");
            }

        }

        private void btShowAll_Click(object sender, EventArgs e)
        {
            makeDGVList();
        }

        static void VncExec(string con, bool pass, string passVNC)
        {
            //string pathToVNC = @"C:\Program Files\TightVNC\tvnviewer.exe";
            string pathToVNC = "tvnviewer.exe";
            string argsVNC = @" -host=";
            string argsVNCpass = @" -password=";
            string argsClipboard = @" -useclipboard=yes";
            string argsMouselocal = @" -mouselocal=normal";
            string argsScale = @" -scale=auto";

            string addrVNC = con;

            if (pass)
            {
                Process iStartProcess = new Process(); // новый процесс
                iStartProcess.StartInfo.FileName = pathToVNC; // путь к запускаемому файлу
                iStartProcess.StartInfo.Arguments = argsVNC + addrVNC + argsVNCpass + passVNC + argsClipboard + argsMouselocal + argsScale; // параметры запуска
                iStartProcess.Start(); // запускаем программу
            }

            else
            {
                Process iStartProcess = new Process(); // новый процесс
                iStartProcess.StartInfo.FileName = pathToVNC; // путь к запускаемому файлу
                iStartProcess.StartInfo.Arguments = argsVNC + addrVNC; // параметры запуска
                iStartProcess.Start(); // запускаем программу
            }
        }

        #endregion Main functions

        #region DragDrop items 

        private void tvGroups_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DoDragDrop(e.Item, DragDropEffects.Move); // перемещение (левая кнопка мыши)
            else if (e.Button == MouseButtons.Right)
                //DoDragDrop(e.Item, DragDropEffects.Copy);   // копирование (правая кнопка мыши)
                DoDragDrop(e.Item, DragDropEffects.Move); // перемещение (левая кнопка мыши)
        }

        private void tvGroups_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void tvGroups_DragOver(object sender, DragEventArgs e)
        {
            Point targetPoint = tvGroups.PointToClient(new Point(e.X, e.Y));
            tvGroups.SelectedNode = tvGroups.GetNodeAt(targetPoint);
        }

        private void tvGroups_DragDrop(object sender, DragEventArgs e)
        {

            Point targetPoint = tvGroups.PointToClient(new Point(e.X, e.Y));
            TreeNode targetNode = tvGroups.GetNodeAt(targetPoint);
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));


            if (targetNode == null) return; // test


            if (!draggedNode.Equals(targetNode) && !ContainsNode(draggedNode, targetNode))
            {
                if (e.Effect == DragDropEffects.Move)
                {
                    draggedNode.Remove(); targetNode.Nodes.Add(draggedNode);
                }
                else if (e.Effect == DragDropEffects.Copy)
                    targetNode.Nodes.Add((TreeNode)draggedNode.Clone());

                targetNode.Expand();
                tvUpdateDB(draggedNode.Text, targetNode.Text);
            }
        }

        private void tvUpdateDB(string draggedNode, string targetNode)
        {
            

            try
            {
                SQLiteDataReader SQL = dbExecReader($"SELECT group_id FROM groups WHERE group_name='{targetNode}'");    // находим новую родительскую группу
                if (SQL.HasRows)
                {
                    while (SQL.Read())
                    {
                        targetNode = SQL["group_id"].ToString();   // находим ID новой родительской группы

                    }

                }

                SQLiteDataReader SQL2 = dbExecReader($"SELECT group_id FROM groups WHERE group_name='{draggedNode}'");   // Находим ID перемещаемой группы
                if (SQL2.HasRows)
                {
                    while (SQL2.Read())
                    {
                        draggedNode = SQL2["group_id"].ToString();   // находим ID перемещаемой группы

                    }

                }

                dbExecNonQuery($"UPDATE groups SET parent_id = '{targetNode}' WHERE group_id = {draggedNode};");    //Обновляем список групп в базе
                tvGroups.Nodes.Clear(); // Очищаем список групп в TreeView
                groupAdd();  // Формируем список групп в TreeView из БД

            }
            catch (SQLiteException err)
            {
                MessageBox.Show($"Ошибка запроса к БД:\n {err}");
            }

          
        }

        private bool ContainsNode(TreeNode node1, TreeNode node2)
        {
            try
            {
                if (node2 == null) return false;
                if (node2.Parent == null) return false;
                if (node2.Parent.Equals(node1)) return true;
                return ContainsNode(node1, node2.Parent);
            }
            catch
            {
                return false;
            }

        }

        #endregion DragDrop items 

    }
}
