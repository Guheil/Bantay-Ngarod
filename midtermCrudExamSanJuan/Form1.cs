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
using System.Drawing.Drawing2D;

namespace midtermCrudExamSanJuan
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            string mysqlcon = "server=127.0.0.1;user=root;database=crudmidtermexam; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);
        }
        int easterEgg = 0;
        private void label7_Click(object sender, EventArgs e)
        {
            easterEgg++;
            if(easterEgg == 1)
            {
                label7.Text = "Anya metten";
            }
            else if(easterEgg == 2)
            {
                label7.Text = "Ukininam ag login ka kitdin";
            }
            else
            {
                easterEgg = 0;
                label7.Text = "Employee Management System";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = '*';  
        }

        private void login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showPassword.Checked)
            {
                login_password.PasswordChar = '\0'; 
            }
            else
            {
                login_password.PasswordChar = '*';
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string usernameOrEmail = login_username.Text;
            string password = login_password.Text;

            if (string.IsNullOrEmpty(usernameOrEmail) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your username or email and password.");
                return;
            }

            else if (string.IsNullOrEmpty(usernameOrEmail))
            {
                MessageBox.Show("Please enter your username or email.");
                return;
            }

            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.");
                return;
            }

            string mysqlcon = "server=127.0.0.1;user=root;database=crudmidtermexam; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);

            try
            {
                mySqlConnection.Open();
                string query = "SELECT COUNT(*) FROM admin_user WHERE (username = @usernameOrEmail OR email = @usernameOrEmail) AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                cmd.Parameters.AddWithValue("@usernameOrEmail", usernameOrEmail);
                cmd.Parameters.AddWithValue("@password", password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Login Successful!");
                    MainForm mainForm = new MainForm(usernameOrEmail);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or email or password. Please try again.");
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

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
