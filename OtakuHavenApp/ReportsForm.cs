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
    public partial class ReportsForm : Form
    {
        private string currentUser;
        private string userRole;
        private int currentUserId;

        public ReportsForm(string username, string role, int userId)
        {
            InitializeComponent();
            currentUser = username;
            userRole = role;
            currentUserId = userId;
            LoadOrderReport();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadOrderReport(string filter = "")
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM orders";

                    if (!string.IsNullOrWhiteSpace(filter))
                    {
                        query += " WHERE order_status LIKE @filter OR CAST(order_date AS CHAR) LIKE @filter OR CAST(total_amount AS CHAR) LIKE @filter";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    if (!string.IsNullOrWhiteSpace(filter))
                    {
                        cmd.Parameters.AddWithValue("@filter", "%" + filter + "%");
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvReport.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading report: " + ex.Message);
                }
            }
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadOrderReport(txtFilter.Text);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.");
                return;
            }

            try
            {
                var excelApp = new Excel.Application();
                var workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel._Worksheet worksheet = (Excel._Worksheet)workbook.ActiveSheet;
                worksheet.Name = "Order Report";

                // Column Headers
                for (int i = 1; i <= dgvReport.Columns.Count; i++)
                {
                    worksheet.Cells[1, i] = dgvReport.Columns[i - 1].HeaderText;
                }

                // Rows
                for (int i = 0; i < dgvReport.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvReport.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvReport.Rows[i].Cells[j].Value?.ToString() ?? "";
                    }
                }

                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed: " + ex.Message);
            }
        }

        private void btnhome_Click_1(object sender, EventArgs e)
        {
            DashboardForm form = new DashboardForm(currentUser, userRole, currentUserId);
            form.Show();
            this.Hide();
        }
    }
}

