using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ActiveLoansForm : Form
    {
        public ActiveLoansForm()
        {
            InitializeComponent();

            this.Load += ActiveLoansForm_Load;

            btnDashboard.Click += btnDashboard_Click;
            btnBooks.Click += btnBooks_Click;
            btnLoans.Click += btnLoans_Click;
            btnActiveLoans.Click += btnActiveLoans_Click;

            btnReturnBook.Click += btnReturnBook_Click;
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
            this.Close();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            BooksForm form = new BooksForm();
            form.ShowDialog();
            this.Close();
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoansForm form = new LoansForm();
            form.ShowDialog();
            this.Close();
        }

        private void btnActiveLoans_Click(object sender, EventArgs e)
        {

        }
        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (dgvActiveLoans.SelectedRows.Count == 0)
            {
                MessageBox.Show("Zəhmət olmasa, qaytarılacaq kitabı seçin.");
                return;
            }

            int loanID = Convert.ToInt32(
                dgvActiveLoans.SelectedRows[0].Cells["LoanID"].Value
            );

            DialogResult result = MessageBox.Show(
                "Seçilmiş kitabı qaytarmaq istəyirsiniz?",
                "Kitabın qaytarılması",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = Database.GetConnection())
                {
                    string query = "UPDATE Loans SET ReturnDate = @ReturnDate WHERE LoanID = @LoanID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ReturnDate", DateTime.Today);
                    cmd.Parameters.AddWithValue("@LoanID", loanID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Kitab uğurla qaytarıldı!");
                LoadActiveLoans();
            }
        }

        private void ActiveLoansForm_Load(object sender, EventArgs e)
        {
            LoadActiveLoans();
        }

        private void LoadActiveLoans()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = @"
            SELECT
                Loans.LoanID,
                Books.Title,
                Members.FullName,
                Loans.LoanDate
            FROM Loans
            INNER JOIN Books ON Loans.BookID = Books.BookID
            INNER JOIN Members ON Loans.MemberID = Members.MemberID
            WHERE Loans.ReturnDate IS NULL";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvActiveLoans.DataSource = dt;

                dgvActiveLoans.Columns["LoanID"].HeaderText = "İcarə ID";
                dgvActiveLoans.Columns["Title"].HeaderText = "Kitabın adı";
                dgvActiveLoans.Columns["FullName"].HeaderText = "Üzvün adı";
                dgvActiveLoans.Columns["LoanDate"].HeaderText = "İcarə tarixi";
            }
        }
    }
}
