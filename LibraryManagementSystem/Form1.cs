using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnBooks.Click += btnBooks_Click;
            btnLoans.Click += btnLoans_Click;
            btnActiveLoans.Click += btnActiveLoans_Click;

            this.Load += MainForm_Load;
        }
        private void LoadRecentLoans()
        {
            dgvRecentLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            using (SqlConnection con = Database.GetConnection())
            {
                string query = @"
            SELECT TOP 5
                Loans.LoanID,
                Books.Title,
                Members.FullName,
                Loans.LoanDate,
                Loans.ReturnDate
            FROM Loans
            INNER JOIN Books ON Loans.BookID = Books.BookID
            INNER JOIN Members ON Loans.MemberID = Members.MemberID
            ORDER BY Loans.LoanDate DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRecentLoans.DataSource = dt;
                dgvRecentLoans.Columns["LoanID"].HeaderText = "İcarə ID";
                dgvRecentLoans.Columns["Title"].HeaderText = "Kitab";
                dgvRecentLoans.Columns["FullName"].HeaderText = "Oxucu";
                dgvRecentLoans.Columns["LoanDate"].HeaderText = "İcarə tarixi";
                dgvRecentLoans.Columns["ReturnDate"].HeaderText = "Qaytarılma tarixi";

                dgvRecentLoans.ReadOnly = true;
                dgvRecentLoans.AllowUserToAddRows = false;
                dgvRecentLoans.RowHeadersVisible = false;
                dgvRecentLoans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvRecentLoans.MultiSelect = false;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadRecentLoans();
            LoadTotalBooks();
            LoadTotalMembers();
            LoadActiveLoansCount();
            LoadReturnedBooks();

        }
        private void LoadTotalBooks()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Books";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                int totalBooks = (int)cmd.ExecuteScalar();

                lblTotalBooks.Text = totalBooks.ToString();
            }
        }
        private void LoadTotalMembers()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Members";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                int totalMembers = (int)cmd.ExecuteScalar();

                lblTotalMembers.Text = totalMembers.ToString();
            }
        }
        private void LoadActiveLoansCount()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Loans WHERE ReturnDate IS NULL";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                int activeLoans = (int)cmd.ExecuteScalar();

                lblActiveLoans.Text = activeLoans.ToString();
            }
        }
        private void LoadReturnedBooks()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Loans WHERE ReturnDate IS NOT NULL";

                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                int returnedBooks = (int)cmd.ExecuteScalar();

                lblReturnedBooks.Text = returnedBooks.ToString();
            }
        }
        private void btnActiveLoans_Click(object sender, EventArgs e)
        {
            ActiveLoansForm form = new ActiveLoansForm();
            form.ShowDialog();
        }
        private void btnLoans_Click(object sender, EventArgs e)
        {
            LoansForm loansForm = new LoansForm();
            loansForm.ShowDialog();
        }
        private void btnBooks_Click(object sender, EventArgs e)
        {
            BooksForm booksForm = new BooksForm();
            booksForm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
