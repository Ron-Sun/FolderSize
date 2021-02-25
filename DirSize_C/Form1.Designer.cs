
namespace DirSize_C
{
    partial class Form1
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
            this.WorkLabel = new System.Windows.Forms.Label();
            this.FolderGetBtn = new System.Windows.Forms.Button();
            this.FolderBox = new System.Windows.Forms.TextBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShortSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FullSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileBox = new System.Windows.Forms.RichTextBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quicPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorkLabel
            // 
            this.WorkLabel.AutoSize = true;
            this.WorkLabel.BackColor = System.Drawing.Color.Lime;
            this.WorkLabel.Location = new System.Drawing.Point(251, 10);
            this.WorkLabel.Name = "WorkLabel";
            this.WorkLabel.Size = new System.Drawing.Size(53, 13);
            this.WorkLabel.TabIndex = 13;
            this.WorkLabel.Text = "Working !";
            this.WorkLabel.Visible = false;
            // 
            // FolderGetBtn
            // 
            this.FolderGetBtn.Location = new System.Drawing.Point(6, 28);
            this.FolderGetBtn.Name = "FolderGetBtn";
            this.FolderGetBtn.Size = new System.Drawing.Size(48, 20);
            this.FolderGetBtn.TabIndex = 12;
            this.FolderGetBtn.Text = "Open";
            this.FolderGetBtn.UseVisualStyleBackColor = true;
            this.FolderGetBtn.Click += new System.EventHandler(this.FolderGetBtn_Click);
            // 
            // FolderBox
            // 
            this.FolderBox.Location = new System.Drawing.Point(63, 29);
            this.FolderBox.Name = "FolderBox";
            this.FolderBox.Size = new System.Drawing.Size(338, 20);
            this.FolderBox.TabIndex = 11;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(403, 24);
            this.MenuStrip1.TabIndex = 9;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FolderSelectToolStripMenuItem,
            this.ToolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // FolderSelectToolStripMenuItem
            // 
            this.FolderSelectToolStripMenuItem.Name = "FolderSelectToolStripMenuItem";
            this.FolderSelectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FolderSelectToolStripMenuItem.Text = "Select folder";
            this.FolderSelectToolStripMenuItem.Click += new System.EventHandler(this.FolderSelectToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShortSizeToolStripMenuItem,
            this.FullSizeToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // ShortSizeToolStripMenuItem
            // 
            this.ShortSizeToolStripMenuItem.Name = "ShortSizeToolStripMenuItem";
            this.ShortSizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ShortSizeToolStripMenuItem.Text = "Short nr size";
            this.ShortSizeToolStripMenuItem.Click += new System.EventHandler(this.ShortSizeToolStripMenuItem_Click);
            // 
            // FullSizeToolStripMenuItem
            // 
            this.FullSizeToolStripMenuItem.Name = "FullSizeToolStripMenuItem";
            this.FullSizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FullSizeToolStripMenuItem.Text = "Full nr size";
            this.FullSizeToolStripMenuItem.Click += new System.EventHandler(this.FullSizeToolStripMenuItem_Click);
            // 
            // FileBox
            // 
            this.FileBox.DetectUrls = false;
            this.FileBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileBox.Location = new System.Drawing.Point(2, 48);
            this.FileBox.Name = "FileBox";
            this.FileBox.Size = new System.Drawing.Size(400, 400);
            this.FileBox.TabIndex = 10;
            this.FileBox.Text = "";
            this.FileBox.WordWrap = false;
            this.FileBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FileBox_MouseClick);
            this.FileBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FileBox_MouseClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.quicPathToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // quicPathToolStripMenuItem
            // 
            this.quicPathToolStripMenuItem.Name = "quicPathToolStripMenuItem";
            this.quicPathToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quicPathToolStripMenuItem.Text = "Quic path";
            this.quicPathToolStripMenuItem.Click += new System.EventHandler(this.quicPathToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 449);
            this.Controls.Add(this.WorkLabel);
            this.Controls.Add(this.FolderGetBtn);
            this.Controls.Add(this.FolderBox);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.FileBox);
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "Form1";
            this.Text = "DirSize 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label WorkLabel;
        internal System.Windows.Forms.Button FolderGetBtn;
        internal System.Windows.Forms.TextBox FolderBox;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FolderSelectToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ShortSizeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FullSizeToolStripMenuItem;
        internal System.Windows.Forms.RichTextBox FileBox;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quicPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

