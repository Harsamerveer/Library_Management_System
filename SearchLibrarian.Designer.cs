namespace Homepage
{
    partial class SearchLibrarian
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
            this.rdoPublisher = new System.Windows.Forms.RadioButton();
            this.rdoCategory = new System.Windows.Forms.RadioButton();
            this.rdoAuthor = new System.Windows.Forms.RadioButton();
            this.rdoTitle = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoPublisher
            // 
            this.rdoPublisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoPublisher.AutoSize = true;
            this.rdoPublisher.Location = new System.Drawing.Point(72, 152);
            this.rdoPublisher.Name = "rdoPublisher";
            this.rdoPublisher.Size = new System.Drawing.Size(79, 19);
            this.rdoPublisher.TabIndex = 25;
            this.rdoPublisher.TabStop = true;
            this.rdoPublisher.Text = "Publisher";
            this.rdoPublisher.UseVisualStyleBackColor = true;
            // 
            // rdoCategory
            // 
            this.rdoCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoCategory.AutoSize = true;
            this.rdoCategory.Location = new System.Drawing.Point(72, 203);
            this.rdoCategory.Name = "rdoCategory";
            this.rdoCategory.Size = new System.Drawing.Size(75, 19);
            this.rdoCategory.TabIndex = 24;
            this.rdoCategory.TabStop = true;
            this.rdoCategory.Text = "Category";
            this.rdoCategory.UseVisualStyleBackColor = true;
            // 
            // rdoAuthor
            // 
            this.rdoAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoAuthor.AutoSize = true;
            this.rdoAuthor.Location = new System.Drawing.Point(72, 99);
            this.rdoAuthor.Name = "rdoAuthor";
            this.rdoAuthor.Size = new System.Drawing.Size(64, 19);
            this.rdoAuthor.TabIndex = 23;
            this.rdoAuthor.TabStop = true;
            this.rdoAuthor.Text = "Author";
            this.rdoAuthor.UseVisualStyleBackColor = true;
            // 
            // rdoTitle
            // 
            this.rdoTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoTitle.AutoSize = true;
            this.rdoTitle.Location = new System.Drawing.Point(72, 54);
            this.rdoTitle.Name = "rdoTitle";
            this.rdoTitle.Size = new System.Drawing.Size(51, 19);
            this.rdoTitle.TabIndex = 22;
            this.rdoTitle.TabStop = true;
            this.rdoTitle.Text = "Title";
            this.rdoTitle.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(408, 193);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 43);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 145);
            this.dataGridView1.TabIndex = 20;
            // 
            // txtCategory
            // 
            this.txtCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategory.Location = new System.Drawing.Point(197, 203);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(116, 22);
            this.txtCategory.TabIndex = 19;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPublisher.Location = new System.Drawing.Point(197, 152);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(116, 22);
            this.txtPublisher.TabIndex = 18;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAuthor.Location = new System.Drawing.Point(197, 99);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(116, 22);
            this.txtAuthor.TabIndex = 17;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.Location = new System.Drawing.Point(197, 54);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(116, 22);
            this.txtTitle.TabIndex = 16;
            // 
            // SearchLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(610, 442);
            this.Controls.Add(this.rdoPublisher);
            this.Controls.Add(this.rdoCategory);
            this.Controls.Add(this.rdoAuthor);
            this.Controls.Add(this.rdoTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SearchLibrarian";
            this.Text = "SearchLibrarian";
            this.Load += new System.EventHandler(this.SearchLibrarian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdoPublisher;
        private System.Windows.Forms.RadioButton rdoCategory;
        private System.Windows.Forms.RadioButton rdoAuthor;
        private System.Windows.Forms.RadioButton rdoTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
    }
}