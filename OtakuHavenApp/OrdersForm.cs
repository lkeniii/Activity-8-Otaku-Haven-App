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
    public partial class OrdersForm : Form
    {
        private string currentUser;
        private string userRole;
        private int currentUserId;

        public OrdersForm(string username, string role, int userId)
        {
            InitializeComponent();
            currentUser = username;
            userRole = role;
            currentUserId = userId;
            LoadOrders();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadOrders()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("CALL Get_Customer_Order_Summary(@uid);", conn);
                    cmd.Parameters.AddWithValue("@uid", currentUserId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvOrders.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading orders: " + ex.Message);
                }
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to cancel.");
                return;
            }

            int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["order_id"].Value);

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string updateQuery = "UPDATE orders SET order_status = 'Cancelled' WHERE order_id = @id";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@id", orderId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Order cancelled successfully.");
                    LoadOrders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error cancelling order: " + ex.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
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
