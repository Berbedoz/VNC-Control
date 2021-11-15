
namespace VNC_Control
{
    partial class AddItemDGV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemDGV));
            this.lbAddItemDGVName = new System.Windows.Forms.Label();
            this.tbAddItemDGVName = new System.Windows.Forms.TextBox();
            this.btAddItemDGVOK = new System.Windows.Forms.Button();
            this.btAddItemDGVClose = new System.Windows.Forms.Button();
            this.lbAddItemDGVIP = new System.Windows.Forms.Label();
            this.lbAddItemDGVPass = new System.Windows.Forms.Label();
            this.tbAddItemDGVIP = new System.Windows.Forms.TextBox();
            this.tbAddItemDGVPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbAddItemDGVName
            // 
            this.lbAddItemDGVName.AutoSize = true;
            this.lbAddItemDGVName.Location = new System.Drawing.Point(12, 18);
            this.lbAddItemDGVName.Name = "lbAddItemDGVName";
            this.lbAddItemDGVName.Size = new System.Drawing.Size(34, 15);
            this.lbAddItemDGVName.TabIndex = 0;
            this.lbAddItemDGVName.Text = "Имя:";
            // 
            // tbAddItemDGVName
            // 
            this.tbAddItemDGVName.Location = new System.Drawing.Point(78, 10);
            this.tbAddItemDGVName.Name = "tbAddItemDGVName";
            this.tbAddItemDGVName.Size = new System.Drawing.Size(315, 23);
            this.tbAddItemDGVName.TabIndex = 1;
            this.tbAddItemDGVName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAddItemDGVName_KeyDown);
            // 
            // btAddItemDGVOK
            // 
            this.btAddItemDGVOK.Location = new System.Drawing.Point(236, 111);
            this.btAddItemDGVOK.Name = "btAddItemDGVOK";
            this.btAddItemDGVOK.Size = new System.Drawing.Size(75, 23);
            this.btAddItemDGVOK.TabIndex = 4;
            this.btAddItemDGVOK.Text = "Добавить";
            this.btAddItemDGVOK.UseVisualStyleBackColor = true;
            this.btAddItemDGVOK.Click += new System.EventHandler(this.btAddItemDGVOK_Click);
            // 
            // btAddItemDGVClose
            // 
            this.btAddItemDGVClose.Location = new System.Drawing.Point(316, 111);
            this.btAddItemDGVClose.Name = "btAddItemDGVClose";
            this.btAddItemDGVClose.Size = new System.Drawing.Size(75, 23);
            this.btAddItemDGVClose.TabIndex = 5;
            this.btAddItemDGVClose.Text = "Отмена";
            this.btAddItemDGVClose.UseVisualStyleBackColor = true;
            this.btAddItemDGVClose.Click += new System.EventHandler(this.btAddItemDGVClose_Click);
            // 
            // lbAddItemDGVIP
            // 
            this.lbAddItemDGVIP.AutoSize = true;
            this.lbAddItemDGVIP.Location = new System.Drawing.Point(12, 47);
            this.lbAddItemDGVIP.Name = "lbAddItemDGVIP";
            this.lbAddItemDGVIP.Size = new System.Drawing.Size(54, 15);
            this.lbAddItemDGVIP.TabIndex = 0;
            this.lbAddItemDGVIP.Text = "IP адрес:";
            // 
            // lbAddItemDGVPass
            // 
            this.lbAddItemDGVPass.AutoSize = true;
            this.lbAddItemDGVPass.Location = new System.Drawing.Point(12, 76);
            this.lbAddItemDGVPass.Name = "lbAddItemDGVPass";
            this.lbAddItemDGVPass.Size = new System.Drawing.Size(52, 15);
            this.lbAddItemDGVPass.TabIndex = 0;
            this.lbAddItemDGVPass.Text = "Пароль:";
            // 
            // tbAddItemDGVIP
            // 
            this.tbAddItemDGVIP.Location = new System.Drawing.Point(78, 39);
            this.tbAddItemDGVIP.Name = "tbAddItemDGVIP";
            this.tbAddItemDGVIP.Size = new System.Drawing.Size(315, 23);
            this.tbAddItemDGVIP.TabIndex = 2;
            this.tbAddItemDGVIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAddItemDGVIP_KeyDown);
            // 
            // tbAddItemDGVPass
            // 
            this.tbAddItemDGVPass.Location = new System.Drawing.Point(78, 68);
            this.tbAddItemDGVPass.Name = "tbAddItemDGVPass";
            this.tbAddItemDGVPass.Size = new System.Drawing.Size(315, 23);
            this.tbAddItemDGVPass.TabIndex = 3;
            this.tbAddItemDGVPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAddItemDGVPass_KeyDown);
            // 
            // AddItemDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btAddItemDGVClose;
            this.ClientSize = new System.Drawing.Size(402, 141);
            this.Controls.Add(this.tbAddItemDGVPass);
            this.Controls.Add(this.tbAddItemDGVIP);
            this.Controls.Add(this.lbAddItemDGVPass);
            this.Controls.Add(this.lbAddItemDGVIP);
            this.Controls.Add(this.btAddItemDGVClose);
            this.Controls.Add(this.btAddItemDGVOK);
            this.Controls.Add(this.tbAddItemDGVName);
            this.Controls.Add(this.lbAddItemDGVName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItemDGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить запись";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddItemDGVName;
        public System.Windows.Forms.TextBox tbAddItemDGVName;
        private System.Windows.Forms.Button btAddItemDGVOK;
        private System.Windows.Forms.Button btAddItemDGVClose;
        private System.Windows.Forms.Label lbAddItemDGVIP;
        private System.Windows.Forms.Label lbAddItemDGVPass;
        public System.Windows.Forms.TextBox tbAddItemDGVIP;
        public System.Windows.Forms.TextBox tbAddItemDGVPass;
    }
}