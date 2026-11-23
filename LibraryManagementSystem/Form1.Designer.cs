namespace LibraryManagementSystem
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnLoans = new System.Windows.Forms.Button();
            this.btnActiveLoans = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlTotalBooks = new System.Windows.Forms.Panel();
            this.lblTotalBooksTitle = new System.Windows.Forms.Label();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.pnlTotalMembers = new System.Windows.Forms.Panel();
            this.lblTotalMembersTitle = new System.Windows.Forms.Label();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.pnlReturnedBooks = new System.Windows.Forms.Panel();
            this.lblReturnedBooks = new System.Windows.Forms.Label();
            this.lblReturnedBooksTitle = new System.Windows.Forms.Label();
            this.pnlActiveLoans = new System.Windows.Forms.Panel();
            this.lblActiveLoans = new System.Windows.Forms.Label();
            this.lblActiveLoansTitle = new System.Windows.Forms.Label();
            this.lblRecentLoansTitle = new System.Windows.Forms.Label();
            this.dgvRecentLoans = new System.Windows.Forms.DataGridView();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlTotalBooks.SuspendLayout();
            this.pnlTotalMembers.SuspendLayout();
            this.pnlReturnedBooks.SuspendLayout();
            this.pnlActiveLoans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentLoans)).BeginInit();
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
            this.pnlSidebar.TabIndex = 0;
            this.pnlSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Location = new System.Drawing.Point(260, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1290, 90);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPageTitle.Location = new System.Drawing.Point(35, 25);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(429, 45);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Kitabxana Idarəetmə Paneli";
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.White;
            this.pnlMainContent.Controls.Add(this.dgvRecentLoans);
            this.pnlMainContent.Controls.Add(this.lblRecentLoansTitle);
            this.pnlMainContent.Controls.Add(this.pnlReturnedBooks);
            this.pnlMainContent.Controls.Add(this.pnlActiveLoans);
            this.pnlMainContent.Controls.Add(this.pnlTotalMembers);
            this.pnlMainContent.Controls.Add(this.pnlTotalBooks);
            this.pnlMainContent.Location = new System.Drawing.Point(285, 110);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(1240, 790);
            this.pnlMainContent.TabIndex = 2;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(20, 130);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(220, 50);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Ana səhifə";
            this.btnDashboard.UseVisualStyleBackColor = false;
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
            // btnActiveLoans
            // 
            this.btnActiveLoans.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnActiveLoans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActiveLoans.FlatAppearance.BorderSize = 0;
            this.btnActiveLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActiveLoans.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnActiveLoans.ForeColor = System.Drawing.Color.White;
            this.btnActiveLoans.Location = new System.Drawing.Point(20, 325);
            this.btnActiveLoans.Name = "btnActiveLoans";
            this.btnActiveLoans.Size = new System.Drawing.Size(220, 50);
            this.btnActiveLoans.TabIndex = 4;
            this.btnActiveLoans.Text = "Qaytarılmamış kitablar";
            this.btnActiveLoans.UseVisualStyleBackColor = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.ForeColor = System.Drawing.Color.DimGray;
            this.lblWelcome.Location = new System.Drawing.Point(750, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(276, 23);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Kitabxana sisteminə xoş gəlmisiniz!";
            // 
            // pnlTotalBooks
            // 
            this.pnlTotalBooks.Controls.Add(this.lblTotalBooks);
            this.pnlTotalBooks.Controls.Add(this.lblTotalBooksTitle);
            this.pnlTotalBooks.Location = new System.Drawing.Point(0, 10);
            this.pnlTotalBooks.Name = "pnlTotalBooks";
            this.pnlTotalBooks.Size = new System.Drawing.Size(285, 145);
            this.pnlTotalBooks.TabIndex = 0;
            // 
            // lblTotalBooksTitle
            // 
            this.lblTotalBooksTitle.AutoSize = true;
            this.lblTotalBooksTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalBooksTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalBooksTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTotalBooksTitle.Name = "lblTotalBooksTitle";
            this.lblTotalBooksTitle.Size = new System.Drawing.Size(153, 25);
            this.lblTotalBooksTitle.TabIndex = 0;
            this.lblTotalBooksTitle.Text = "Ümumi kitab sayı:";
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalBooks.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotalBooks.Location = new System.Drawing.Point(20, 60);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(49, 57);
            this.lblTotalBooks.TabIndex = 1;
            this.lblTotalBooks.Text = "0";
            // 
            // pnlTotalMembers
            // 
            this.pnlTotalMembers.Controls.Add(this.lblTotalMembers);
            this.pnlTotalMembers.Controls.Add(this.lblTotalMembersTitle);
            this.pnlTotalMembers.ForeColor = System.Drawing.Color.White;
            this.pnlTotalMembers.Location = new System.Drawing.Point(310, 10);
            this.pnlTotalMembers.Name = "pnlTotalMembers";
            this.pnlTotalMembers.Size = new System.Drawing.Size(285, 145);
            this.pnlTotalMembers.TabIndex = 1;
            // 
            // lblTotalMembersTitle
            // 
            this.lblTotalMembersTitle.AutoSize = true;
            this.lblTotalMembersTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalMembersTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalMembersTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTotalMembersTitle.Name = "lblTotalMembersTitle";
            this.lblTotalMembersTitle.Size = new System.Drawing.Size(113, 25);
            this.lblTotalMembersTitle.TabIndex = 0;
            this.lblTotalMembersTitle.Text = "Üzvlərin sayı:";
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.AutoSize = true;
            this.lblTotalMembers.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalMembers.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotalMembers.Location = new System.Drawing.Point(20, 60);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(49, 57);
            this.lblTotalMembers.TabIndex = 1;
            this.lblTotalMembers.Text = "0";
            // 
            // pnlReturnedBooks
            // 
            this.pnlReturnedBooks.Controls.Add(this.lblReturnedBooks);
            this.pnlReturnedBooks.Controls.Add(this.lblReturnedBooksTitle);
            this.pnlReturnedBooks.ForeColor = System.Drawing.Color.White;
            this.pnlReturnedBooks.Location = new System.Drawing.Point(930, 10);
            this.pnlReturnedBooks.Name = "pnlReturnedBooks";
            this.pnlReturnedBooks.Size = new System.Drawing.Size(285, 145);
            this.pnlReturnedBooks.TabIndex = 3;
            // 
            // lblReturnedBooks
            // 
            this.lblReturnedBooks.AutoSize = true;
            this.lblReturnedBooks.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReturnedBooks.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblReturnedBooks.Location = new System.Drawing.Point(20, 60);
            this.lblReturnedBooks.Name = "lblReturnedBooks";
            this.lblReturnedBooks.Size = new System.Drawing.Size(49, 57);
            this.lblReturnedBooks.TabIndex = 1;
            this.lblReturnedBooks.Text = "0";
            // 
            // lblReturnedBooksTitle
            // 
            this.lblReturnedBooksTitle.AutoSize = true;
            this.lblReturnedBooksTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReturnedBooksTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblReturnedBooksTitle.Location = new System.Drawing.Point(20, 20);
            this.lblReturnedBooksTitle.Name = "lblReturnedBooksTitle";
            this.lblReturnedBooksTitle.Size = new System.Drawing.Size(168, 25);
            this.lblReturnedBooksTitle.TabIndex = 0;
            this.lblReturnedBooksTitle.Text = "Qaytarılmış kitablar:";
            // 
            // pnlActiveLoans
            // 
            this.pnlActiveLoans.Controls.Add(this.lblActiveLoans);
            this.pnlActiveLoans.Controls.Add(this.lblActiveLoansTitle);
            this.pnlActiveLoans.Location = new System.Drawing.Point(620, 10);
            this.pnlActiveLoans.Name = "pnlActiveLoans";
            this.pnlActiveLoans.Size = new System.Drawing.Size(285, 145);
            this.pnlActiveLoans.TabIndex = 2;
            // 
            // lblActiveLoans
            // 
            this.lblActiveLoans.AutoSize = true;
            this.lblActiveLoans.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActiveLoans.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblActiveLoans.Location = new System.Drawing.Point(20, 60);
            this.lblActiveLoans.Name = "lblActiveLoans";
            this.lblActiveLoans.Size = new System.Drawing.Size(49, 57);
            this.lblActiveLoans.TabIndex = 1;
            this.lblActiveLoans.Text = "0";
            // 
            // lblActiveLoansTitle
            // 
            this.lblActiveLoansTitle.AutoSize = true;
            this.lblActiveLoansTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActiveLoansTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblActiveLoansTitle.Location = new System.Drawing.Point(20, 20);
            this.lblActiveLoansTitle.Name = "lblActiveLoansTitle";
            this.lblActiveLoansTitle.Size = new System.Drawing.Size(116, 25);
            this.lblActiveLoansTitle.TabIndex = 0;
            this.lblActiveLoansTitle.Text = "Aktiv icarələr:";
            // 
            // lblRecentLoansTitle
            // 
            this.lblRecentLoansTitle.AutoSize = true;
            this.lblRecentLoansTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRecentLoansTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRecentLoansTitle.Location = new System.Drawing.Point(0, 190);
            this.lblRecentLoansTitle.Name = "lblRecentLoansTitle";
            this.lblRecentLoansTitle.Size = new System.Drawing.Size(254, 38);
            this.lblRecentLoansTitle.TabIndex = 4;
            this.lblRecentLoansTitle.Text = "Son kitab icarələri";
            // 
            // dgvRecentLoans
            // 
            this.dgvRecentLoans.AllowUserToAddRows = false;
            this.dgvRecentLoans.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvRecentLoans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRecentLoans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentLoans.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentLoans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentLoans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRecentLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecentLoans.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRecentLoans.Location = new System.Drawing.Point(0, 240);
            this.dgvRecentLoans.MultiSelect = false;
            this.dgvRecentLoans.Name = "dgvRecentLoans";
            this.dgvRecentLoans.ReadOnly = true;
            this.dgvRecentLoans.RowHeadersVisible = false;
            this.dgvRecentLoans.RowHeadersWidth = 51;
            this.dgvRecentLoans.RowTemplate.Height = 24;
            this.dgvRecentLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentLoans.Size = new System.Drawing.Size(1215, 350);
            this.dgvRecentLoans.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1532, 903);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            this.pnlTotalBooks.ResumeLayout(false);
            this.pnlTotalBooks.PerformLayout();
            this.pnlTotalMembers.ResumeLayout(false);
            this.pnlTotalMembers.PerformLayout();
            this.pnlReturnedBooks.ResumeLayout(false);
            this.pnlReturnedBooks.PerformLayout();
            this.pnlActiveLoans.ResumeLayout(false);
            this.pnlActiveLoans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentLoans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Button btnActiveLoans;
        private System.Windows.Forms.Button btnLoans;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlTotalMembers;
        private System.Windows.Forms.Panel pnlTotalBooks;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblTotalBooksTitle;
        private System.Windows.Forms.Label lblTotalMembers;
        private System.Windows.Forms.Label lblTotalMembersTitle;
        private System.Windows.Forms.Panel pnlReturnedBooks;
        private System.Windows.Forms.Label lblReturnedBooks;
        private System.Windows.Forms.Label lblReturnedBooksTitle;
        private System.Windows.Forms.Panel pnlActiveLoans;
        private System.Windows.Forms.Label lblActiveLoans;
        private System.Windows.Forms.Label lblActiveLoansTitle;
        private System.Windows.Forms.DataGridView dgvRecentLoans;
        private System.Windows.Forms.Label lblRecentLoansTitle;
    }
}

