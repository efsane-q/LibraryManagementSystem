namespace LibraryManagementSystem
{
    partial class BooksForm
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
            this.lblBooksTitle = new System.Windows.Forms.Label();
            this.pnlBookDetails = new System.Windows.Forms.Panel();
            this.lblBookID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblPublishYear = new System.Windows.Forms.Label();
            this.txtPublishYear = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnClearBook = new System.Windows.Forms.Button();
            this.lblBookListTitle = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.lblSearchBook = new System.Windows.Forms.Label();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnActiveLoans = new System.Windows.Forms.Button();
            this.btnLoans = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlBookDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBooksTitle
            // 
            this.lblBooksTitle.AutoSize = true;
            this.lblBooksTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBooksTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBooksTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBooksTitle.Location = new System.Drawing.Point(279, 25);
            this.lblBooksTitle.Name = "lblBooksTitle";
            this.lblBooksTitle.Size = new System.Drawing.Size(409, 46);
            this.lblBooksTitle.TabIndex = 0;
            this.lblBooksTitle.Text = "Kitabların idarə edilməsi";
            // 
            // pnlBookDetails
            // 
            this.pnlBookDetails.BackColor = System.Drawing.Color.White;
            this.pnlBookDetails.Controls.Add(this.btnClearBook);
            this.pnlBookDetails.Controls.Add(this.btnDeleteBook);
            this.pnlBookDetails.Controls.Add(this.btnUpdateBook);
            this.pnlBookDetails.Controls.Add(this.btnAddBook);
            this.pnlBookDetails.Controls.Add(this.txtPrice);
            this.pnlBookDetails.Controls.Add(this.lblPrice);
            this.pnlBookDetails.Controls.Add(this.cmbAuthor);
            this.pnlBookDetails.Controls.Add(this.lblAuthor);
            this.pnlBookDetails.Controls.Add(this.txtPublishYear);
            this.pnlBookDetails.Controls.Add(this.lblPublishYear);
            this.pnlBookDetails.Controls.Add(this.txtBookName);
            this.pnlBookDetails.Controls.Add(this.lblBookName);
            this.pnlBookDetails.Controls.Add(this.txtBookID);
            this.pnlBookDetails.Controls.Add(this.lblBookID);
            this.pnlBookDetails.Location = new System.Drawing.Point(283, 88);
            this.pnlBookDetails.Name = "pnlBookDetails";
            this.pnlBookDetails.Size = new System.Drawing.Size(1160, 220);
            this.pnlBookDetails.TabIndex = 1;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(25, 20);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(54, 17);
            this.lblBookID.TabIndex = 0;
            this.lblBookID.Text = "Kitab ID";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(25, 50);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(200, 25);
            this.txtBookID.TabIndex = 1;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(275, 20);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(70, 17);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "Kitabın adı";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(275, 50);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(250, 25);
            this.txtBookName.TabIndex = 3;
            // 
            // lblPublishYear
            // 
            this.lblPublishYear.AutoSize = true;
            this.lblPublishYear.Location = new System.Drawing.Point(575, 20);
            this.lblPublishYear.Name = "lblPublishYear";
            this.lblPublishYear.Size = new System.Drawing.Size(49, 17);
            this.lblPublishYear.TabIndex = 4;
            this.lblPublishYear.Text = "Nəşr ili";
            // 
            // txtPublishYear
            // 
            this.txtPublishYear.Location = new System.Drawing.Point(575, 50);
            this.txtPublishYear.Name = "txtPublishYear";
            this.txtPublishYear.Size = new System.Drawing.Size(200, 25);
            this.txtPublishYear.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(25, 110);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(47, 17);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Müəllif";
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(25, 140);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(250, 25);
            this.cmbAuthor.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(325, 110);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(86, 17);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Qiymət (AZN)";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(325, 140);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 25);
            this.txtPrice.TabIndex = 9;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(590, 140);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(125, 40);
            this.btnAddBook.TabIndex = 10;
            this.btnAddBook.Text = "Əlavə et";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateBook.FlatAppearance.BorderSize = 0;
            this.btnUpdateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBook.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBook.Location = new System.Drawing.Point(735, 140);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(125, 40);
            this.btnUpdateBook.TabIndex = 11;
            this.btnUpdateBook.Text = "Yenilə";
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteBook.FlatAppearance.BorderSize = 0;
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBook.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBook.Location = new System.Drawing.Point(880, 140);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(125, 40);
            this.btnDeleteBook.TabIndex = 12;
            this.btnDeleteBook.Text = "Sil";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnClearBook
            // 
            this.btnClearBook.BackColor = System.Drawing.Color.DimGray;
            this.btnClearBook.FlatAppearance.BorderSize = 0;
            this.btnClearBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearBook.ForeColor = System.Drawing.Color.White;
            this.btnClearBook.Location = new System.Drawing.Point(1025, 140);
            this.btnClearBook.Name = "btnClearBook";
            this.btnClearBook.Size = new System.Drawing.Size(125, 40);
            this.btnClearBook.TabIndex = 13;
            this.btnClearBook.Text = "Təmizlə";
            this.btnClearBook.UseVisualStyleBackColor = false;
            this.btnClearBook.Click += new System.EventHandler(this.btnClearBook_Click);
            // 
            // lblBookListTitle
            // 
            this.lblBookListTitle.AutoSize = true;
            this.lblBookListTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBookListTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBookListTitle.Location = new System.Drawing.Point(283, 333);
            this.lblBookListTitle.Name = "lblBookListTitle";
            this.lblBookListTitle.Size = new System.Drawing.Size(215, 38);
            this.lblBookListTitle.TabIndex = 2;
            this.lblBookListTitle.Text = "Bütün kitablar:";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(283, 383);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(1160, 390);
            this.dgvBooks.TabIndex = 3;
            // 
            // lblSearchBook
            // 
            this.lblSearchBook.AutoSize = true;
            this.lblSearchBook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearchBook.Location = new System.Drawing.Point(1038, 333);
            this.lblSearchBook.Name = "lblSearchBook";
            this.lblSearchBook.Size = new System.Drawing.Size(105, 23);
            this.lblSearchBook.TabIndex = 4;
            this.lblSearchBook.Text = "Kitab axtar:";
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Location = new System.Drawing.Point(1148, 331);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(220, 25);
            this.txtSearchBook.TabIndex = 5;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBook.ForeColor = System.Drawing.Color.White;
            this.btnSearchBook.Location = new System.Drawing.Point(1373, 331);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(70, 32);
            this.btnSearchBook.TabIndex = 6;
            this.btnSearchBook.Text = "Axtar";
            this.btnSearchBook.UseVisualStyleBackColor = false;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
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
            this.btnBooks.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1465, 853);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.txtSearchBook);
            this.Controls.Add(this.lblSearchBook);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.lblBookListTitle);
            this.Controls.Add(this.pnlBookDetails);
            this.Controls.Add(this.lblBooksTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "BooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitabların idarə edilməsi";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            this.pnlBookDetails.ResumeLayout(false);
            this.pnlBookDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBooksTitle;
        private System.Windows.Forms.Panel pnlBookDetails;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtPublishYear;
        private System.Windows.Forms.Label lblPublishYear;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Button btnClearBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.Label lblBookListTitle;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label lblSearchBook;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnActiveLoans;
        private System.Windows.Forms.Button btnLoans;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblLogo;
    }
}