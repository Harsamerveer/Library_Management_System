namespace Homepage
{
    partial class Librarian
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSelectBook = new System.Windows.Forms.Label();
            this.lblSelectMember = new System.Windows.Forms.Label();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.cmbMembers = new System.Windows.Forms.ComboBox();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblReport = new System.Windows.Forms.Label();
            this.rdoBooks = new System.Windows.Forms.RadioButton();
            this.rdoIssued = new System.Windows.Forms.RadioButton();
            this.rdoOverdue = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExtension = new System.Windows.Forms.Button();
            this.lblOptions = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblFine = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblDue = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblOptions);
            this.tabPage1.Controls.Add(this.btnExtension);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.rdoOverdue);
            this.tabPage1.Controls.Add(this.rdoIssued);
            this.tabPage1.Controls.Add(this.rdoBooks);
            this.tabPage1.Controls.Add(this.lblReport);
            this.tabPage1.Controls.Add(this.btnAccept);
            this.tabPage1.Controls.Add(this.btnIssue);
            this.tabPage1.Controls.Add(this.cmbMembers);
            this.tabPage1.Controls.Add(this.cmbBooks);
            this.tabPage1.Controls.Add(this.lblSelectMember);
            this.tabPage1.Controls.Add(this.lblSelectBook);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPayment);
            this.tabPage2.Controls.Add(this.lblDue);
            this.tabPage2.Controls.Add(this.txtTotal);
            this.tabPage2.Controls.Add(this.txtFine);
            this.tabPage2.Controls.Add(this.lblFine);
            this.tabPage2.Controls.Add(this.txtAmount);
            this.tabPage2.Controls.Add(this.lblAmount);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Payments";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblSelectBook
            // 
            this.lblSelectBook.AutoSize = true;
            this.lblSelectBook.Location = new System.Drawing.Point(19, 48);
            this.lblSelectBook.Name = "lblSelectBook";
            this.lblSelectBook.Size = new System.Drawing.Size(65, 13);
            this.lblSelectBook.TabIndex = 0;
            this.lblSelectBook.Text = "Select Book";
            // 
            // lblSelectMember
            // 
            this.lblSelectMember.AutoSize = true;
            this.lblSelectMember.Location = new System.Drawing.Point(19, 84);
            this.lblSelectMember.Name = "lblSelectMember";
            this.lblSelectMember.Size = new System.Drawing.Size(78, 13);
            this.lblSelectMember.TabIndex = 1;
            this.lblSelectMember.Text = "Select Member";
            // 
            // cmbBooks
            // 
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(145, 48);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(121, 21);
            this.cmbBooks.TabIndex = 2;
            // 
            // cmbMembers
            // 
            this.cmbMembers.FormattingEnabled = true;
            this.cmbMembers.Location = new System.Drawing.Point(145, 84);
            this.cmbMembers.Name = "cmbMembers";
            this.cmbMembers.Size = new System.Drawing.Size(121, 21);
            this.cmbMembers.TabIndex = 3;
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(382, 43);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(170, 23);
            this.btnIssue.TabIndex = 4;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(382, 84);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(170, 23);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(19, 246);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(107, 13);
            this.lblReport.TabIndex = 6;
            this.lblReport.Text = "Generate Reports";
            // 
            // rdoBooks
            // 
            this.rdoBooks.AutoSize = true;
            this.rdoBooks.Location = new System.Drawing.Point(136, 246);
            this.rdoBooks.Name = "rdoBooks";
            this.rdoBooks.Size = new System.Drawing.Size(69, 17);
            this.rdoBooks.TabIndex = 7;
            this.rdoBooks.TabStop = true;
            this.rdoBooks.Text = "All Books";
            this.rdoBooks.UseVisualStyleBackColor = true;
            // 
            // rdoIssued
            // 
            this.rdoIssued.AutoSize = true;
            this.rdoIssued.Location = new System.Drawing.Point(136, 270);
            this.rdoIssued.Name = "rdoIssued";
            this.rdoIssued.Size = new System.Drawing.Size(89, 17);
            this.rdoIssued.TabIndex = 8;
            this.rdoIssued.TabStop = true;
            this.rdoIssued.Text = "Issued Books";
            this.rdoIssued.UseVisualStyleBackColor = true;
            // 
            // rdoOverdue
            // 
            this.rdoOverdue.AutoSize = true;
            this.rdoOverdue.Location = new System.Drawing.Point(136, 294);
            this.rdoOverdue.Name = "rdoOverdue";
            this.rdoOverdue.Size = new System.Drawing.Size(99, 17);
            this.rdoOverdue.TabIndex = 9;
            this.rdoOverdue.TabStop = true;
            this.rdoOverdue.Text = "Overdue Books";
            this.rdoOverdue.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 152);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(22, 163);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(183, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnExtension
            // 
            this.btnExtension.Location = new System.Drawing.Point(22, 208);
            this.btnExtension.Name = "btnExtension";
            this.btnExtension.Size = new System.Drawing.Size(183, 23);
            this.btnExtension.TabIndex = 12;
            this.btnExtension.Text = "Extensions";
            this.btnExtension.UseVisualStyleBackColor = true;
            this.btnExtension.Click += new System.EventHandler(this.BtnExtension_Click);
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(22, 125);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(82, 13);
            this.lblOptions.TabIndex = 13;
            this.lblOptions.Text = "More Options";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Member";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(33, 96);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(156, 96);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 7;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Location = new System.Drawing.Point(33, 139);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(27, 13);
            this.lblFine.TabIndex = 8;
            this.lblFine.Text = "Fine";
            // 
            // txtFine
            // 
            this.txtFine.Location = new System.Drawing.Point(156, 139);
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(121, 20);
            this.txtFine.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(156, 181);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 10;
            // 
            // lblDue
            // 
            this.lblDue.AutoSize = true;
            this.lblDue.Location = new System.Drawing.Point(33, 188);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(93, 13);
            this.lblDue.TabIndex = 11;
            this.lblDue.Text = "Total Amount Due";
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(36, 233);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(180, 23);
            this.btnPayment.TabIndex = 12;
            this.btnPayment.Text = "Make a Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // Librarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 540);
            this.Controls.Add(this.tabControl1);
            this.Name = "Librarian";
            this.Text = "Librarian";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdoOverdue;
        private System.Windows.Forms.RadioButton rdoIssued;
        private System.Windows.Forms.RadioButton rdoBooks;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.ComboBox cmbMembers;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Label lblSelectMember;
        private System.Windows.Forms.Label lblSelectBook;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Button btnExtension;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnPayment;
    }
}