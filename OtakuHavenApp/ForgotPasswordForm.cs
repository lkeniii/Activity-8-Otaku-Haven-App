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
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your registered email.");
                return;
            }

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string checkQuery = "SELECT * FROM users WHERE email = @Email";
                    MySqlCommand cmd = new MySqlCommand(checkQuery, conn);
                    cmd.Parameters.AddWithValue("@Email", email);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();

                        string tempPassword = GenerateTemporaryPassword();
                        string updateQuery = "UPDATE users SET password_hash = @TempPass WHERE email = @Email";

                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@TempPass", tempPassword);
                        updateCmd.Parameters.AddWithValue("@Email", email);

                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Your temporary password is: {tempPassword}\nPlease log in and change it.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to reset password.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private string GenerateTemporaryPassword()
        {
            return "Temp" + new Random().Next(1000, 9999);
        }
    }
}

