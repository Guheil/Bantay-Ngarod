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

namespace midtermCrudExamSanJuan
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void register_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void signup_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_password_TextChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = '*';
        }

        private void signup_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_showPassword.Checked)
            {
                signup_password.PasswordChar = '\0'; 
            }
            else
            {
                signup_password.PasswordChar = '*'; 
            }
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            string username = signup_username.Text;
            string password = signup_password.Text;
            string email = signup_email.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all necessary fields.");
                return;
            }

            string mysqlcon = "server=127.0.0.1;user=root;database=crudmidtermexam; password=";

            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);

            try
            {
                mySqlConnection.Open();

                string checkQuery = "SELECT COUNT(*) FROM admin_user WHERE username = @username OR email = @email";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, mySqlConnection);
                checkCmd.Parameters.AddWithValue("@username", username);
                checkCmd.Parameters.AddWithValue("@email", email);
                int existingUsersCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (existingUsersCount > 0)
                {
                    MessageBox.Show("Username or email already exists. Please choose a different one.");
                    return;
                }

                string query = "INSERT INTO admin_user (username, email, password) VALUES (@username, @email, @password)";

                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registration successful!");
                    Form1 loginForm = new Form1();
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void signup_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
