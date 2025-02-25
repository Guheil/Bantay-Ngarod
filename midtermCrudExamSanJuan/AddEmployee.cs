using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace midtermCrudExamSanJuan
{
    public partial class AddEmployee : UserControl
    {
        private MySqlConnection mySqlConnection;
        private string mysqlcon = "server=127.0.0.1;user=root;database=crudmidtermexam;password=";

        public AddEmployee()
        {
            InitializeComponent();
            mySqlConnection = new MySqlConnection(mysqlcon);
            database_DatagridView.CellClick += new DataGridViewCellEventHandler(database_DatagridView_CellClick); // Subscribe to CellClick event
            addEmployee_updateBtn.Enabled = false; 
            addEmployee_updateBtn.BackColor = System.Drawing.Color.Gray;
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            try
            {
                string query = "SELECT * FROM employee";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                database_DatagridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void database_DatagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uploadImage_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                addEmployee_pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void addEmployee_addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstName_txtbox.Text) ||
                string.IsNullOrEmpty(lastname_txtbox.Text) ||
                string.IsNullOrEmpty(email_textbox.Text) ||
                string.IsNullOrEmpty(gender_combobox.Text) ||
                string.IsNullOrEmpty(position_txtbox.Text) ||
                string.IsNullOrEmpty(status_combobox.Text) ||
                string.IsNullOrEmpty(employeeID_txtbox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                mySqlConnection.Open();
                string checkQuery = "SELECT COUNT(*) FROM employee WHERE Employee_ID = @employee_id";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, mySqlConnection);
                checkCmd.Parameters.AddWithValue("@employee_id", employeeID_txtbox.Text);

                int employeeCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (employeeCount > 0)
                {
                    MessageBox.Show("Employee ID already exists.");
                    return;
                }
                byte[] imageBytes = null;
                if (addEmployee_pictureBox.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        addEmployee_pictureBox.Image.Save(ms, addEmployee_pictureBox.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }
                else
                {
                    Image defaultImage = Image.FromFile(@"C:\Users\xgael\source\repos\midtermCrudExamSanJuan\midtermCrudExamSanJuan\Resources\defaultprofile\default.png");
                    using (MemoryStream ms = new MemoryStream())
                    {
                        defaultImage.Save(ms, defaultImage.RawFormat);
                        imageBytes = ms.ToArray();
                    }
                }

                string query = "INSERT INTO employee (First_Name, Employee_ID, Last_Name, Gender, Email, Position, Status, profile_image) " +
                               "VALUES (@first_name, @employee_id, @last_name, @gender, @email, @position, @status, @image)";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                cmd.Parameters.AddWithValue("@employee_id", employeeID_txtbox.Text);
                cmd.Parameters.AddWithValue("@first_name", firstName_txtbox.Text);
                cmd.Parameters.AddWithValue("@last_name", lastname_txtbox.Text);
                cmd.Parameters.AddWithValue("@gender", gender_combobox.Text);
                cmd.Parameters.AddWithValue("@email", email_textbox.Text);
                cmd.Parameters.AddWithValue("@position", position_txtbox.Text);
                cmd.Parameters.AddWithValue("@status", status_combobox.Text);
                cmd.Parameters.AddWithValue("@image", imageBytes);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Employee added successfully!");
  
                    PopulateDataGridView();
                }
                else
                {
                    MessageBox.Show("Failed to add employee.");
                }
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

        private bool isRowSelected = false;
        private void database_DatagridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = database_DatagridView.Rows[e.RowIndex];

                if (isRowSelected && e.RowIndex == database_DatagridView.CurrentCell.RowIndex)
                {
                    database_DatagridView.ClearSelection();
                    firstName_txtbox.Text = "";
                    lastname_txtbox.Text = "";
                    gender_combobox.Text = "";
                    email_textbox.Text = "";
                    position_txtbox.Text = "";
                    status_combobox.Text = "";
                    employeeID_txtbox.Text = "";
                    addEmployee_pictureBox.Image = Image.FromFile(@"C:\Users\xgael\source\repos\midtermCrudExamSanJuan\midtermCrudExamSanJuan\Resources\defaultprofile\default.png");
                    addEmployee_updateBtn.Enabled = false;
                    addEmployee_updateBtn.BackColor = System.Drawing.Color.Gray;
                    addEmployee_deleteBtn.Enabled = false;
                    addEmployee_deleteBtn.BackColor = System.Drawing.Color.Gray;
                    isRowSelected = false;
                }
                else
                {
                    
                    firstName_txtbox.Text = row.Cells["First_Name"].Value.ToString();
                    lastname_txtbox.Text = row.Cells["Last_Name"].Value.ToString();
                    gender_combobox.Text = row.Cells["Gender"].Value.ToString();
                    email_textbox.Text = row.Cells["Email"].Value.ToString();
                    position_txtbox.Text = row.Cells["Position"].Value.ToString();
                    status_combobox.Text = row.Cells["Status"].Value.ToString();
                    employeeID_txtbox.Text = row.Cells["Employee_ID"].Value.ToString();

                    
                    if (row.Cells["profile_image"].Value != DBNull.Value)
                    {
                        byte[] imageData = (byte[])row.Cells["profile_image"].Value;
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            addEmployee_pictureBox.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                       
                        addEmployee_pictureBox.Image = Image.FromFile(@"C:\Users\xgael\source\repos\midtermCrudExamSanJuan\midtermCrudExamSanJuan\Resources\defaultprofile\default.png");
                    }

                    
                    addEmployee_updateBtn.Enabled = true;
                    addEmployee_updateBtn.BackColor = Color.FromArgb(240, 89, 65);

                   
                    addEmployee_deleteBtn.Enabled = true;
                    addEmployee_deleteBtn.BackColor = Color.FromArgb(240, 89, 65);

                
                    isRowSelected = true;
                }
            }
            else
            {

                addEmployee_updateBtn.Enabled = false;
                addEmployee_updateBtn.BackColor = System.Drawing.Color.Gray;
                addEmployee_deleteBtn.Enabled = false;
                addEmployee_deleteBtn.BackColor = System.Drawing.Color.Gray;

                isRowSelected = false;
            }
        }

        private void addEmployee_updateBtn_Click(object sender, EventArgs e)
        {
            if (!isRowSelected)
            {
                MessageBox.Show("Please select an employee to update.");
                return;
            }

            if (string.IsNullOrEmpty(firstName_txtbox.Text) ||
                string.IsNullOrEmpty(lastname_txtbox.Text) ||
                string.IsNullOrEmpty(email_textbox.Text) ||
                string.IsNullOrEmpty(gender_combobox.Text) ||
                string.IsNullOrEmpty(position_txtbox.Text) ||
                string.IsNullOrEmpty(status_combobox.Text) ||
                string.IsNullOrEmpty(employeeID_txtbox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to update this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; 
            }

            try
            {

                mySqlConnection.Open();
                string query = "UPDATE employee SET First_Name = @first_name, Last_Name = @last_name, Gender = @gender, Email = @email, Position = @position, Status = @status";
                byte[] imageBytes = null;
                if (addEmployee_pictureBox.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        addEmployee_pictureBox.Image.Save(ms, addEmployee_pictureBox.Image.RawFormat);
                        imageBytes = ms.ToArray();
                    }

                    query += ", profile_image = @image";
                }
                query += " WHERE Employee_ID = @employee_id";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                cmd.Parameters.AddWithValue("@first_name", firstName_txtbox.Text);
                cmd.Parameters.AddWithValue("@last_name", lastname_txtbox.Text);
                cmd.Parameters.AddWithValue("@gender", gender_combobox.Text);
                cmd.Parameters.AddWithValue("@email", email_textbox.Text);
                cmd.Parameters.AddWithValue("@position", position_txtbox.Text);
                cmd.Parameters.AddWithValue("@status", status_combobox.Text);
                cmd.Parameters.AddWithValue("@employee_id", employeeID_txtbox.Text);

                if (imageBytes != null)
                {
                    cmd.Parameters.AddWithValue("@image", imageBytes);
                }

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Employee updated successfully!");
                    PopulateDataGridView();
                }
                else
                {
                    MessageBox.Show("Failed to update employee.");
                }
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

        private void addEmployee_deleteBtn_Click(object sender, EventArgs e)
        {
            if (!isRowSelected)
            {
                MessageBox.Show("Please select an employee to delete.");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; 
            }

            try
            {
                mySqlConnection.Open();
                string query = "DELETE FROM employee WHERE Employee_ID = @employee_id";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                cmd.Parameters.AddWithValue("@employee_id", employeeID_txtbox.Text);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Employee deleted successfully!");
                    PopulateDataGridView();
                }
                else
                {
                    MessageBox.Show("Failed to delete employee.");
                }
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

        private void addEmployee_clearBtn_Click(object sender, EventArgs e)
        {
            firstName_txtbox.Text = "";
            lastname_txtbox.Text = "";
            gender_combobox.Text = "";
            email_textbox.Text = "";
            position_txtbox.Text = "";
            status_combobox.Text = "";
            employeeID_txtbox.Text = "";

            gender_combobox.SelectedIndex = -1;
            status_combobox.SelectedIndex = -1;

            addEmployee_pictureBox.Image = null;
        }
    }
}
