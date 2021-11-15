
namespace VNC_Control
{
    partial class RenameNodeTV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameNodeTV));
            this.btRenameNodeClose = new System.Windows.Forms.Button();
            this.btRenameNodeOK = new System.Windows.Forms.Button();
            this.tbRenameNode = new System.Windows.Forms.TextBox();
            this.lbRenameNode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btRenameNodeClose
            // 
            this.btRenameNodeClose.Location = new System.Drawing.Point(380, 48);
            this.btRenameNodeClose.Name = "btRenameNodeClose";
            this.btRenameNodeClose.Size = new System.Drawing.Size(75, 23);
            this.btRenameNodeClose.TabIndex = 3;
            this.btRenameNodeClose.Text = "Отмена";
            this.btRenameNodeClose.UseVisualStyleBackColor = true;
            this.btRenameNodeClose.Click += new System.EventHandler(this.btRenameNodeClose_Click);
            // 
            // btRenameNodeOK
            // 
            this.btRenameNodeOK.Location = new System.Drawing.Point(299, 48);
            this.btRenameNodeOK.Name = "btRenameNodeOK";
            this.btRenameNodeOK.Size = new System.Drawing.Size(75, 23);
            this.btRenameNodeOK.TabIndex = 2;
            this.btRenameNodeOK.Text = "Изменить";
            this.btRenameNodeOK.UseVisualStyleBackColor = true;
            this.btRenameNodeOK.Click += new System.EventHandler(this.btRenameNodeOK_Click);
            // 
            // tbRenameNode
            // 
            this.tbRenameNode.Location = new System.Drawing.Point(176, 6);
            this.tbRenameNode.Name = "tbRenameNode";
            this.tbRenameNode.Size = new System.Drawing.Size(315, 23);
            this.tbRenameNode.TabIndex = 1;
            this.tbRenameNode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbRenameNode_KeyDown);
            // 
            // lbRenameNode
            // 
            this.lbRenameNode.AutoSize = true;
            this.lbRenameNode.Location = new System.Drawing.Point(12, 9);
            this.lbRenameNode.Name = "lbRenameNode";
            this.lbRenameNode.Size = new System.Drawing.Size(158, 15);
            this.lbRenameNode.TabIndex = 4;
            this.lbRenameNode.Text = "Введите новое имя группы:";
            // 
            // RenameNodeTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btRenameNodeClose;
            this.ClientSize = new System.Drawing.Size(497, 79);
            this.Controls.Add(this.btRenameNodeClose);
            this.Controls.Add(this.btRenameNodeOK);
            this.Controls.Add(this.tbRenameNode);
            this.Controls.Add(this.lbRenameNode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenameNodeTV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Переименовать группу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRenameNodeClose;
        private System.Windows.Forms.Button btRenameNodeOK;
        private System.Windows.Forms.TextBox tbRenameNode;
        private System.Windows.Forms.Label lbRenameNode;
    }
}