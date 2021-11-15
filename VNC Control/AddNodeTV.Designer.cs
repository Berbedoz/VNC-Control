
namespace VNC_Control
{
    partial class AddNodeTV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNodeTV));
            this.lbAddNode = new System.Windows.Forms.Label();
            this.tbAddNode = new System.Windows.Forms.TextBox();
            this.btAddNodeOK = new System.Windows.Forms.Button();
            this.btAddNodeClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAddNode
            // 
            this.lbAddNode.AutoSize = true;
            this.lbAddNode.Location = new System.Drawing.Point(13, 13);
            this.lbAddNode.Name = "lbAddNode";
            this.lbAddNode.Size = new System.Drawing.Size(122, 15);
            this.lbAddNode.TabIndex = 0;
            this.lbAddNode.Text = "Введите имя группы:";
            // 
            // tbAddNode
            // 
            this.tbAddNode.Location = new System.Drawing.Point(141, 10);
            this.tbAddNode.Name = "tbAddNode";
            this.tbAddNode.Size = new System.Drawing.Size(315, 23);
            this.tbAddNode.TabIndex = 1;
            this.tbAddNode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAddNode_KeyDown);
            // 
            // btAddNodeOK
            // 
            this.btAddNodeOK.Location = new System.Drawing.Point(300, 52);
            this.btAddNodeOK.Name = "btAddNodeOK";
            this.btAddNodeOK.Size = new System.Drawing.Size(75, 23);
            this.btAddNodeOK.TabIndex = 2;
            this.btAddNodeOK.Text = "Добавить";
            this.btAddNodeOK.UseVisualStyleBackColor = true;
            this.btAddNodeOK.Click += new System.EventHandler(this.btAddNodeOK_Click);
            // 
            // btAddNodeClose
            // 
            this.btAddNodeClose.Location = new System.Drawing.Point(381, 52);
            this.btAddNodeClose.Name = "btAddNodeClose";
            this.btAddNodeClose.Size = new System.Drawing.Size(75, 23);
            this.btAddNodeClose.TabIndex = 3;
            this.btAddNodeClose.Text = "Отмена";
            this.btAddNodeClose.UseVisualStyleBackColor = true;
            this.btAddNodeClose.Click += new System.EventHandler(this.btAddNodeClose_Click);
            // 
            // AddNodeTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btAddNodeClose;
            this.ClientSize = new System.Drawing.Size(476, 82);
            this.Controls.Add(this.btAddNodeClose);
            this.Controls.Add(this.btAddNodeOK);
            this.Controls.Add(this.tbAddNode);
            this.Controls.Add(this.lbAddNode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNodeTV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить группу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddNode;
        private System.Windows.Forms.TextBox tbAddNode;
        private System.Windows.Forms.Button btAddNodeOK;
        private System.Windows.Forms.Button btAddNodeClose;
    }
}