using Microsoft.Data.SqlClient;
using quizSystem.Models;
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
    public partial class studentPage : Form
    {
        public studentPage()
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
            mainTab.SelectedIndex = 0; // Index is zero-based
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void adminPage_Load_2(object sender, EventArgs e)
        {
            LoadQuizzesAsCards();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            mainTab.SelectedIndex = 2; // Index is zero-based
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainTab.SelectedIndex = 3; // Index is zero-based
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
                    mainTab.Width += 120;
                    mainTab.Location = new Point(80, -30);
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                    mainTab.Width = 928;
                    mainTab.Location = new Point(207, -30);
                }
            }
        }

        private void allQuizBtn_Click_1(object sender, EventArgs e)
        {
            mainTab.SelectedIndex = 0; // Index is zero-base
        }

        private void teacherBtn_Click(object sender, EventArgs e)
        {
            mainTab.SelectedIndex = 1;
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            mainTab.SelectedIndex = 4;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

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

        int QuizId;
        private void LoadQuizzesAsCards()
        {
            //MessageBox.Show("LoadQuizzesAsCards method called!");  // For testing, remove after confirming it's called

            // Clear any previous controls to refresh the view
            panelQuizzes.Controls.Clear();
            List<Quiz> quizzes = GetQuizzesFromDatabase();//storign quizes as list

            // Loop through the quizzes and create cards for each
            foreach (var quiz in quizzes)
            {
                // Create a new panel for each quiz (this will be the "card")
                Panel quizCard = new Panel();
                quizCard.Size = new Size(250, 150);
                quizCard.BackColor = Color.FromArgb(245, 245, 245);
                quizCard.BorderStyle = BorderStyle.FixedSingle;
                quizCard.Margin = new Padding(10);
                quizCard.Padding = new Padding(10);

                // Title label for quiz
                Label titleLabel = new Label();
                titleLabel.Text = quiz.Title;
                titleLabel.Font = new Font("Arial", 12, FontStyle.Bold);
                titleLabel.ForeColor = Color.DarkSlateGray;
                titleLabel.Location = new Point(10, 10);
                titleLabel.AutoSize = true;
                quizCard.Controls.Add(titleLabel);

                // Total questions label
                Label totalQuestionsLabel = new Label();
                totalQuestionsLabel.Text = $"Total Questions: {quiz.TotalQuestions}";
                totalQuestionsLabel.Font = new Font("Arial", 10, FontStyle.Regular);
                totalQuestionsLabel.ForeColor = Color.Gray;
                totalQuestionsLabel.Location = new Point(10, 40);
                totalQuestionsLabel.AutoSize = true;
                quizCard.Controls.Add(totalQuestionsLabel);

                // Button to start quiz
                Button startButton = new Button();
                startButton.Text = "Start Quiz";
                startButton.Size = new Size(100, 30);
                startButton.Location = new Point(10, 70);
                startButton.BackColor = Color.Teal;
                startButton.ForeColor = Color.White;
                startButton.FlatStyle = FlatStyle.Flat;
                startButton.Click += (sender, e) => StartQuiz(quiz.QuizId);
                quizCard.Controls.Add(startButton);

                // Add the quiz card to the panel
                panelQuizzes.Controls.Add(quizCard);
            }
        }

        private List<Quiz> GetQuizzesFromDatabase()
        {
            List<Quiz> quizzes = new List<Quiz>();

            // Initialize the database connection
            dbConnection dbConn = new dbConnection();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                if (conn == null)
                {
                    MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return quizzes; // Return empty list if connection failed
                }

                // Query to retrieve quizzes
                string query = @"SELECT quiz_id, title, total_questions
                         FROM Quizzes
                         WHERE status = 'approved'"; // You can adjust the status condition as needed

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Quiz quiz = new Quiz
                        {
                            QuizId = Convert.ToInt32(reader["quiz_id"]),
                            Title = reader["title"].ToString(),
                            TotalQuestions = Convert.ToInt32(reader["total_questions"])
                        };
                        quizzes.Add(quiz);
                    }
                }
            }

            return quizzes;
        }

        //fetch quizes as lists

        private List<Question> GetQuestionsForQuiz(int quizId)
        {
            List<Question> questions = new List<Question>();

            dbConnection dbConn = new dbConnection();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                if (conn == null)
                {
                    MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return questions; // Return empty list if connection failed
                }

                string query = @"SELECT q.QuestionID, q.QuestionText, q.QuestionType, q.CorrectAnswer 
                         FROM Questions q
                         WHERE q.quiz_id = @QuizId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@QuizId", quizId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Question question = new Question
                        {
                            QuestionId = Convert.ToInt32(reader["QuestionID"]),
                            QuestionText = reader["QuestionText"].ToString(),
                            QuestionType = reader["QuestionType"].ToString(),
                            CorrectAnswer = reader["CorrectAnswer"].ToString()
                        };
                        questions.Add(question);
                    }
                }
            }

            return questions;
        }
        //
        private int currentQuestionIndex = 0;
        private List<Question> quizQuestions = new List<Question>();
        private List<UserAnswer> userAnswers = new List<UserAnswer>();

        private void StartQuiz(int quizId)
        {
            QuizId = quizId;
            quizQuestions = GetQuestionsForQuiz(quizId);
            if (quizQuestions.Count == 0)
            {
                MessageBox.Show("No questions available for this quiz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userAnswers = new List<UserAnswer>(new UserAnswer[quizQuestions.Count]);
            currentQuestionIndex = 0;
            DisplayCurrentQuestion();
        }

        private void DisplayCurrentQuestion()
        {
            if (quizQuestions == null || quizQuestions.Count == 0 || currentQuestionIndex < 0 || currentQuestionIndex >= quizQuestions.Count)
                return;

            quizStartedPanel.Visible = true;
            panelQuizzes.Visible = false;

            var currentQuestion = quizQuestions[this.currentQuestionIndex];
            lblQuestion.Text = $"{currentQuestionIndex + 1}. {currentQuestion.QuestionText}";
            optionsPanel.Controls.Clear();

            if (currentQuestion.QuestionType == "MultipleChoice")
            {
                LoadMultipleChoiceOptions(currentQuestion.QuestionId);
            }
            else if (currentQuestion.QuestionType == "TrueFalse")
            {
                LoadTrueFalseOptions();
            }

            btnPrevious.Enabled = this.currentQuestionIndex > 0;
            btnNext.Enabled = this.currentQuestionIndex < quizQuestions.Count - 1;
            btnFinish.Visible = this.currentQuestionIndex == quizQuestions.Count - 1;
        }

        private void LoadMultipleChoiceOptions(int questionId)
        {
            optionsPanel.Controls.Clear();
            dbConnection dbConn = new dbConnection();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                if (conn == null)
                {
                    MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "SELECT OptionText FROM QuestionOptions WHERE QuestionID = @QuestionID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@QuestionID", questionId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        RadioButton rbOption = new RadioButton()
                        {
                            Text = reader["OptionText"].ToString(),
                            Tag = reader["OptionText"].ToString(),
                            AutoSize = true
                        };
                        rbOption.CheckedChanged += Option_CheckedChanged;
                        optionsPanel.FlowDirection = FlowDirection.TopDown;
                        optionsPanel.Controls.Add(rbOption);
                    }
                }
            }
        }

        private void LoadTrueFalseOptions()
        {
            optionsPanel.Controls.Clear();
            optionsPanel.FlowDirection = FlowDirection.TopDown; // vertical display
            optionsPanel.AutoSize = true;

            string[] options = { "True", "False" };
            foreach (var option in options)
            {
                RadioButton rbOption = new RadioButton()
                {
                    Text = option,
                    Tag = option,
                    AutoSize = true,
                    Width = 100 // Ensure enough space for text
                };
                rbOption.CheckedChanged += Option_CheckedChanged;
                optionsPanel.Controls.Add(rbOption);
            }
            optionsPanel.Refresh(); // Force UI update
        }


        private void Option_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton selectedRadioButton && selectedRadioButton.Checked)
            {
                userAnswers[currentQuestionIndex] = new UserAnswer
                {
                    QuestionId = quizQuestions[currentQuestionIndex].QuestionId,
                    Answer = selectedRadioButton.Tag.ToString()
                };
            }
        }

        private void panelQuizzes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int correctAnswersCount = 0;

            // Check answers
            foreach (var answer in userAnswers)
            {
                var question = quizQuestions.First(q => q.QuestionId == answer.QuestionId);
                if (answer.Answer == question.CorrectAnswer)
                {
                    correctAnswersCount++;
                }
            }

            // Store result
            SaveResult(correctAnswersCount);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex < quizQuestions.Count - 1)
            {
                this.currentQuestionIndex++;
                DisplayCurrentQuestion();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex > 0)
            {
                this.currentQuestionIndex--;
                DisplayCurrentQuestion();
            }
        }

        private void SaveResult(int correctAnswersCount)
        {
            dbConnection dbConn = new dbConnection();
            using (SqlConnection conn = dbConn.GetConnection())
            {
                if (conn == null)
                {
                    MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = @"INSERT INTO Results (user_id, quiz_id, score, total_questions) 
                         VALUES (@UserId, @QuizId, @Score, @TotalQuestions)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userStudent.UserId);
                    cmd.Parameters.AddWithValue("@QuizId", QuizId);
                    cmd.Parameters.AddWithValue("@Score", correctAnswersCount);
                    cmd.Parameters.AddWithValue("@TotalQuestions", quizQuestions.Count);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Quiz finished! Your score is " + correctAnswersCount, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving result: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //display result

        public void FetchAndBindResults(DataGridView resultDataGridView)
        {
            // Create an instance of dbConnection
            dbConnection dbConn = new dbConnection();

            // SQL query to fetch data
            string query = @"
                SELECT 
                    R.result_id,
                    R.user_id,
                    R.quiz_id,
                    Q.title AS quiz_title,
                    R.score,
                    R.total_questions
                FROM 
                    Results R
                INNER JOIN 
                    Quizzes Q ON R.quiz_id = Q.quiz_id;";

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

                            // Bind the DataTable to the DataGridView
                            if (dataTable != null && dataTable.Rows.Count > 0)
                            {
                                resultDataGridView.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            resultDataGrid.Visible = true;
            FetchAndBindResults(resultDataGrid);
        }

        private void quizStartedPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
