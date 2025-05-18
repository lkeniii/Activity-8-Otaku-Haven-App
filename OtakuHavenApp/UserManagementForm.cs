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
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OtakuHavenApp
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
            LoadUsers();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadUsers(string roleFilter = "All", string keyword = "")
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT user_id, username, email, password_hash, role FROM users WHERE 1=1";

                    if (roleFilter != "All")
                        query += " AND role = @role";

                    if (!string.IsNullOrWhiteSpace(keyword))
                        query += " AND (username LIKE @kw OR email LIKE @kw)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    if (roleFilter != "All")
                        cmd.Parameters.AddWithValue("@role", roleFilter);

                    if (!string.IsNullOrWhiteSpace(keyword))
                        cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvUsers.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO users (username, email, password_hash, role) VALUES (@username, @email, @password, @role)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User added successfully.");
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["user_id"].Value);

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE users SET username = @username, email = @email, password_hash = @password, role = @role WHERE user_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User updated.");
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) return;
            int id = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["user_id"].Value);

            var confirm = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM users WHERE user_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User deleted.");
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadUsers(cmbFilter.SelectedItem.ToString(), txtSearch.Text.Trim());
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUsers(cmbFilter.SelectedItem.ToString(), txtSearch.Text.Trim());
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvUsers.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            try
            {
                var excelApp = new Excel.Application();
                var workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel._Worksheet worksheet = (Excel._Worksheet)workbook.ActiveSheet;
                worksheet.Name = "User Management Report";

                // Export headers
                for (int i = 1; i <= dgvUsers.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dgvUsers.Columns[i - 1].HeaderText;
                }

                // Export rows
                for (int i = 0; i < dgvUsers.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvUsers.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvUsers.Rows[i].Cells[j].Value?.ToString() ?? "";
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

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardForm form = new DashboardForm(currentUser, userRole, currentUserId);
            form.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
} 
