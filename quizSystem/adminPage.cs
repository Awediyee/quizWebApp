using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizSystem
{
    public partial class adminPage : Form
    {
        public adminPage()
        {
            InitializeComponent();
        }

        private void fLable_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminPage_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void adminPage_Load_1(object sender, EventArgs e)
        {

        }

        private void allQuizBtn_Click(object sender, EventArgs e)
        {
            adminActionPage.SelectedIndex = 0; // Index is zero-based
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void adminPage_Load_2(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            adminActionPage.SelectedIndex = 2; // Index is zero-based
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminActionPage.SelectedIndex = 3; // Index is zero-based
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }
        bool sideBarExpand;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //get min and max size of the sidebar


            if (sideBarExpand)
            {
                //side bar minimize
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();
                    adminActionPage.Width += 120;
                    adminActionPage.Location = new Point(80, -30);
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                    adminActionPage.Width = 928;
                    adminActionPage.Location = new Point(207, -30);
                }
            }
        }

        private void allQuizBtn_Click_1(object sender, EventArgs e)
        {
            adminActionPage.SelectedIndex = 0; // Index is zero-base
        }

        private void teacherBtn_Click(object sender, EventArgs e)
        {
            adminActionPage.SelectedIndex = 1;
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            adminActionPage.SelectedIndex = 4;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void addTeacherBtn_Click(object sender, EventArgs e)
        {
            addTeacherPanel.Visible = true;
            showTeacherPanel.Visible = false;
        }

        private void showTeachersBtn_Click(object sender, EventArgs e)
        {
            addTeacherPanel.Visible = false;
            showTeacherPanel.Visible = true;
            FetchAndDisplayUserDataByRole("Teacher");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { // Check if the clicked cell is in the Delete or Edit column
            if (e.ColumnIndex == teacherDataGridView.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Get the user_id from the selected row
                int userId = Convert.ToInt32(teacherDataGridView.Rows[e.RowIndex].Cells["user_id"].Value);

                // Call the DeleteUser method
                DeleteUser(userId);

                // Refresh the DataGridView
                FetchAndDisplayUserDataByRole("Teacher"); // Replace "Teacher" with the desired role
            }
            else if (e.ColumnIndex == teacherDataGridView.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                // Get the user_id from the selected row
                int userId = Convert.ToInt32(teacherDataGridView.Rows[e.RowIndex].Cells["user_id"].Value);

                // Call the EditUser method
                EditUser(userId);
            }
        }


        //handle userAdding

        public void AddUser(User user, int addedByUserId)
        {
            try
            {
                // Validate input
                if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName))
                {
                    throw new ArgumentException("Username, first name, and last name cannot be empty.");
                }

                // Validate DepartmentName
                if ((user.Role == "Teacher" || user.Role == "Student") && string.IsNullOrEmpty(user.DepartmentName))
                {
                    throw new ArgumentException("DepartmentName cannot be empty for Teachers and Students.");
                }

                dbConnection dbConnection = new dbConnection();
                SqlConnection connection = dbConnection.GetConnection();

                if (connection == null)
                {
                    throw new Exception("Failed to establish a database connection.");
                }

                SqlTransaction transaction = null;

                try
                {
                    // Begin a transaction
                    transaction = connection.BeginTransaction();

                    // Insert into Users table
                    string insertUserQuery = @"
                INSERT INTO Users (username, password, first_name, last_name, Role, created_at, DepartmentName)
                VALUES (@username, @password, @first_name, @last_name, @Role, @created_at, @DepartmentName);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    SqlCommand userCommand = new SqlCommand(insertUserQuery, connection, transaction);
                    userCommand.Parameters.AddWithValue("@username", user.Username);
                    userCommand.Parameters.AddWithValue("@password", user.Password); // Hash the password
                    userCommand.Parameters.AddWithValue("@first_name", user.FirstName);
                    userCommand.Parameters.AddWithValue("@last_name", user.LastName);
                    userCommand.Parameters.AddWithValue("@Role", user.Role);
                    userCommand.Parameters.AddWithValue("@created_at", DateTime.Now);
                    userCommand.Parameters.AddWithValue("@DepartmentName", user.DepartmentName ?? (object)DBNull.Value); // Handle NULL for Admins

                    int userId = (int)userCommand.ExecuteScalar();

                    // Insert into Teacher or Student table based on role
                    if (user.Role == "Teacher" || user.Role == "Student")
                    {
                        // Get the department_id based on the DepartmentName
                        string getDepartmentIdQuery = "SELECT department_id FROM Departments WHERE department_name = @DepartmentName;";
                        SqlCommand departmentCommand = new SqlCommand(getDepartmentIdQuery, connection, transaction);
                        departmentCommand.Parameters.AddWithValue("@DepartmentName", user.DepartmentName);

                        int departmentId = (int)departmentCommand.ExecuteScalar();

                        // Insert into the appropriate table
                        if (user.Role == "Teacher")
                        {
                            string insertTeacherQuery = @"
                        INSERT INTO Teacher (user_id, department_id, added_by)
                        VALUES (@user_id, @department_id, @added_by);";

                            SqlCommand teacherCommand = new SqlCommand(insertTeacherQuery, connection, transaction);
                            teacherCommand.Parameters.AddWithValue("@user_id", userId);
                            teacherCommand.Parameters.AddWithValue("@department_id", departmentId);
                            teacherCommand.Parameters.AddWithValue("@added_by", addedByUserId);

                            teacherCommand.ExecuteNonQuery();
                        }
                        else if (user.Role == "Student")
                        {
                            string insertStudentQuery = @"
                        INSERT INTO Student (user_id, department_id, added_by)
                        VALUES (@user_id, @department_id, @added_by);";

                            SqlCommand studentCommand = new SqlCommand(insertStudentQuery, connection, transaction);
                            studentCommand.Parameters.AddWithValue("@user_id", userId);
                            studentCommand.Parameters.AddWithValue("@department_id", departmentId);
                            studentCommand.Parameters.AddWithValue("@added_by", addedByUserId);

                            studentCommand.ExecuteNonQuery();
                        }
                    }

                    // Commit the transaction
                    transaction.Commit();

                    // Notify the user of success
                    MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException sqlEx)
                {
                    // Rollback the transaction in case of a SQL error
                    transaction?.Rollback();
                    MessageBox.Show("A database error occurred while adding the user: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Rollback the transaction in case of any other error
                    transaction?.Rollback();
                    MessageBox.Show("An unexpected error occurred while adding the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close the connection
                    dbConnection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            User user = new User
            {
                Username = $"{firtsNameBox.Text}@{lastNameBox.Text}",
                FirstName = $"{firtsNameBox.Text}",
                LastName = $"{lastNameBox.Text}",
                Role = "Teacher",
                Password = "asdfg",//Default Password for users
                DepartmentName = departmentComboBox.SelectedItem.ToString()
            };
            AddUser(user, 1);
        }

        private void stdAddBtn_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Username = $"{studentFnameBox.Text}@{studentLnameBox.Text}",
                FirstName = $"{studentFnameBox.Text}",
                LastName = $"{studentLnameBox.Text}",
                Role = "Student",
                Password = "123456",//Default Password for users
                DepartmentName = studentComboBox.SelectedItem.ToString()
            };
            AddUser(user, 1);
        }

        private void showStudentBtn_Click(object sender, EventArgs e)
        {
            studentAddPanel.Visible = false;
            studentShowPanel.Visible = true;
            FetchAndDisplayUserDataByRole("Student");
        }

        private void addStudentBtn_Click_1(object sender, EventArgs e)
        {
            studentAddPanel.Visible = true;
            studentShowPanel.Visible = false;
        }

        //fetch users to table

        private void FetchAndDisplayUserDataByRole(string role)
        {
            // mapping between roles and DataGridView using dictionary
            Dictionary<string, DataGridView> roleToGridMap = new Dictionary<string, DataGridView>
    {
        { "Teacher", teacherDataGridView },
        { "Student", StudentDataGridView }
    };

            // Get the corresponding DataGridView for the role
            DataGridView targetGridView = roleToGridMap[role];
            string query = "SELECT user_id, username, first_name, last_name, DepartmentName FROM Users WHERE Role = @Role";

            // Create a DataTable to hold the fetched data
            DataTable dataTable = new DataTable();

            // Create a database connection
            dbConnection dbConn = new dbConnection();

            using (SqlConnection connection = dbConn.GetConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("Failed to create a database connection.");
                    return;
                }

                try
                {
                    connection.Close();
                    connection.Open();

                    // Create a command object
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the role parameter to the command
                        command.Parameters.AddWithValue("@Role", role);

                        // Create a data adapter
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                        {
                            // Fill the DataTable
                            dataAdapter.Fill(dataTable);
                        }
                    }

                    // Bind the DataTable to the appropriate DataGridView
                    targetGridView.DataSource = dataTable;
                    AddButtonColumns(role);
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Ensure the connection is closed
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }


        //edit user
        private void EditUser(int userId)
        {
            dbConnection dbConn = new dbConnection();

            // SQL query to fetch user data by ID
            string query = "SELECT user_id, username, first_name, last_name, Role, DepartmentName FROM Users WHERE user_id = @user_id";

            using (SqlConnection connection = dbConn.GetConnection())
            {
                try
                {
                    connection.Close();
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the user_id parameter to the command
                        command.Parameters.AddWithValue("@user_id", userId);

                        // Execute the query and read the data
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate UI components with user data
                                editFnameBox.Text = reader["first_name"].ToString();
                                editLnameBox.Text = reader["last_name"].ToString();
                                editUsernameBox.Text = reader["username"].ToString();
                                editRoleComboBox.SelectedItem = reader["Role"].ToString();
                                editComboBox.SelectedItem = reader["DepartmentName"].ToString();
                                editPanel.Visible = true; // Show the edit panel
                            }
                            else
                            {
                                MessageBox.Show("User not found!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Ensure the connection is closed
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }




        //Delete user
        private void DeleteUser(int userId)
        {
            dbConnection dbConn = new dbConnection();

            // SQL query to delete a user by ID
            string query = "DELETE FROM Users WHERE user_id = @user_id";

            // Use the connection object from your dbConnection class
            using (SqlConnection connection = dbConn.GetConnection())
            {
                try
                {
                    // Open the connection
                    connection.Close();
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the user_id parameter to the command
                        command.Parameters.AddWithValue("@user_id", userId);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("User not found!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Ensure the connection is closed
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        //buttons
        private void AddButtonColumns(string role)
        {
            if (role == "Teacher")
            {
                // Add Delete button column
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None, // Disable auto-sizing
                    Width = 80 // Set a fixed width for the button column
                };
                teacherDataGridView.Columns.Add(deleteButtonColumn);

                // Add Edit button column
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Width = 80
                };
                teacherDataGridView.Columns.Add(editButtonColumn);

                // change button pos
                int totalColumns = teacherDataGridView.Columns.Count;
                teacherDataGridView.Columns["Delete"].DisplayIndex = totalColumns - 2;
                teacherDataGridView.Columns["Edit"].DisplayIndex = totalColumns - 1;
            }
            else
            {
                // Add Delete button column
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None, // Disable auto-sizing
                    Width = 80 // Set a fixed width for the button column
                };
                teacherDataGridView.Columns.Add(deleteButtonColumn);

                // Add Edit button column
                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Width = 80
                };
                StudentDataGridView.Columns.Add(editButtonColumn);

                // change button pos
                int totalColumns = teacherDataGridView.Columns.Count;
                StudentDataGridView.Columns["Delete"].DisplayIndex = totalColumns - 2;
                StudentDataGridView.Columns["Edit"].DisplayIndex = totalColumns - 1;

            }
        }


        private void teacherDataGridView_Click(object sender, EventArgs e)
        {

        }

        private void editComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // Create a User object
            User editedUser = new User
            {
                Username = $"{editFnameBox.Text}@{editLnameBox.Text}",
                FirstName = editFnameBox.Text,
                LastName = editLnameBox.Text,
                Role = editRoleComboBox.SelectedItem.ToString(),
                Password = "123456",
                DepartmentName = editComboBox.SelectedItem.ToString()
            };

            // Call addUser 
            AddUser(editedUser, 1);

        }
        //load quizes

        private void LoadPendingQuizzes(DataGridView pendingGridView)
        {
            // Create a new dbConnection object
            dbConnection dbConn = new dbConnection();

            // SQL query to fetch pending quizzes
            string query = @"
        SELECT 
            quiz_id,
            title,
            description,
            created_by,
            date_created
        FROM 
            Quizzes
        WHERE 
            status = 'pending';";

            // Use the dbConnection class to get the connection
            using (SqlConnection connection = dbConn.GetConnection())
            {
                if (connection != null)
                {
                    try
                    {
                        // Create a SqlCommand to execute the query
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Create a SqlDataAdapter to fetch the data
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                            // Create a DataTable to hold the data
                            DataTable dataTable = new DataTable();

                            // Fill the DataTable with the data from the query
                            dataAdapter.Fill(dataTable);

                            // Bind the DataTable to the pendingGridView
                            pendingGridView.DataSource = dataTable;

                            // Add an "Approve" button column if it doesn't already exist
                            if (pendingGridView.Columns["ApproveButtonColumn"] == null)
                            {
                                DataGridViewButtonColumn approveButtonColumn = new DataGridViewButtonColumn
                                {
                                    Name = "ApproveButtonColumn",
                                    HeaderText = "Action",
                                    Text = "Approve",
                                    UseColumnTextForButtonValue = true
                                };
                                pendingGridView.Columns.Add(approveButtonColumn);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Close the connection
                        dbConn.CloseConnection();
                    }
                }
                else
                {
                    MessageBox.Show("Failed to establish a database connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //approve quizess

        private void ApproveQuiz(int quizId, int userAdminId)
        {
            // Create a new dbConnection object
            dbConnection dbConn = new dbConnection();

            // SQL query to update the quiz status and approved_by field
            string query = @"
        UPDATE Quizzes
        SET 
            status = 'approved',
            approved_by = @adminId
        WHERE 
            quiz_id = @quizId;";

            // Use the dbConnection class to get the connection
            using (SqlConnection connection = dbConn.GetConnection())
            {
                if (connection != null)
                {
                    try
                    {
                        // Create a SqlCommand to execute the query
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add parameters to the query
                            command.Parameters.AddWithValue("@adminId", userAdminId);
                            command.Parameters.AddWithValue("@quizId", quizId);

                            // Execute the query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Quiz approved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to approve the quiz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Close the connection
                        dbConn.CloseConnection();
                    }
                }
                else
                {
                    MessageBox.Show("Failed to establish a database connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void StudentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            pendingQuizPanel.Visible = true;
            LoadPendingQuizzes(pendingQuizGrid);
        }

        private void pendingQuizGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the "Approve" button was clicked
            if (e.ColumnIndex == pendingQuizGrid.Columns["ApproveButtonColumn"].Index && e.RowIndex >= 0)
            {
                // Get the quiz_id from the selected row
                int quizId = Convert.ToInt32(pendingQuizGrid.Rows[e.RowIndex].Cells["quiz_id"].Value);

                // Update the quiz status to "approved"
                ApproveQuiz(quizId, userAdmin.UserId);

                // Refresh the grid
                LoadPendingQuizzes(pendingQuizGrid);
            }

        }
    }
}