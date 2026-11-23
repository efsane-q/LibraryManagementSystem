namespace LibraryManagementSystem
{
    partial class LoansForm
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
            this.lblLoansTitle = new System.Windows.Forms.Label();
            this.pnlLoanDetails = new System.Windows.Forms.Panel();
            this.lblLoanID = new System.Windows.Forms.Label();
            this.txtLoanID = new System.Windows.Forms.TextBox();
            this.lblLoanBook = new System.Windows.Forms.Label();
            this.cmbLoanBook = new System.Windows.Forms.ComboBox();
            this.lblLoanMember = new System.Windows.Forms.Label();
            this.cmbLoanMember = new System.Windows.Forms.ComboBox();
            this.lblLoanDate = new System.Windows.Forms.Label();
            this.dtpLoanDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddLoan = new System.Windows.Forms.Button();
            this.btnUpdateLoan = new System.Windows.Forms.Button();
            this.btnDeleteLoan = new System.Windows.Forms.Button();
            this.btnClearLoan = new System.Windows.Forms.Button();
            this.lblLoanListTitle = new System.Windows.Forms.Label();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.lblSearchLoan = new System.Windows.Forms.Label();
            this.txtSearchLoan = new System.Windows.Forms.TextBox();
            this.btnSearchLoan = new System.Windows.Forms.Button();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnActiveLoans = new System.Windows.Forms.Button();
            this.btnLoans = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlLoanDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoansTitle
            // 
            this.lblLoansTitle.AutoSize = true;
            this.lblLoansTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblLoansTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoansTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLoansTitle.Location = new System.Drawing.Point(284, 21);
            this.lblLoansTitle.Name = "lblLoansTitle";
            this.lblLoansTitle.Size = new System.Drawing.Size(498, 46);
            this.lblLoansTitle.TabIndex = 0;
            this.lblLoansTitle.Text = "Kitab icarəsinin idarə edilməsi";
            // 
            // pnlLoanDetails
            // 
            this.pnlLoanDetails.BackColor = System.Drawing.Color.White;
            this.pnlLoanDetails.Controls.Add(this.btnClearLoan);
            this.pnlLoanDetails.Controls.Add(this.btnDeleteLoan);
            this.pnlLoanDetails.Controls.Add(this.btnUpdateLoan);
            this.pnlLoanDetails.Controls.Add(this.btnAddLoan);
            this.pnlLoanDetails.Controls.Add(this.dtpReturnDate);
            this.pnlLoanDetails.Controls.Add(this.lblReturnDate);
            this.pnlLoanDetails.Controls.Add(this.dtpLoanDate);
            this.pnlLoanDetails.Controls.Add(this.lblLoanDate);
            this.pnlLoanDetails.Controls.Add(this.cmbLoanMember);
            this.pnlLoanDetails.Controls.Add(this.lblLoanMember);
            this.pnlLoanDetails.Controls.Add(this.cmbLoanBook);
            this.pnlLoanDetails.Controls.Add(this.lblLoanBook);
            this.pnlLoanDetails.Controls.Add(this.txtLoanID);
            this.pnlLoanDetails.Controls.Add(this.lblLoanID);
            this.pnlLoanDetails.Location = new System.Drawing.Point(288, 84);
            this.pnlLoanDetails.Name = "pnlLoanDetails";
            this.pnlLoanDetails.Size = new System.Drawing.Size(1160, 220);
            this.pnlLoanDetails.TabIndex = 1;
            // 
            // lblLoanID
            // 
            this.lblLoanID.AutoSize = true;
            this.lblLoanID.Location = new System.Drawing.Point(25, 20);
            this.lblLoanID.Name = "lblLoanID";
            this.lblLoanID.Size = new System.Drawing.Size(52, 17);
            this.lblLoanID.TabIndex = 0;
            this.lblLoanID.Text = "İcarə ID";
            // 
            // txtLoanID
            // 
            this.txtLoanID.Location = new System.Drawing.Point(25, 50);
            this.txtLoanID.Name = "txtLoanID";
            this.txtLoanID.Size = new System.Drawing.Size(200, 25);
            this.txtLoanID.TabIndex = 1;
            // 
            // lblLoanBook
            // 
            this.lblLoanBook.AutoSize = true;
            this.lblLoanBook.Location = new System.Drawing.Point(275, 20);
            this.lblLoanBook.Name = "lblLoanBook";
            this.lblLoanBook.Size = new System.Drawing.Size(38, 17);
            this.lblLoanBook.TabIndex = 2;
            this.lblLoanBook.Text = "Kitab";
            // 
            // cmbLoanBook
            // 
            this.cmbLoanBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoanBook.FormattingEnabled = true;
            this.cmbLoanBook.Location = new System.Drawing.Point(275, 50);
            this.cmbLoanBook.Name = "cmbLoanBook";
            this.cmbLoanBook.Size = new System.Drawing.Size(250, 25);
            this.cmbLoanBook.TabIndex = 3;
            // 
            // lblLoanMember
            // 
            this.lblLoanMember.AutoSize = true;
            this.lblLoanMember.Location = new System.Drawing.Point(575, 20);
            this.lblLoanMember.Name = "lblLoanMember";
            this.lblLoanMember.Size = new System.Drawing.Size(29, 17);
            this.lblLoanMember.TabIndex = 4;
            this.lblLoanMember.Text = "Üzv";
            // 
            // cmbLoanMember
            // 
            this.cmbLoanMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoanMember.FormattingEnabled = true;
            this.cmbLoanMember.Location = new System.Drawing.Point(575, 50);
            this.cmbLoanMember.Name = "cmbLoanMember";
            this.cmbLoanMember.Size = new System.Drawing.Size(200, 25);
            this.cmbLoanMember.TabIndex = 5;
            // 
            // lblLoanDate
            // 
            this.lblLoanDate.AutoSize = true;
            this.lblLoanDate.Location = new System.Drawing.Point(25, 110);
            this.lblLoanDate.Name = "lblLoanDate";
            this.lblLoanDate.Size = new System.Drawing.Size(71, 17);
            this.lblLoanDate.TabIndex = 6;
            this.lblLoanDate.Text = "İcarə tarixi:";
            // 
            // dtpLoanDate
            // 
            this.dtpLoanDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLoanDate.Location = new System.Drawing.Point(25, 140);
            this.dtpLoanDate.Name = "dtpLoanDate";
            this.dtpLoanDate.Size = new System.Drawing.Size(200, 25);
            this.dtpLoanDate.TabIndex = 7;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(275, 110);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(106, 17);
            this.lblReturnDate.TabIndex = 8;
            this.lblReturnDate.Text = "Qaytarılma tarixi:";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(275, 140);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.ShowCheckBox = true;
            this.dtpReturnDate.Size = new System.Drawing.Size(200, 25);
            this.dtpReturnDate.TabIndex = 9;
            // 
            // btnAddLoan
            // 
            this.btnAddLoan.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLoan.FlatAppearance.BorderSize = 0;
            this.btnAddLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLoan.ForeColor = System.Drawing.Color.White;
            this.btnAddLoan.Location = new System.Drawing.Point(575, 140);
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.Size = new System.Drawing.Size(125, 40);
            this.btnAddLoan.TabIndex = 10;
            this.btnAddLoan.Text = "İcarəyə ver";
            this.btnAddLoan.UseVisualStyleBackColor = false;
            this.btnAddLoan.Click += new System.EventHandler(this.btnAddLoan_Click);
            // 
            // btnUpdateLoan
            // 
            this.btnUpdateLoan.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateLoan.FlatAppearance.BorderSize = 0;
            this.btnUpdateLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateLoan.ForeColor = System.Drawing.Color.White;
            this.btnUpdateLoan.Location = new System.Drawing.Point(715, 140);
            this.btnUpdateLoan.Name = "btnUpdateLoan";
            this.btnUpdateLoan.Size = new System.Drawing.Size(115, 40);
            this.btnUpdateLoan.TabIndex = 11;
            this.btnUpdateLoan.Text = "Yenilə";
            this.btnUpdateLoan.UseVisualStyleBackColor = false;
            this.btnUpdateLoan.Click += new System.EventHandler(this.btnUpdateLoan_Click);
            // 
            // btnDeleteLoan
            // 
            this.btnDeleteLoan.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteLoan.FlatAppearance.BorderSize = 0;
            this.btnDeleteLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLoan.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLoan.Location = new System.Drawing.Point(845, 140);
            this.btnDeleteLoan.Name = "btnDeleteLoan";
            this.btnDeleteLoan.Size = new System.Drawing.Size(100, 40);
            this.btnDeleteLoan.TabIndex = 12;
            this.btnDeleteLoan.Text = "Sil";
            this.btnDeleteLoan.UseVisualStyleBackColor = false;
            this.btnDeleteLoan.Click += new System.EventHandler(this.btnDeleteLoan_Click);
            // 
            // btnClearLoan
            // 
            this.btnClearLoan.BackColor = System.Drawing.Color.DimGray;
            this.btnClearLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearLoan.FlatAppearance.BorderSize = 0;
            this.btnClearLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLoan.ForeColor = System.Drawing.Color.White;
            this.btnClearLoan.Location = new System.Drawing.Point(960, 140);
            this.btnClearLoan.Name = "btnClearLoan";
            this.btnClearLoan.Size = new System.Drawing.Size(115, 40);
            this.btnClearLoan.TabIndex = 13;
            this.btnClearLoan.Text = "Təmizlə";
            this.btnClearLoan.UseVisualStyleBackColor = false;
            this.btnClearLoan.Click += new System.EventHandler(this.btnClearLoan_Click);
            // 
            // lblLoanListTitle
            // 
            this.lblLoanListTitle.AutoSize = true;
            this.lblLoanListTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoanListTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblLoanListTitle.Location = new System.Drawing.Point(288, 329);
            this.lblLoanListTitle.Name = "lblLoanListTitle";
            this.lblLoanListTitle.Size = new System.Drawing.Size(292, 38);
            this.lblLoanListTitle.TabIndex = 2;
            this.lblLoanListTitle.Text = "Bütün kitab icarələri:";
            // 
            // dgvLoans
            // 
            this.dgvLoans.AllowUserToAddRows = false;
            this.dgvLoans.AllowUserToDeleteRows = false;
            this.dgvLoans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoans.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(289, 379);
            this.dgvLoans.MultiSelect = false;
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.ReadOnly = true;
            this.dgvLoans.RowHeadersVisible = false;
            this.dgvLoans.RowHeadersWidth = 51;
            this.dgvLoans.RowTemplate.Height = 24;
            this.dgvLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoans.Size = new System.Drawing.Size(1160, 390);
            this.dgvLoans.TabIndex = 3;
            this.dgvLoans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoans_CellClick);
            this.dgvLoans.Click += new System.EventHandler(this.dgvLoans_Click);
            // 
            // lblSearchLoan
            // 
            this.lblSearchLoan.AutoSize = true;
            this.lblSearchLoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchLoan.Location = new System.Drawing.Point(1043, 329);
            this.lblSearchLoan.Name = "lblSearchLoan";
            this.lblSearchLoan.Size = new System.Drawing.Size(100, 23);
            this.lblSearchLoan.TabIndex = 4;
            this.lblSearchLoan.Text = "İcarə axtar:";
            // 
            // txtSearchLoan
            // 
            this.txtSearchLoan.Location = new System.Drawing.Point(1153, 327);
            this.txtSearchLoan.Name = "txtSearchLoan";
            this.txtSearchLoan.Size = new System.Drawing.Size(220, 25);
            this.txtSearchLoan.TabIndex = 5;
            // 
            // btnSearchLoan
            // 
            this.btnSearchLoan.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchLoan.ForeColor = System.Drawing.Color.White;
            this.btnSearchLoan.Location = new System.Drawing.Point(1378, 327);
            this.btnSearchLoan.Name = "btnSearchLoan";
            this.btnSearchLoan.Size = new System.Drawing.Size(75, 32);
            this.btnSearchLoan.TabIndex = 6;
            this.btnSearchLoan.Text = "Axtar";
            this.btnSearchLoan.UseVisualStyleBackColor = false;
            this.btnSearchLoan.Click += new System.EventHandler(this.btnSearchLoan_Click);
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
            this.pnlSidebar.TabIndex = 7;
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
            // btnLoans
            // 
            this.btnLoans.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLoans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoans.FlatAppearance.BorderSize = 0;
            this.btnLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoans.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            // LoansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1499, 853);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.btnSearchLoan);
            this.Controls.Add(this.txtSearchLoan);
            this.Controls.Add(this.lblSearchLoan);
            this.Controls.Add(this.dgvLoans);
            this.Controls.Add(this.lblLoanListTitle);
            this.Controls.Add(this.pnlLoanDetails);
            this.Controls.Add(this.lblLoansTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "LoansForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitab icarəsinin idarə edilməsi";
            this.Load += new System.EventHandler(this.LoansForm_Load_1);
            this.pnlLoanDetails.ResumeLayout(false);
            this.pnlLoanDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoansTitle;
        private System.Windows.Forms.Panel pnlLoanDetails;
        private System.Windows.Forms.Label lblLoanMember;
        private System.Windows.Forms.ComboBox cmbLoanBook;
        private System.Windows.Forms.Label lblLoanBook;
        private System.Windows.Forms.TextBox txtLoanID;
        private System.Windows.Forms.Label lblLoanID;
        private System.Windows.Forms.Button btnAddLoan;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DateTimePicker dtpLoanDate;
        private System.Windows.Forms.Label lblLoanDate;
        private System.Windows.Forms.ComboBox cmbLoanMember;
        private System.Windows.Forms.Button btnClearLoan;
        private System.Windows.Forms.Button btnDeleteLoan;
        private System.Windows.Forms.Button btnUpdateLoan;
        private System.Windows.Forms.Label lblLoanListTitle;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.Label lblSearchLoan;
        private System.Windows.Forms.TextBox txtSearchLoan;
        private System.Windows.Forms.Button btnSearchLoan;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnActiveLoans;
        private System.Windows.Forms.Button btnLoans;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblLogo;
    }
}