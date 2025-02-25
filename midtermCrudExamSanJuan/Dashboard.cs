using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace midtermCrudExamSanJuan
{
    public partial class Dashboard : UserControl
    {
        private MySqlConnection mySqlConnection;
        private string mysqlcon = "server=127.0.0.1;user=root;database=crudmidtermexam;password=";

        public Dashboard()
        {
            InitializeComponent();
            mySqlConnection = new MySqlConnection(mysqlcon);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Call this method when your user control loads to update the total number of employees
            UpdateTotalEmployeeCount();
        }

        private void UpdateTotalEmployeeCount()
        {
            try
            {
                // Open the database connection
                mySqlConnection.Open();

                // Query to get the count of all employees from the "employee" table
                string totalQuery = "SELECT COUNT(*) FROM employee";
                MySqlCommand totalCmd = new MySqlCommand(totalQuery, mySqlConnection);
                int totalCount = Convert.ToInt32(totalCmd.ExecuteScalar());

                // Update the total employee count label
                totalEmployee_label.Text = totalCount.ToString();

                // Query to get the count of active employees
                string activeQuery = "SELECT COUNT(*) FROM employee WHERE Status = 'Active'";
                MySqlCommand activeCmd = new MySqlCommand(activeQuery, mySqlConnection);
                int activeCount = Convert.ToInt32(activeCmd.ExecuteScalar());

                // Update the total active employee count label
                totalActiveEmployee_label.Text = activeCount.ToString();

                // Calculate the count of inactive employees
                int inactiveCount = totalCount - activeCount;

                // Update the total inactive employee count label
                totalInactiveEmployee_label.Text = inactiveCount.ToString();

                // Close the database connection
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Make sure to close the connection even if an exception occurs
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // This method can be left empty or used for any specific actions related to the picture box click event
        }
        private void totalEmployee_label_Click(object sender, EventArgs e)
        {

        }

        private void totalActiveEmployee_label_Click(object sender, EventArgs e)
        {

        }

        private void totalInactiveEmployee_label_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            UpdateTotalEmployeeCount();
        }
    }
}