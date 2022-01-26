﻿namespace Homepage
{
    partial class History
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdoIssued = new System.Windows.Forms.RadioButton();
            this.rdoReturned = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "View History";
            // 
            // rdoIssued
            // 
            this.rdoIssued.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoIssued.AutoSize = true;
            this.rdoIssued.Location = new System.Drawing.Point(24, 89);
            this.rdoIssued.Margin = new System.Windows.Forms.Padding(4);
            this.rdoIssued.Name = "rdoIssued";
            this.rdoIssued.Size = new System.Drawing.Size(190, 20);
            this.rdoIssued.TabIndex = 1;
            this.rdoIssued.TabStop = true;
            this.rdoIssued.Text = "History of Issued Books";
            this.rdoIssued.UseVisualStyleBackColor = true;
            // 
            // rdoReturned
            // 
            this.rdoReturned.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoReturned.AutoSize = true;
            this.rdoReturned.Location = new System.Drawing.Point(24, 130);
            this.rdoReturned.Margin = new System.Windows.Forms.Padding(4);
            this.rdoReturned.Name = "rdoReturned";
            this.rdoReturned.Size = new System.Drawing.Size(200, 20);
            this.rdoReturned.TabIndex = 2;
            this.rdoReturned.TabStop = true;
            this.rdoReturned.Text = "History of returned books";
            this.rdoReturned.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 185);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShow.Location = new System.Drawing.Point(43, 183);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(106, 29);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1178, 252);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdoReturned);
            this.Controls.Add(this.rdoIssued);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoIssued;
        private System.Windows.Forms.RadioButton rdoReturned;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShow;
    }
}