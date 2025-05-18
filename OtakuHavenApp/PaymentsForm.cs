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

namespace OtakuHavenApp
{
    public partial class PaymentsForm : Form
    {
        private string currentUser;
        private string userRole;
        private int currentUserId;

        public PaymentsForm(string username, string role, int userId)
        {
            InitializeComponent();
            currentUser = username;
            userRole = role;
            currentUserId = userId;
            LoadPendingPayments();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadPendingPayments()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "CALL notify_pending_payments();";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPayments.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading payments: " + ex.Message);
                }
            }
        }

        private void btnMarkAsPaid_Click(object sender, EventArgs e)
        {
            if (dgvPayments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a pending payment.");
                return;
            }

            int paymentId = Convert.ToInt32(dgvPayments.SelectedRows[0].Cells["payment_id"].Value);

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string updateQuery = "UPDATE payments SET payment_status = 'Paid' WHERE payment_id = @id";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@id", paymentId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Payment marked as paid.");
                    LoadPendingPayments();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating payment: " + ex.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPendingPayments();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            DashboardForm form = new DashboardForm(currentUser, userRole, currentUserId);
            form.Show();
            this.Hide();
        }
    }
}
