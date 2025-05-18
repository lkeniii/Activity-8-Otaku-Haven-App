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
    public partial class WishlistForm : Form
    {
        private string currentUser;
        private string userRole;
        private int currentUserId;

        public WishlistForm(string username, string role, int userId)
        {
            InitializeComponent();
            currentUser = username;
            userRole = role;
            currentUserId = userId;
            LoadWishlist();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadWishlist()
        {
            LoadWishlistWithFilter("", "");
        }

        private void LoadWishlistWithFilter(string userFilter, string productFilter)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT w.wishlist_id, u.username, p.name AS product, w.added_at
                        FROM wishlist w
                        JOIN users u ON w.user_id = u.user_id
                        JOIN products p ON w.product_id = p.product_id
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

                    query += " ORDER BY w.added_at DESC";

                    cmd.CommandText = query;

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvWishlist.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading wishlist: " + ex.Message);
                }
            }
        }

        private void btnAddToWishlist_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserId.Text) || string.IsNullOrWhiteSpace(txtProductId.Text))
            {
                MessageBox.Show("Please enter User ID and Product ID.");
                return;
            }

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO wishlist (user_id, product_id, added_at) VALUES (@uid, @pid, NOW())";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@uid", txtUserId.Text.Trim());
                    cmd.Parameters.AddWithValue("@pid", txtProductId.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Item added to wishlist.");
                    ClearInputFields();
                    LoadWishlist();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding to wishlist: " + ex.Message);
                }
            }
        }

        private void ClearInputFields()
        {
            txtUserId.Clear();
            txtProductId.Clear();
        }

        private void btnSearchWishlist_Click(object sender, EventArgs e)
        {
            LoadWishlistWithFilter(txtFilterUser.Text.Trim(), txtFilterProduct.Text.Trim());
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            txtFilterUser.Clear();
            txtFilterProduct.Clear();
            LoadWishlist();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvWishlist.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            try
            {
                var excelApp = new Excel.Application();
                var workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel._Worksheet worksheet = (Excel._Worksheet)workbook.ActiveSheet;
                worksheet.Name = "Wishlist Report";

                // Export headers
                for (int i = 1; i <= dgvWishlist.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dgvWishlist.Columns[i - 1].HeaderText;
                }

                // Export rows
                for (int i = 0; i < dgvWishlist.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvWishlist.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvWishlist.Rows[i].Cells[j].Value?.ToString() ?? "";
                    }
                }

                worksheet.Columns.AutoFit();
                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to Excel: " + ex.Message);
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            DashboardForm form = new DashboardForm(currentUser, userRole, currentUserId);
            form.Show();
            this.Hide();
        }

        private void WishlistForm_Load(object sender, EventArgs e)
        {

        }
    }
}
