using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace OtakuHavenApp
{
    public partial class ReviewsForm : Form
    {
        private string currentUser;
        private string userRole;
        private int currentUserId;

        public ReviewsForm(string username, string role, int userId)
        {
            InitializeComponent();
            currentUser = username;
            userRole = role;
            currentUserId = userId;
            LoadReviews();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
 
        private void LoadReviews()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT r.review_id, u.username, p.name AS product, r.rating, r.review_text, r.review_date
                        FROM reviews r
                        JOIN users u ON r.user_id = u.user_id
                        JOIN products p ON r.product_id = p.product_id
                        ORDER BY r.review_date DESC";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvReviews.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading reviews: " + ex.Message);
                }
            }
        }

        private void LoadReviewsWithFilter(string userFilter, string productFilter, string ratingFilter)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT r.review_id, u.username, p.name AS product, r.rating, r.review_text, r.review_date
                        FROM reviews r
                        JOIN users u ON r.user_id = u.user_id
                        JOIN products p ON r.product_id = p.product_id
                        WHERE 1=1 ";

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;

                    if (!string.IsNullOrEmpty(userFilter))
                    {
                        query += " AND u.username LIKE @user ";
                        cmd.Parameters.AddWithValue("@user", "%" + userFilter + "%");
                    }
                    if (!string.IsNullOrEmpty(productFilter))
                    {
                        query += " AND p.name LIKE @product ";
                        cmd.Parameters.AddWithValue("@product", "%" + productFilter + "%");
                    }
                    if (!string.IsNullOrEmpty(ratingFilter))
                    {
                        if (int.TryParse(ratingFilter, out int ratingVal) && ratingVal >= 1 && ratingVal <= 5)
                        {
                            query += " AND r.rating = @rating ";
                            cmd.Parameters.AddWithValue("@rating", ratingVal);
                        }
                        else
                        {
                            MessageBox.Show("Rating filter must be a number between 1 and 5.");
                            return;
                        }
                    }

                    query += " ORDER BY r.review_date DESC";
                    cmd.CommandText = query;

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvReviews.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error filtering reviews: " + ex.Message);
                }
            }
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserId.Text) ||
                string.IsNullOrWhiteSpace(txtProductId.Text) ||
                string.IsNullOrWhiteSpace(txtRating.Text))
            {
                MessageBox.Show("Please enter User ID, Product ID, and Rating.");
                return;
            }

            if (!int.TryParse(txtRating.Text.Trim(), out int ratingVal) || ratingVal < 1 || ratingVal > 5)
            {
                MessageBox.Show("Rating must be a number between 1 and 5.");
                return;
            }

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO reviews (user_id, product_id, rating, review_text, review_date)
                        VALUES (@uid, @pid, @rating, @text, NOW())";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@uid", txtUserId.Text.Trim());
                    cmd.Parameters.AddWithValue("@pid", txtProductId.Text.Trim());
                    cmd.Parameters.AddWithValue("@rating", ratingVal);
                    cmd.Parameters.AddWithValue("@text", txtReview.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Review added successfully.");
                    ClearInputFields();
                    LoadReviews();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding review: " + ex.Message);
                }
            }
        }

        private void ClearInputFields()
        {
            txtUserId.Clear();
            txtProductId.Clear();
            txtRating.Clear();
            txtReview.Clear();
        }

        private void btnSearchReviews_Click(object sender, EventArgs e)
        {
            LoadReviewsWithFilter(
                txtFilterUser.Text.Trim(),
                txtFilterProduct.Text.Trim(),
                txtFilterRating.Text.Trim());
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtFilterUser.Clear();
            txtFilterProduct.Clear();
            txtFilterRating.Clear();
            LoadReviews();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvReviews.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            try
            {
                var excelApp = new Excel.Application();
                var workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel._Worksheet worksheet = (Excel._Worksheet)workbook.ActiveSheet;
                worksheet.Name = "Reviews Report";

                // Column Headers
                for (int i = 1; i <= dgvReviews.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dgvReviews.Columns[i - 1].HeaderText;
                }

                // Rows
                for (int i = 0; i < dgvReviews.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvReviews.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvReviews.Rows[i].Cells[j].Value?.ToString() ?? "";
                    }
                }

                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed: " + ex.Message);
            }
        }

        private void txtReview_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            DashboardForm form = new DashboardForm(currentUser, userRole, currentUserId);
            form.Show();
            this.Hide();
        }
    }
}
