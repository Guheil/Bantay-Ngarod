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
        private System.Windows.Forms.Timer updateTimer;

        public Dashboard()
        {
            InitializeComponent();
            mySqlConnection = new MySqlConnection(mysqlcon);
            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Interval = 5000;
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Start();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            UpdateTotalEmployeeCount();
        }

        private void UpdateTotalEmployeeCount()
        {
            try
            {
                mySqlConnection.Open();
                string totalQuery = "SELECT COUNT(*) FROM employee";
                MySqlCommand totalCmd = new MySqlCommand(totalQuery, mySqlConnection);
                int totalCount = Convert.ToInt32(totalCmd.ExecuteScalar());
                totalEmployee_label.Text = totalCount.ToString();
                string activeQuery = "SELECT COUNT(*) FROM employee WHERE Status = 'Active'";
                MySqlCommand activeCmd = new MySqlCommand(activeQuery, mySqlConnection);
                int activeCount = Convert.ToInt32(activeCmd.ExecuteScalar());
                totalActiveEmployee_label.Text = activeCount.ToString();
                int inactiveCount = totalCount - activeCount;
                totalInactiveEmployee_label.Text = inactiveCount.ToString();
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateTotalEmployeeCount();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}