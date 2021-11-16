
using System;
using System.Windows.Forms;

namespace VNC_Control
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btConnect = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.tvGroups = new System.Windows.Forms.TreeView();
            this.ilForTV = new System.Windows.Forms.ImageList(this.components);
            this.cbSendPass = new System.Windows.Forms.CheckBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btShowAll = new System.Windows.Forms.Button();
            this.cmsTVgroupsSelectedItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btReloadTV = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsDGVSelectedItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Image = ((System.Drawing.Image)(resources.GetObject("btConnect.Image")));
            this.btConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConnect.Location = new System.Drawing.Point(0, 0);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(120, 36);
            this.btConnect.TabIndex = 0;
            this.btConnect.Text = "Подключить";
            this.btConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(821, 615);
            this.btClose.Margin = new System.Windows.Forms.Padding(0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(99, 41);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Закрыть";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // tvGroups
            // 
            this.tvGroups.AllowDrop = true;
            this.tvGroups.Cursor = System.Windows.Forms.Cursors.Default;
            this.tvGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvGroups.HideSelection = false;
            this.tvGroups.ImageIndex = 0;
            this.tvGroups.ImageList = this.ilForTV;
            this.tvGroups.Location = new System.Drawing.Point(0, 0);
            this.tvGroups.Name = "tvGroups";
            this.tvGroups.SelectedImageIndex = 0;
            this.tvGroups.Size = new System.Drawing.Size(453, 578);
            this.tvGroups.TabIndex = 3;
            this.tvGroups.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvGroups_NodeMouseClick);
            // 
            // ilForTV
            // 
            this.ilForTV.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilForTV.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilForTV.ImageStream")));
            this.ilForTV.TransparentColor = System.Drawing.Color.Transparent;
            this.ilForTV.Images.SetKeyName(0, "folder-close16.png");
            this.ilForTV.Images.SetKeyName(1, "folder-open16.png");
            // 
            // cbSendPass
            // 
            this.cbSendPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSendPass.AutoSize = true;
            this.cbSendPass.Checked = true;
            this.cbSendPass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSendPass.Location = new System.Drawing.Point(411, 10);
            this.cbSendPass.Name = "cbSendPass";
            this.cbSendPass.Size = new System.Drawing.Size(132, 19);
            this.cbSendPass.TabIndex = 4;
            this.cbSendPass.Text = "Передавать пароль";
            this.cbSendPass.UseVisualStyleBackColor = true;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvList.RowTemplate.Height = 25;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(469, 578);
            this.dgvList.TabIndex = 16;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            // 
            // btShowAll
            // 
            this.btShowAll.Image = ((System.Drawing.Image)(resources.GetObject("btShowAll.Image")));
            this.btShowAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btShowAll.Location = new System.Drawing.Point(273, 0);
            this.btShowAll.Name = "btShowAll";
            this.btShowAll.Size = new System.Drawing.Size(116, 36);
            this.btShowAll.TabIndex = 18;
            this.btShowAll.Text = "Показать все";
            this.btShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btShowAll.UseVisualStyleBackColor = true;
            this.btShowAll.Click += new System.EventHandler(this.btShowAll_Click);
            // 
            // cmsTVgroupsSelectedItem
            // 
            this.cmsTVgroupsSelectedItem.Name = "cmsTVgroupsSelectedItem";
            this.cmsTVgroupsSelectedItem.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btReloadTV);
            this.panel1.Controls.Add(this.btConnect);
            this.panel1.Controls.Add(this.btShowAll);
            this.panel1.Controls.Add(this.cbSendPass);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 36);
            this.panel1.TabIndex = 19;
            // 
            // btReloadTV
            // 
            this.btReloadTV.Image = ((System.Drawing.Image)(resources.GetObject("btReloadTV.Image")));
            this.btReloadTV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReloadTV.Location = new System.Drawing.Point(126, 0);
            this.btReloadTV.Name = "btReloadTV";
            this.btReloadTV.Size = new System.Drawing.Size(141, 36);
            this.btReloadTV.TabIndex = 19;
            this.btReloadTV.Text = "Обновить группы";
            this.btReloadTV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btReloadTV.UseVisualStyleBackColor = true;
            this.btReloadTV.Click += new System.EventHandler(this.btReloadTV_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(0, 36);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvGroups);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.dgvList);
            this.splitContainer1.Size = new System.Drawing.Size(926, 578);
            this.splitContainer1.SplitterDistance = 453;
            this.splitContainer1.TabIndex = 20;
            this.splitContainer1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 633);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Версия: 0.0.9";
            // 
            // cmsDGVSelectedItem
            // 
            this.cmsDGVSelectedItem.Name = "cmsDGVSelectedItem";
            this.cmsDGVSelectedItem.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 657);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(942, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VNC Control";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.TreeView tvGroups;
        private System.Windows.Forms.CheckBox cbSendPass;
        private DataGridView dgvList;
        private Button btShowAll;
        private ContextMenuStrip cmsTVgroupsSelectedItem;
        private ContextMenuStrip cmsTVgroupsSelectedItemDel;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private Label label1;
        private ContextMenuStrip cmsDGVSelectedItem;
        private Button btReloadTV;
        private ImageList ilForTV;
    }
}

