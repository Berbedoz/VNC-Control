
namespace VNC_Control
{
    partial class RenameItemDGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameItemDGV));
            this.lbRenameItemDGVName = new System.Windows.Forms.Label();
            this.tbRenameItemDGVName = new System.Windows.Forms.TextBox();
            this.btRenameItemDGVOK = new System.Windows.Forms.Button();
            this.btRenameItemDGVClose = new System.Windows.Forms.Button();
            this.lbRenameItemDGVIP = new System.Windows.Forms.Label();
            this.lbRenameItemDGVPass = new System.Windows.Forms.Label();
            this.tbRenameItemDGVIP = new System.Windows.Forms.TextBox();
            this.tbRenameItemDGVPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbRenameItemDGVName
            // 
            this.lbRenameItemDGVName.AutoSize = true;
            this.lbRenameItemDGVName.Location = new System.Drawing.Point(12, 18);
            this.lbRenameItemDGVName.Name = "lbRenameItemDGVName";
            this.lbRenameItemDGVName.Size = new System.Drawing.Size(34, 15);
            this.lbRenameItemDGVName.TabIndex = 0;
            this.lbRenameItemDGVName.Text = "Имя:";
            // 
            // tbRenameItemDGVName
            // 
            this.tbRenameItemDGVName.Location = new System.Drawing.Point(78, 10);
            this.tbRenameItemDGVName.Name = "tbRenameItemDGVName";
            this.tbRenameItemDGVName.Size = new System.Drawing.Size(315, 23);
            this.tbRenameItemDGVName.TabIndex = 1;
            this.tbRenameItemDGVName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbRenameItemDGVName_KeyDown);
            // 
            // btRenameItemDGVOK
            // 
            this.btRenameItemDGVOK.Location = new System.Drawing.Point(236, 111);
            this.btRenameItemDGVOK.Name = "btRenameItemDGVOK";
            this.btRenameItemDGVOK.Size = new System.Drawing.Size(75, 23);
            this.btRenameItemDGVOK.TabIndex = 4;
            this.btRenameItemDGVOK.Text = "Изменить";
            this.btRenameItemDGVOK.UseVisualStyleBackColor = true;
            this.btRenameItemDGVOK.Click += new System.EventHandler(this.btRenameItemDGVOK_Click);
            // 
            // btRenameItemDGVClose
            // 
            this.btRenameItemDGVClose.Location = new System.Drawing.Point(316, 111);
            this.btRenameItemDGVClose.Name = "btRenameItemDGVClose";
            this.btRenameItemDGVClose.Size = new System.Drawing.Size(75, 23);
            this.btRenameItemDGVClose.TabIndex = 5;
            this.btRenameItemDGVClose.Text = "Отмена";
            this.btRenameItemDGVClose.UseVisualStyleBackColor = true;
            this.btRenameItemDGVClose.Click += new System.EventHandler(this.btRenameItemDGVClose_Click);
            // 
            // lbRenameItemDGVIP
            // 
            this.lbRenameItemDGVIP.AutoSize = true;
            this.lbRenameItemDGVIP.Location = new System.Drawing.Point(12, 47);
            this.lbRenameItemDGVIP.Name = "lbRenameItemDGVIP";
            this.lbRenameItemDGVIP.Size = new System.Drawing.Size(54, 15);
            this.lbRenameItemDGVIP.TabIndex = 0;
            this.lbRenameItemDGVIP.Text = "IP адрес:";
            // 
            // lbRenameItemDGVPass
            // 
            this.lbRenameItemDGVPass.AutoSize = true;
            this.lbRenameItemDGVPass.Location = new System.Drawing.Point(12, 76);
            this.lbRenameItemDGVPass.Name = "lbRenameItemDGVPass";
            this.lbRenameItemDGVPass.Size = new System.Drawing.Size(52, 15);
            this.lbRenameItemDGVPass.TabIndex = 0;
            this.lbRenameItemDGVPass.Text = "Пароль:";
            // 
            // tbRenameItemDGVIP
            // 
            this.tbRenameItemDGVIP.Location = new System.Drawing.Point(78, 39);
            this.tbRenameItemDGVIP.Name = "tbRenameItemDGVIP";
            this.tbRenameItemDGVIP.Size = new System.Drawing.Size(315, 23);
            this.tbRenameItemDGVIP.TabIndex = 2;
            this.tbRenameItemDGVIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbRenameItemDGVIP_KeyDown);
            // 
            // tbRenameItemDGVPass
            // 
            this.tbRenameItemDGVPass.Location = new System.Drawing.Point(78, 68);
            this.tbRenameItemDGVPass.Name = "tbRenameItemDGVPass";
            this.tbRenameItemDGVPass.Size = new System.Drawing.Size(315, 23);
            this.tbRenameItemDGVPass.TabIndex = 3;
            this.tbRenameItemDGVPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbRenameItemDGVPass_KeyDown);
            // 
            // RenameItemDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btRenameItemDGVClose;
            this.ClientSize = new System.Drawing.Size(402, 141);
            this.Controls.Add(this.tbRenameItemDGVPass);
            this.Controls.Add(this.tbRenameItemDGVIP);
            this.Controls.Add(this.lbRenameItemDGVPass);
            this.Controls.Add(this.lbRenameItemDGVIP);
            this.Controls.Add(this.btRenameItemDGVClose);
            this.Controls.Add(this.btRenameItemDGVOK);
            this.Controls.Add(this.tbRenameItemDGVName);
            this.Controls.Add(this.lbRenameItemDGVName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenameItemDGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить значение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRenameItemDGVName;
        public System.Windows.Forms.TextBox tbRenameItemDGVName;
        private System.Windows.Forms.Button btRenameItemDGVOK;
        private System.Windows.Forms.Button btRenameItemDGVClose;
        private System.Windows.Forms.Label lbRenameItemDGVIP;
        private System.Windows.Forms.Label lbRenameItemDGVPass;
        public System.Windows.Forms.TextBox tbRenameItemDGVIP;
        public System.Windows.Forms.TextBox tbRenameItemDGVPass;
    }
}