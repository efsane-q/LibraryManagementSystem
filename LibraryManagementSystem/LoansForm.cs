using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LoansForm : Form
    {
        public LoansForm()
        {
            InitializeComponent();
            this.Load += LoansForm_Load;

            btnDashboard.Click += btnDashboard_Click;
            btnBooks.Click += btnBooks_Click;
            btnLoans.Click += btnLoans_Click;
            btnActiveLoans.Click += btnActiveLoans_Click;
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

        }
        

        private void btnActiveLoans_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActiveLoansForm form = new ActiveLoansForm();
            form.ShowDialog();
            this.Close();
        }
        private void LoansForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadMembers();
            LoadLoans();
        }
        private void LoadBooks()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = "SELECT BookID, Title FROM Books";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbLoanBook.DataSource = dt;
                cmbLoanBook.DisplayMember = "Title";
                cmbLoanBook.ValueMember = "BookID";
                cmbLoanBook.SelectedIndex = -1;
            }
        }
        private void LoadMembers()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = "SELECT MemberID, FullName FROM Members";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbLoanMember.DataSource = dt;
                cmbLoanMember.DisplayMember = "FullName";
                cmbLoanMember.ValueMember = "MemberID";
                cmbLoanMember.SelectedIndex = -1;
            }
        }
        private void LoadLoans()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = @"
            SELECT
                Loans.LoanID,
                Books.Title,
                Members.FullName,
                Loans.LoanDate,
                Loans.ReturnDate
            FROM Loans
            INNER JOIN Books ON Loans.BookID = Books.BookID
            INNER JOIN Members ON Loans.MemberID = Members.MemberID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvLoans.DataSource = dt;

                dgvLoans.Columns["LoanID"].HeaderText = "İcarə ID";
                dgvLoans.Columns["Title"].HeaderText = "Kitabın adı";
                dgvLoans.Columns["FullName"].HeaderText = "Üzvün adı";
                dgvLoans.Columns["LoanDate"].HeaderText = "İcarə tarixi";
                dgvLoans.Columns["ReturnDate"].HeaderText = "Qaytarılma tarixi";
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void LoansForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            if (txtLoanID.Text == "" ||
    cmbLoanBook.SelectedIndex == -1 ||
    cmbLoanMember.SelectedIndex == -1)
            {
                MessageBox.Show("Bütün məlumatları daxil edin.");
                return;
            }

            int loanID, bookID, memberID;

            if (!int.TryParse(txtLoanID.Text, out loanID))
            {
                MessageBox.Show("İcarə ID düzgün daxil edilməyib.");
                return;
            }

            bookID = Convert.ToInt32(cmbLoanBook.SelectedValue);
            memberID = Convert.ToInt32(cmbLoanMember.SelectedValue);

            using (SqlConnection con = Database.GetConnection())
            {
                string query = @"INSERT INTO Loans
                     (LoanID, BookID, MemberID, LoanDate, ReturnDate)
                     VALUES
                     (@LoanID, @BookID, @MemberID, @LoanDate, NULL)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@LoanID", loanID);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                cmd.Parameters.AddWithValue("@MemberID", memberID);
                cmd.Parameters.AddWithValue("@LoanDate", dtpLoanDate.Value.Date);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("İcarə uğurla əlavə edildi!");
            LoadLoans();
        }

        private void btnUpdateLoan_Click(object sender, EventArgs e)
        {
            if (txtLoanID.Text == "" ||
    cmbLoanBook.SelectedIndex == -1 ||
    cmbLoanMember.SelectedIndex == -1)
            {
                MessageBox.Show("Əvvəlcə icarəni seçin və məlumatları doldurun.");
                return;
            }

            int loanID = Convert.ToInt32(txtLoanID.Text);
            int bookID = Convert.ToInt32(cmbLoanBook.SelectedValue);
            int memberID = Convert.ToInt32(cmbLoanMember.SelectedValue);

            using (SqlConnection con = Database.GetConnection())
            {
                string query = @"
        UPDATE Loans
        SET BookID = @BookID,
            MemberID = @MemberID,
            LoanDate = @LoanDate,
            ReturnDate = @ReturnDate
        WHERE LoanID = @LoanID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@LoanID", loanID);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                cmd.Parameters.AddWithValue("@MemberID", memberID);
                cmd.Parameters.AddWithValue("@LoanDate", dtpLoanDate.Value.Date);

                if (dtpReturnDate.Checked)
                    cmd.Parameters.AddWithValue("@ReturnDate", dtpReturnDate.Value.Date);
                else
                    cmd.Parameters.AddWithValue("@ReturnDate", DBNull.Value);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("İcarə məlumatları yeniləndi!");
            LoadLoans();
        }

        private void btnDeleteLoan_Click(object sender, EventArgs e)
        {
            if (txtLoanID.Text == "")
            {
                MessageBox.Show("Zəhmət olmasa, silmək üçün icarə seçin.");
                return;
            }

            int loanID = Convert.ToInt32(txtLoanID.Text);

            DialogResult result = MessageBox.Show(
                "Bu icarəni silmək istədiyinizə əminsiniz?",
                "İcarənin silinməsi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = Database.GetConnection())
                {
                    string query = "DELETE FROM Loans WHERE LoanID = @LoanID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@LoanID", loanID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("İcarə uğurla silindi!");

                LoadLoans();
            }
        }

        private void btnClearLoan_Click(object sender, EventArgs e)
        {
            txtLoanID.Clear();

            cmbLoanBook.SelectedIndex = -1;
            cmbLoanMember.SelectedIndex = -1;

            dtpLoanDate.Value = DateTime.Today;
            dtpReturnDate.Value = DateTime.Today;
            dtpReturnDate.Checked = false;

            dgvLoans.ClearSelection();
        }

        private void dgvLoans_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchLoan_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = @"
        SELECT
            Loans.LoanID,
            Books.Title,
            Members.FullName,
            Loans.LoanDate,
            Loans.ReturnDate
        FROM Loans
        INNER JOIN Books ON Loans.BookID = Books.BookID
        INNER JOIN Members ON Loans.MemberID = Members.MemberID
        WHERE CAST(Loans.LoanID AS NVARCHAR) LIKE @Search
           OR Books.Title LIKE @Search
           OR Members.FullName LIKE @Search";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue(
                    "@Search", "%" + txtSearchLoan.Text.Trim() + "%"
                );

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvLoans.DataSource = dt;
            }
        }

        private void dgvLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoans.Rows[e.RowIndex];

                txtLoanID.Text = row.Cells["LoanID"].Value.ToString();

                cmbLoanBook.Text = row.Cells["Title"].Value.ToString();
                cmbLoanMember.Text = row.Cells["FullName"].Value.ToString();

                dtpLoanDate.Value = Convert.ToDateTime(row.Cells["LoanDate"].Value);

                if (row.Cells["ReturnDate"].Value == DBNull.Value)
                {
                    dtpReturnDate.Checked = false;
                }
                else
                {
                    dtpReturnDate.Checked = true;
                    dtpReturnDate.Value = Convert.ToDateTime(row.Cells["ReturnDate"].Value);
                }
            }
        }
    }
}
