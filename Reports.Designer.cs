namespace Homepage
{
    partial class Reports
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdoOverdue = new System.Windows.Forms.RadioButton();
            this.rdoIssued = new System.Windows.Forms.RadioButton();
            this.rdoBooks = new System.Windows.Forms.RadioButton();
            this.lblReport = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 170);
            this.dataGridView1.TabIndex = 15;
            // 
            // rdoOverdue
            // 
            this.rdoOverdue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoOverdue.AutoSize = true;
            this.rdoOverdue.Location = new System.Drawing.Point(34, 153);
            this.rdoOverdue.Name = "rdoOverdue";
            this.rdoOverdue.Size = new System.Drawing.Size(109, 19);
            this.rdoOverdue.TabIndex = 14;
            this.rdoOverdue.TabStop = true;
            this.rdoOverdue.Text = "Overdue Books";
            this.rdoOverdue.UseVisualStyleBackColor = true;
            // 
            // rdoIssued
            // 
            this.rdoIssued.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoIssued.AutoSize = true;
            this.rdoIssued.Location = new System.Drawing.Point(34, 126);
            this.rdoIssued.Name = "rdoIssued";
            this.rdoIssued.Size = new System.Drawing.Size(98, 19);
            this.rdoIssued.TabIndex = 13;
            this.rdoIssued.TabStop = true;
            this.rdoIssued.Text = "Issued Books";
            this.rdoIssued.UseVisualStyleBackColor = true;
            // 
            // rdoBooks
            // 
            this.rdoBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoBooks.AutoSize = true;
            this.rdoBooks.Location = new System.Drawing.Point(34, 98);
            this.rdoBooks.Name = "rdoBooks";
            this.rdoBooks.Size = new System.Drawing.Size(80, 19);
            this.rdoBooks.TabIndex = 12;
            this.rdoBooks.TabStop = true;
            this.rdoBooks.Text = "All Books";
            this.rdoBooks.UseVisualStyleBackColor = true;
            // 
            // lblReport
            // 
            this.lblReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(30, 47);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(107, 13);
            this.lblReport.TabIndex = 11;
            this.lblReport.Text = "Generate Reports";
            // 
            // btnReport
            // 
            this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReport.Location = new System.Drawing.Point(34, 193);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(127, 34);
            this.btnReport.TabIndex = 16;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(698, 448);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdoOverdue);
            this.Controls.Add(this.rdoIssued);
            this.Controls.Add(this.rdoBooks);
            this.Controls.Add(this.lblReport);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdoOverdue;
        private System.Windows.Forms.RadioButton rdoIssued;
        private System.Windows.Forms.RadioButton rdoBooks;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Button btnReport;
    }
}