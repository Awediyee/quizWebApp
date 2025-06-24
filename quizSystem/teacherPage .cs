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
    public partial class teacherPage : Form
    {
        public teacherPage()
        {
            InitializeComponent();
        }
        private int currentQuizId;

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
            teacherActionPage.SelectedIndex = 0;
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void adminPage_Load_2(object sender, EventArgs e)
        {
            LoadQuizzes();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            teacherActionPage.SelectedIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            teacherActionPage.SelectedIndex = 3;
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
                    teacherActionPage.Width += 120;
                    teacherActionPage.Location = new Point(80, -30);
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                    teacherActionPage.Width = 928;
                    teacherActionPage.Location = new Point(207, -30);
                }
            }
        }

        private void allQuizBtn_Click_1(object sender, EventArgs e)
        {
            teacherActionPage.SelectedIndex = 0; // Index is zero-base
        }

        private void teacherBtn_Click(object sender, EventArgs e)
        {
            teacherActionPage.SelectedIndex = 1;
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            teacherActionPage.SelectedIndex = 4;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void addTeacherBtn_Click(object sender, EventArgs e)
        {
            addQuizPanel.Visible = true;
        }

        private void showTeachersBtn_Click(object sender, EventArgs e)
        {
            addQuizPanel.Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

                // Validate DepartmentName for Teachers and Students
                if ((user.Role == "Teacher" || user.Role == "Student") && string.IsNullOrEmpty(user.DepartmentName))
                {
                    throw new ArgumentException("DepartmentName cannot be empty for Teachers and Students.");
                }

                // Create a new instance of dbConnection
                dbConnection dbConnection = new dbConnection();

                // Get the connection
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
            // Retrieve quiz details from input fields
            string title = quizTitleBox.Text.Trim();
            string description = quizDescBox.Text.Trim();

            if (!int.TryParse(totallQuestionsBox.Text, out int totalQuestions) || totalQuestions <= 0)
            {
                MessageBox.Show("Invalid total questions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(timeBox.Text, out int timeLimit) || timeLimit <= 0)
            {
                MessageBox.Show("Invalid time limit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int departmentId = int.Parse(userAdmin.DepartmentId); // Ensure the user's department is used

            // Initialize database connection
            dbConnection dbConn = new dbConnection();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                if (conn == null)
                {
                    MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"INSERT INTO Quizzes (title, description, total_questions, time_limit, department_id, created_by) 
                         VALUES (@Title, @Description, @TotalQuestions, @TimeLimit, @DepartmentId, @CreatedBy)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@TotalQuestions", totalQuestions);
                    cmd.Parameters.AddWithValue("@TimeLimit", timeLimit);
                    cmd.Parameters.AddWithValue("@DepartmentId", departmentId);
                    cmd.Parameters.AddWithValue("@CreatedBy", userAdmin.UserId);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Quiz inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear input fields after successful insertion
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Quiz insertion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Method to clear all input fields
        private void ClearInputFields()
        {
            quizTitleBox.Text = "";
            quizDescBox.Text = "";
            totallQuestionsBox.Text = "";
            timeBox.Text = "";
        }


        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, backspace, and delete
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the character
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, backspace, and delete
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the character
            }
        }

        private void LoadQuizzes()
        {
            dbConnection dbConn = new dbConnection();

            using (SqlConnection conn = dbConn.GetConnection())
            {
                if (conn == null)
                {
                    MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"SELECT quiz_id, title, total_questions, time_limit, status, date_created 
                         FROM Quizzes WHERE department_id = @DepartmentId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DepartmentId", userAdmin.DepartmentId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adapter.Fill(dt);

                    quizDataGridView.DataSource = dt; // Bind data to DataGridView
                    AddActionButtons(); // Add Edit, Delete, Add Questions buttons
                }
            }
        }


        private void AddActionButtons()
        {
            // Check if the "Edit" button already exists before adding
            if (quizDataGridView.Columns["Edit"] == null)
            {
                DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
                editBtn.Name = "Edit"; // Use a unique name for the column
                editBtn.HeaderText = "Edit";
                editBtn.Text = "Edit";
                editBtn.UseColumnTextForButtonValue = true;
                quizDataGridView.Columns.Add(editBtn);
            }

            // Check if the "Delete" button already exists before adding
            if (quizDataGridView.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
                deleteBtn.Name = "Delete"; // Use a unique name for the column
                deleteBtn.HeaderText = "Delete";
                deleteBtn.Text = "Delete";
                deleteBtn.UseColumnTextForButtonValue = true;
                quizDataGridView.Columns.Add(deleteBtn);
            }

            // Check if the "Add Questions" button already exists before adding
            if (quizDataGridView.Columns["AddQuestions"] == null)
            {
                DataGridViewButtonColumn addQuesBtn = new DataGridViewButtonColumn();
                addQuesBtn.Name = "AddQuestions"; // Use a unique name for the column
                addQuesBtn.HeaderText = "Add Questions";
                addQuesBtn.Text = "Add";
                addQuesBtn.UseColumnTextForButtonValue = true;
                quizDataGridView.Columns.Add(addQuesBtn);
            }
        }


        private void quizDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure it's not header row or an invalid column
            {
                string columnName = quizDataGridView.Columns[e.ColumnIndex].HeaderText; // Get the column name
                int quizId = Convert.ToInt32(quizDataGridView.Rows[e.RowIndex].Cells["quiz_id"].Value); // Get quiz ID
                currentQuizId = quizId;
                if (columnName == "Edit")
                {
                    EditQuiz(quizId); // Call Edit method only when clicking the Edit button
                }
                else if (columnName == "Delete")
                {
                    DeleteQuiz(quizId); // Call Delete method only when clicking the Delete button
                }
                else if (columnName == "Add Questions")
                {
                    AddQuestions(quizId); // Call Add Questions method only when clicking the Add Questions button
                }
            }
        }


        private void EditQuiz(int quizId)
        {
            // Retrieve quiz data from the database
            dbConnection dbConn = new dbConnection();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT title, description, total_questions, time_limit FROM Quizzes WHERE quiz_id = @QuizId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@QuizId", quizId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate the textboxes with the quiz data
                        txtTitle.Text = reader["title"].ToString();
                        txtDescription.Text = reader["description"].ToString();

                        // Parsing integers correctly for total_questions and time_limit
                        txtTotalQuestions.Text = Convert.ToInt32(reader["total_questions"]).ToString();
                        txtTimeLimit.Text = Convert.ToInt32(reader["time_limit"]).ToString();
                    }
                }
            }

            // Make the edit panel visible
            editQuestionPanel.Visible = true;
            // Optionally, you can hide other elements while the panel is visible
            quizDataGridView.Visible = false;
        }


        private void DeleteQuiz(int quizId)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this quiz?",
                                                   "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                dbConnection dbConn = new dbConnection();
                using (SqlConnection conn = dbConn.GetConnection())
                {
                    string query = "DELETE FROM Quizzes WHERE quiz_id = @QuizId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@QuizId", quizId);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Quiz deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadQuizzes(); // Refresh DataGridView
            }
        }
        private void AddQuestions(int quizId)
        {
            addQuestionsPanel.Visible = true;
            editQuestionPanel.Visible = false;
            viewQuizesPanel.Visible = false;
            LoadQuizzes();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            LoadQuizzes();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtTimeLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, backspace, and delete
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the character
            }
        }

        private void txtTotalQuestions_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, backspace, and delete
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the character
            }
        }

        private void applyEdit_Click(object sender, EventArgs e)
        {
            // Ensure valid input
            if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtDescription.Text) ||
                !int.TryParse(txtTotalQuestions.Text, out int totalQuestions) || totalQuestions <= 0 ||
                !int.TryParse(txtTimeLimit.Text, out int timeLimit) || timeLimit <= 0)
            {
                MessageBox.Show("Please enter valid data in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the quiz in the database
            dbConnection dbConn = new dbConnection();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "UPDATE Quizzes SET title = @Title, description = @Description, " +
                               "total_questions = @TotalQuestions, time_limit = @TimeLimit WHERE quiz_id = @QuizId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@TotalQuestions", totalQuestions);
                    cmd.Parameters.AddWithValue("@TimeLimit", timeLimit);
                    cmd.Parameters.AddWithValue("@QuizId", currentQuizId); // Use the quizId from the selected quiz

                    cmd.ExecuteNonQuery();
                }
            }

            // Show success message
            MessageBox.Show("Quiz updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh the DataGridView and hide the edit panel
            LoadQuizzes(); // Refresh DataGridView
            editQuestionPanel.Visible = false;
            quizDataGridView.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            editQuestionPanel.Visible = false;
            viewQuizesPanel.Visible = true;
            quizDataGridView.Visible = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void questionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (questionType.SelectedItem.ToString() == "TrueFalse")
            {
                trueFalsePanel.Visible = true;
                multpleChoosePanel.Visible = false;
            }
            else if (questionType.SelectedItem.ToString() == "MultipleChoice")
            {
                trueFalsePanel.Visible = false;
                multpleChoosePanel.Visible = true;
            }
        }
        private string GetSelectedAnswer()
        {
            if (questionType.SelectedItem.ToString() == "TrueFalse")
            {
                if (rbTrue.Checked) return "True";
                if (rbFalse.Checked) return "False";
            }
            else if (questionType.SelectedItem.ToString() == "MultipleChoice")
            {
                if (rbOptionA.Checked) return txtOptionA.Text;
                if (rbOptionB.Checked) return txtOptionB.Text;
                if (rbOptionC.Checked) return txtOptionC.Text;
                if (rbOptionD.Checked) return txtOptionD.Text;
            }

            return null; // No selection made
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtQuestionText.Text))
            {
                MessageBox.Show("Question text cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string correctAnswer = GetSelectedAnswer();
            if (string.IsNullOrEmpty(correctAnswer))
            {
                MessageBox.Show("Please select a correct answer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return; // Ensure validation passes

            // Fetch current number of questions in the quiz
            int totalQuestionsInQuiz = GetTotalQuestionsInQuiz(currentQuizId);

            // Fetch the total number of questions allowed (assuming this is stored in the quiz table)
            int maxQuestionsAllowed = GetMaxQuestionsAllowedForQuiz(currentQuizId);

            // Check if the total number of questions has been reached
            if (totalQuestionsInQuiz >= maxQuestionsAllowed)
            {
                MessageBox.Show("The maximum number of questions for this quiz has been reached.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if limit is reached
            }

            string questionText = txtQuestionText.Text;
            string correctAnswer = GetSelectedAnswer();
            string questionType = (correctAnswer == "True" || correctAnswer == "False") ? "TrueFalse" : "MultipleChoice";

            int insertedQuestionId = -1; // Store the newly inserted Question ID

            // Database connection
            dbConnection dbConn = new dbConnection();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                if (conn == null)
                {
                    MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Insert the question into the Questions table
                string query = @"INSERT INTO Questions (quiz_id, QuestionText, QuestionType, CorrectAnswer) 
                         OUTPUT INSERTED.QuestionID
                         VALUES (@QuizId, @QuestionText, @QuestionType, @CorrectAnswer)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@QuizId", currentQuizId);
                    cmd.Parameters.AddWithValue("@QuestionText", questionText);
                    cmd.Parameters.AddWithValue("@QuestionType", questionType);
                    cmd.Parameters.AddWithValue("@CorrectAnswer", correctAnswer);

                    try
                    {
                        insertedQuestionId = (int)cmd.ExecuteScalar(); // Get the inserted QuestionID
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // If the question is MultipleChoice, insert options into QuestionOptions table
                if (questionType == "MultipleChoice" && insertedQuestionId > 0)
                {
                    InsertMultipleChoiceOptions(conn, insertedQuestionId);
                }
            }

            MessageBox.Show("Question added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs(); // Clear inputs after successful insertion
        }


        private void InsertMultipleChoiceOptions(SqlConnection conn, int questionId)
        {
            string[] options = {
        txtOptionA.Text.Trim(),
        txtOptionB.Text.Trim(),
        txtOptionC.Text.Trim(),
        txtOptionD.Text.Trim()
    };

            char[] optionKeys = { 'A', 'B', 'C', 'D' };

            string query = @"INSERT INTO QuestionOptions (QuestionID, OptionKey, OptionText) 
                     VALUES (@QuestionID, @OptionKey, @OptionText)";

            foreach (var i in Enumerable.Range(0, options.Length))
            {
                if (string.IsNullOrWhiteSpace(options[i])) continue; // Skip empty options

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@QuestionID", questionId);
                    cmd.Parameters.AddWithValue("@OptionKey", optionKeys[i]);
                    cmd.Parameters.AddWithValue("@OptionText", options[i]);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error inserting option {optionKeys[i]}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        // Helper method to get the total number of questions in the current quiz
        private int GetTotalQuestionsInQuiz(int quizId)
        {
            int totalQuestions = 0;

            dbConnection dbConn = new dbConnection();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Questions WHERE quiz_id = @QuizId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@QuizId", quizId);
                    totalQuestions = (int)cmd.ExecuteScalar(); // Get the count of questions
                }
            }

            return totalQuestions;
        }

        // Helper method to get the maximum allowed questions for the quiz
        private int GetMaxQuestionsAllowedForQuiz(int quizId)
        {
            int maxQuestions = 0;

            dbConnection dbConn = new dbConnection();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                string query = "SELECT total_questions FROM Quizzes WHERE quiz_id = @QuizId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@QuizId", quizId);
                    maxQuestions = (int)cmd.ExecuteScalar(); // Get the total number of questions allowed
                }
            }

            return maxQuestions;
        }

        // Helper method to clear all input fields
        private void ClearInputs()
        {
            txtQuestionText.Clear();
            // Clear any other input fields you have
            // For example, if you have radio buttons or checkboxes:
            // radioButtonTrue.Checked = false;
            // radioButtonFalse.Checked = false;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            addQuestionsPanel.Visible = false;
            editQuestionPanel.Visible = false;
            viewQuizesPanel.Visible = true;
        }
    }
}
