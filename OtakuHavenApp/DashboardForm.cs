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
using OtakuHavenApp;

namespace OtakuHavenApp
{
    public partial class DashboardForm : Form
    {
        private string currentUser;
        private string userRole;
        private int currentUserId;

        public DashboardForm(string username, string role, int userId)
        {
            InitializeComponent();
            currentUser = username;
            userRole = role;
            currentUserId = userId;
            this.StartPosition = FormStartPosition.CenterScreen;

            lblWelcome.Text = $"Konnichiwa!";

        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            UserManagementForm form = new UserManagementForm();
            form.Show();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrdersForm form = new OrdersForm(currentUser, userRole, currentUserId);
            form.Show();
            this.Hide();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            PaymentsForm form = new PaymentsForm(currentUser, userRole, currentUserId);
            form.Show();
            this.Hide();
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            ReviewsForm form = new ReviewsForm(currentUser, userRole, currentUserId);
            form.Show();
            this.Hide();
        }

        private void btnWishlist_Click(object sender, EventArgs e)
        {
            WishlistForm form = new WishlistForm(currentUser, userRole, currentUserId);
            form.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm form = new ReportsForm(currentUser, userRole, currentUserId);
            form.Show();
            this.Hide(); ;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }
    }
}
