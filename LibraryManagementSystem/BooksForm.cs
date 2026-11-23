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
    public partial class BooksForm : Form
    {

        public BooksForm()
        {
            InitializeComponent();

            this.Load += BooksForm_Load;
            
            dgvBooks.CellClick += dgvBooks_CellClick;

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
            this.Hide();
            ActiveLoansForm form = new ActiveLoansForm();
            form.ShowDialog();
            this.Close();
        }
        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBooks.Rows[e.RowIndex];

                txtBookID.Text = row.Cells["BookID"].Value.ToString();
                txtBookName.Text = row.Cells["Title"].Value.ToString();
                txtPublishYear.Text = row.Cells["PublishYear"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();

                cmbAuthor.Text = row.Cells["Author"].Value.ToString();
            }
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            LoadAuthors();
            LoadBooks();
        }

        private void LoadAuthors()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = "SELECT AuthorID, FullName FROM Authors";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbAuthor.DataSource = dt;
                cmbAuthor.DisplayMember = "FullName";
                cmbAuthor.ValueMember = "AuthorID";
                cmbAuthor.SelectedIndex = -1;
            }
        }
        private void LoadBooks()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = @"
            SELECT 
                Books.BookID,
                Books.Title,
                Authors.FullName AS Author,
                Books.PublishYear,
                Books.Price
            FROM Books
            INNER JOIN Authors
            ON Books.AuthorID = Authors.AuthorID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBooks.DataSource = dt;

                dgvBooks.Columns["BookID"].HeaderText = "Kitab ID";
                dgvBooks.Columns["Title"].HeaderText = "Kitabın adı";
                dgvBooks.Columns["Author"].HeaderText = "Müəllif";
                dgvBooks.Columns["PublishYear"].HeaderText = "Nəşr ili";
                dgvBooks.Columns["Price"].HeaderText = "Qiymət (AZN)";
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text == "" ||
        txtBookName.Text == "" ||
        txtPublishYear.Text == "" ||
        cmbAuthor.SelectedIndex == -1 ||
        txtPrice.Text == "")
            {
                MessageBox.Show("Bütün xanaları doldurun!");
                return;
            }

            int bookID, publishYear;
            decimal price;

            if (!int.TryParse(txtBookID.Text, out bookID) ||
                !int.TryParse(txtPublishYear.Text, out publishYear) ||
                !decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("ID, nəşr ili və qiyməti düzgün daxil edin!");
                return;
            }

            using (SqlConnection con = Database.GetConnection())
            {
                string query = @"INSERT INTO Books
                         (BookID, Title, PublishYear, AuthorID, Price)
                         VALUES
                         (@BookID, @Title, @PublishYear, @AuthorID, @Price)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@BookID", bookID);
                cmd.Parameters.AddWithValue("@Title", txtBookName.Text);
                cmd.Parameters.AddWithValue("@PublishYear", publishYear);
                cmd.Parameters.AddWithValue("@AuthorID", cmbAuthor.SelectedValue);
                cmd.Parameters.AddWithValue("@Price", price);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kitab uğurla əlavə edildi!");

                    LoadBooks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xəta: " + ex.Message);
                }
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text == "" ||
        txtBookName.Text == "" ||
        txtPublishYear.Text == "" ||
        cmbAuthor.SelectedIndex == -1 ||
        txtPrice.Text == "")
            {
                MessageBox.Show("Bütün xanaları doldurun!");
                return;
            }

            int bookID, publishYear;
            decimal price;

            if (!int.TryParse(txtBookID.Text, out bookID) ||
                !int.TryParse(txtPublishYear.Text, out publishYear) ||
                !decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Məlumatları düzgün daxil edin!");
                return;
            }

            using (SqlConnection con = Database.GetConnection())
            {
                string query = @"UPDATE Books
                         SET Title = @Title,
                             PublishYear = @PublishYear,
                             AuthorID = @AuthorID,
                             Price = @Price
                         WHERE BookID = @BookID";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@BookID", bookID);
                cmd.Parameters.AddWithValue("@Title", txtBookName.Text);
                cmd.Parameters.AddWithValue("@PublishYear", publishYear);
                cmd.Parameters.AddWithValue("@AuthorID", cmbAuthor.SelectedValue);
                cmd.Parameters.AddWithValue("@Price", price);

                try
                {
                    con.Open();

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Kitab məlumatları yeniləndi!");
                        LoadBooks();
                    }
                    else
                    {
                        MessageBox.Show("Kitab tapılmadı!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xəta: " + ex.Message);
                }
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text == "")
            {
                MessageBox.Show("Silmək üçün cədvəldən kitab seçin!");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Bu kitabı silmək istədiyinizə əminsiniz?",
                "Kitabın silinməsi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (answer == DialogResult.No)
            {
                return;
            }

            int bookID;

            if (!int.TryParse(txtBookID.Text, out bookID))
            {
                MessageBox.Show("Kitab ID düzgün deyil!");
                return;
            }

            using (SqlConnection con = Database.GetConnection())
            {
                string query = "DELETE FROM Books WHERE BookID = @BookID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BookID", bookID);

                try
                {
                    con.Open();

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Kitab uğurla silindi!");
                        LoadBooks();
                    }
                    else
                    {
                        MessageBox.Show("Kitab tapılmadı!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitab silinə bilmədi. Ola bilər ki, bu kitab icarədədir.\n" + ex.Message);
                }
            }
        }

        private void btnClearBook_Click(object sender, EventArgs e)
        {
            txtBookID.Clear();
            txtBookName.Clear();
            txtPublishYear.Clear();
            txtPrice.Clear();
            txtSearchBook.Clear();

            cmbAuthor.SelectedIndex = -1;

            dgvBooks.ClearSelection();

            LoadBooks();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchBook.Text.Trim();

            using (SqlConnection con = Database.GetConnection())
            {
                string query = @"
            SELECT 
                Books.BookID,
                Books.Title,
                Authors.FullName AS Author,
                Books.PublishYear,
                Books.Price
            FROM Books
            INNER JOIN Authors
            ON Books.AuthorID = Authors.AuthorID
            WHERE Books.Title LIKE @Search
               OR Authors.FullName LIKE @Search
               OR CAST(Books.BookID AS NVARCHAR) LIKE @Search";

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                da.SelectCommand.Parameters.AddWithValue(
                    "@Search", "%" + searchText + "%"
                );

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBooks.DataSource = dt;

                dgvBooks.Columns["BookID"].HeaderText = "Kitab ID";
                dgvBooks.Columns["Title"].HeaderText = "Kitabın adı";
                dgvBooks.Columns["Author"].HeaderText = "Müəllif";
                dgvBooks.Columns["PublishYear"].HeaderText = "Nəşr ili";
                dgvBooks.Columns["Price"].HeaderText = "Qiymət (AZN)";
            }
        }
    }
}
