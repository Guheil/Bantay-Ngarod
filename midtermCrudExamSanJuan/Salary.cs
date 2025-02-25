using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace midtermCrudExamSanJuan
{
    public partial class Salary : UserControl
    {
        private MySqlConnection mySqlConnection;
        private string mysqlcon = "server=127.0.0.1;user=root;database=crudmidtermexam;password=";

        public Salary()
        {
            InitializeComponent();
            mySqlConnection = new MySqlConnection(mysqlcon);
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            PopulateSalaryDataGridView();
        }

        private void PopulateSalaryDataGridView()
        {
            try
            {
                mySqlConnection.Open();

                string query = @"
            SELECT 
                ID,
                Employee_ID,
                CONCAT(First_Name, ' ', Last_Name) AS Full_Name,
                Position,
                Salary
            FROM 
                employee";

                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                datagrid_salary.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void ID_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void empID_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fullname_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void position_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void salary_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void setSalary_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(salary_txtbox.Text, out int newSalary))
            {
                MessageBox.Show("Please enter a valid integer for the salary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(ID_txtbox.Text, out int employeeID))
            {
                MessageBox.Show("Invalid employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();
                    string query = "UPDATE employee SET Salary = @newSalary WHERE ID = @employeeID";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@newSalary", newSalary);
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Salary updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PopulateSalaryDataGridView(); 
                    }
                    else
                    {
                        MessageBox.Show("Failed to update salary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datagrid_salary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagrid_salary.Rows[e.RowIndex];
                ID_txtbox.Text = row.Cells["ID"].Value.ToString();
                empID_txtbox.Text = row.Cells["Employee_ID"].Value.ToString();
                fullname_txtbox.Text = row.Cells["Full_Name"].Value.ToString();
                position_txtbox.Text = row.Cells["Position"].Value.ToString();
                salary_txtbox.Text = row.Cells["Salary"].Value.ToString();
                setSalary_btn.Enabled = true;
                setSalary_btn.BackColor = System.Drawing.Color.FromArgb(240, 89, 65);
            }
            else
            {
                setSalary_btn.Enabled = false;
                setSalary_btn.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void position_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            PopulateSalaryDataGridView();
        }
    }
}
