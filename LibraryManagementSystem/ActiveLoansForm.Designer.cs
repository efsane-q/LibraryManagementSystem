namespace LibraryManagementSystem
{
    partial class ActiveLoansForm
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnActiveLoans = new System.Windows.Forms.Button();
            this.btnLoans = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblActiveLoansTitle = new System.Windows.Forms.Label();
            this.pnlActiveLoans = new System.Windows.Forms.Panel();
            this.dgvActiveLoans = new System.Windows.Forms.DataGridView();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlActiveLoans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlSidebar.Controls.Add(this.btnActiveLoans);
            this.pnlSidebar.Controls.Add(this.btnLoans);
            this.pnlSidebar.Controls.Add(this.btnBooks);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(260, 950);
            this.pnlSidebar.TabIndex = 1;
            // 
            // btnActiveLoans
            // 
            this.btnActiveLoans.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnActiveLoans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActiveLoans.FlatAppearance.BorderSize = 0;
            this.btnActiveLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActiveLoans.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnActiveLoans.ForeColor = System.Drawing.Color.White;
            this.btnActiveLoans.Location = new System.Drawing.Point(20, 325);
            this.btnActiveLoans.Name = "btnActiveLoans";
            this.btnActiveLoans.Size = new System.Drawing.Size(220, 50);
            this.btnActiveLoans.TabIndex = 4;
            this.btnActiveLoans.Text = "Qaytarılmamış kitablar";
            this.btnActiveLoans.UseVisualStyleBackColor = false;
            // 
            // btnLoans
            // 
            this.btnLoans.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLoans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoans.FlatAppearance.BorderSize = 0;
            this.btnLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoans.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoans.ForeColor = System.Drawing.Color.White;
            this.btnLoans.Location = new System.Drawing.Point(20, 260);
            this.btnLoans.Name = "btnLoans";
            this.btnLoans.Size = new System.Drawing.Size(220, 50);
            this.btnLoans.TabIndex = 3;
            this.btnLoans.Text = "İcarələr";
            this.btnLoans.UseVisualStyleBackColor = false;
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.Location = new System.Drawing.Point(20, 195);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(220, 50);
            this.btnBooks.TabIndex = 2;
            this.btnBooks.Text = "Kitablar";
            this.btnBooks.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(20, 130);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(220, 50);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Ana səhifə";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(3, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(254, 40);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "LIBRARY SYSTEM";
            // 
            // lblActiveLoansTitle
            // 
            this.lblActiveLoansTitle.AutoSize = true;
            this.lblActiveLoansTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActiveLoansTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblActiveLoansTitle.Location = new System.Drawing.Point(300, 30);
            this.lblActiveLoansTitle.Name = "lblActiveLoansTitle";
            this.lblActiveLoansTitle.Size = new System.Drawing.Size(384, 46);
            this.lblActiveLoansTitle.TabIndex = 2;
            this.lblActiveLoansTitle.Text = "Qaytarılmamış kitablar";
            // 
            // pnlActiveLoans
            // 
            this.pnlActiveLoans.BackColor = System.Drawing.Color.White;
            this.pnlActiveLoans.Controls.Add(this.dgvActiveLoans);
            this.pnlActiveLoans.Location = new System.Drawing.Point(295, 90);
            this.pnlActiveLoans.Name = "pnlActiveLoans";
            this.pnlActiveLoans.Size = new System.Drawing.Size(1220, 700);
            this.pnlActiveLoans.TabIndex = 3;
            // 
            // dgvActiveLoans
            // 
            this.dgvActiveLoans.AllowUserToAddRows = false;
            this.dgvActiveLoans.AllowUserToDeleteRows = false;
            this.dgvActiveLoans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActiveLoans.BackgroundColor = System.Drawing.Color.White;
            this.dgvActiveLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveLoans.Location = new System.Drawing.Point(20, 20);
            this.dgvActiveLoans.MultiSelect = false;
            this.dgvActiveLoans.Name = "dgvActiveLoans";
            this.dgvActiveLoans.ReadOnly = true;
            this.dgvActiveLoans.RowHeadersVisible = false;
            this.dgvActiveLoans.RowHeadersWidth = 51;
            this.dgvActiveLoans.RowTemplate.Height = 24;
            this.dgvActiveLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActiveLoans.Size = new System.Drawing.Size(1180, 660);
            this.dgvActiveLoans.TabIndex = 0;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReturnBook.ForeColor = System.Drawing.Color.White;
            this.btnReturnBook.Location = new System.Drawing.Point(295, 815);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(180, 45);
            this.btnReturnBook.TabIndex = 4;
            this.btnReturnBook.Text = "Kitabı qaytar";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            // 
            // ActiveLoansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1532, 903);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.pnlActiveLoans);
            this.Controls.Add(this.lblActiveLoansTitle);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ActiveLoansForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qaytarılmamış kitablar";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlActiveLoans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnActiveLoans;
        private System.Windows.Forms.Button btnLoans;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblActiveLoansTitle;
        private System.Windows.Forms.Panel pnlActiveLoans;
        private System.Windows.Forms.DataGridView dgvActiveLoans;
        private System.Windows.Forms.Button btnReturnBook;
    }
}