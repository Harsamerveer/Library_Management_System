namespace Homepage
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playWithBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playWithMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playWithLibrarianEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playWithBooksToolStripMenuItem,
            this.playWithMembersToolStripMenuItem,
            this.playWithLibrarianEmployeesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // playWithBooksToolStripMenuItem
            // 
            this.playWithBooksToolStripMenuItem.Name = "playWithBooksToolStripMenuItem";
            this.playWithBooksToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.playWithBooksToolStripMenuItem.Text = "Play with Books";
            this.playWithBooksToolStripMenuItem.Click += new System.EventHandler(this.PlayWithBooksToolStripMenuItem_Click);
            // 
            // playWithMembersToolStripMenuItem
            // 
            this.playWithMembersToolStripMenuItem.Name = "playWithMembersToolStripMenuItem";
            this.playWithMembersToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.playWithMembersToolStripMenuItem.Text = "Play with Members";
            this.playWithMembersToolStripMenuItem.Click += new System.EventHandler(this.PlayWithMembersToolStripMenuItem_Click);
            // 
            // playWithLibrarianEmployeesToolStripMenuItem
            // 
            this.playWithLibrarianEmployeesToolStripMenuItem.Name = "playWithLibrarianEmployeesToolStripMenuItem";
            this.playWithLibrarianEmployeesToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.playWithLibrarianEmployeesToolStripMenuItem.Text = "Play with Librarian Employees ";
            this.playWithLibrarianEmployeesToolStripMenuItem.Click += new System.EventHandler(this.PlayWithLibrarianEmployeesToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(602, 403);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playWithBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playWithMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playWithLibrarianEmployeesToolStripMenuItem;
    }
}