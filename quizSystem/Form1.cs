using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace quizSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;

            // Create a pen with the desired color and width
            using (Pen pen = new Pen(Color.FromArgb(0, 153, 255), 2))
            {
                // Draw a rectangle around the panel
                e.Graphics.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1);
            }
        }


        private void slogan_Click(object sender, EventArgs e)
        {

        }

        private void quizTxtLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usrTxtBox_Click(object sender, EventArgs e)
        {
            usrTxtBox.Text = "";
        }

        private void pwdTxtBox_Click(object sender, EventArgs e)
        {
            pwdTxtBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Call the AuthenticateUser method
            User authenticatedUser = AuthenticateUser(usrTxtBox.Text, pwdTxtBox.Text);

            if (authenticatedUser != null)
            {
                // Initialize a User object
                User newUser = new User
                {
                    UserId = authenticatedUser.UserId,
                    Username = authenticatedUser.Username,
                    FirstName = authenticatedUser.FirstName,
                    LastName = authenticatedUser.LastName,
                    Role = authenticatedUser.Role,
                    DepartmentId = authenticatedUser.DepartmentId,
                    DepartmentName = authenticatedUser.DepartmentName
                };

                if (newUser != null)
                {
                    // Open the appropriate form based on the role and pass the user data
                    switch (newUser.Role.ToLower())
                    {
                        case "admin":
                            MessageBox.Show("Welcome Admin.");
                            adminPage adminPage = new adminPage(newUser);
                            this.Hide();
                            adminPage.FormClosed += (s, args) => this.Close(); 
                            adminPage.Show();
                            break;

                        case "student":
                            MessageBox.Show("Welcome Student.");
                            studentPage studentPage = new studentPage(newUser);
                            this.Hide();
                            studentPage.FormClosed += (s, args) => this.Close();
                            studentPage.Show();
                            break;
                        case "teacher":
                            MessageBox.Show("Welcome Teacher.");
                            teacherPage teacherPage = new teacherPage(newUser);
                            this.Hide();
                            teacherPage.FormClosed += (s, args) => this.Close();
                            teacherPage.Show();
                            break;
                        default:
                            MessageBox.Show("Unknown role.");
                            break;
                    }

                }
            }
        }

        //method to handle user login and gent user

        public User AuthenticateUser(string username, string inputPassword)
        {
            dbConnection db = new dbConnection();
            SqlConnection connection = db.GetConnection();

            if (connection == null)
            {
                MessageBox.Show("Failed to connect to the database.");
                return null;
            }

            try
            {
                // Query to get the user's details, including department name
                string query = @"
            SELECT 
                u.user_id, 
                u.username, 
                u.first_name, 
                u.last_name, 
                u.Role, 
                u.ImagePath,
                u.created_at,
                CASE 
                    WHEN u.Role = 'Teacher' THEN t.department_id
                    WHEN u.Role = 'Student' THEN s.department_id
                    ELSE NULL -- For roles like 'Admin', department_id is not applicable
                END AS department_id,
                CASE 
                    WHEN u.Role = 'Teacher' THEN d.department_name
                    WHEN u.Role = 'Student' THEN d.department_name
                    ELSE NULL -- For roles like 'Admin', department_name is not applicable
                END AS department_name
            FROM 
                Users u
            LEFT JOIN 
                Teacher t ON u.user_id = t.user_id AND u.Role = 'Teacher'
            LEFT JOIN 
                Student s ON u.user_id = s.user_id AND u.Role = 'Student'
            LEFT JOIN 
                Departments d ON 
                (CASE 
                    WHEN u.Role = 'Teacher' THEN t.department_id
                    WHEN u.Role = 'Student' THEN s.department_id
                    ELSE NULL
                END) = d.department_id
            WHERE 
                u.Username = @Username 
                AND u.Password = @Password;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", inputPassword); // Use hashed password in production

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            // Create a User object with the retrieved data
                            User user = new User
                            {
                                UserId = reader.GetInt32(reader.GetOrdinal("user_id")),
                                Username = reader.GetString(reader.GetOrdinal("username")),
                                FirstName = reader.GetString(reader.GetOrdinal("first_name")),
                                LastName = reader.GetString(reader.GetOrdinal("last_name")),
                                Role = reader.GetString(reader.GetOrdinal("Role")),
                                DepartmentId = reader.IsDBNull(reader.GetOrdinal("department_id")) ? null : reader.GetInt32(reader.GetOrdinal("department_id")).ToString(),
                                DepartmentName = reader.IsDBNull(reader.GetOrdinal("department_name")) ? null : reader.GetString(reader.GetOrdinal("department_name"))
                            };

                            return user;
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return null;
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
}
