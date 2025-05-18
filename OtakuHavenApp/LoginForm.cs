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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OtakuHavenApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE username = @username AND password_hash = @password";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string role = reader["role"].ToString();
                        MessageBox.Show($"Login successful! Welcome, {role}.", "Success");

                        int userId = Convert.ToInt32(reader["user_id"]);
                        DashboardForm dashboard = new DashboardForm(username, role, userId);
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgot = new ForgotPasswordForm();
            forgot.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
