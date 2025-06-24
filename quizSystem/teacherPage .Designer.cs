using Microsoft.VisualBasic.ApplicationServices;

namespace quizSystem
{
    partial class teacherPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private User userAdmin; // Declare at class level

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacherPage));
            sideBar = new System.Windows.Forms.FlowLayoutPanel();
            panel1 = new System.Windows.Forms.Panel();
            usrLabel = new System.Windows.Forms.Label();
            menulabel = new System.Windows.Forms.Label();
            menuBtn = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            allQuizBtn = new System.Windows.Forms.Button();
            teacherBtn = new System.Windows.Forms.Button();
            studentBtn = new System.Windows.Forms.Button();
            msgBtn = new System.Windows.Forms.Button();
            profileBtn = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            sideBarTimer = new System.Windows.Forms.Timer(components);
            teacherActionPage = new System.Windows.Forms.TabControl();
            AllQuizTab = new System.Windows.Forms.TabPage();
            addQuestionsPanel = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            button5 = new System.Windows.Forms.Button();
            saveBtn = new System.Windows.Forms.Button();
            trueFalsePanel = new System.Windows.Forms.Panel();
            rbFalse = new System.Windows.Forms.RadioButton();
            rbTrue = new System.Windows.Forms.RadioButton();
            label16 = new System.Windows.Forms.Label();
            multpleChoosePanel = new System.Windows.Forms.Panel();
            txtOptionD = new System.Windows.Forms.TextBox();
            txtOptionB = new System.Windows.Forms.TextBox();
            txtOptionC = new System.Windows.Forms.TextBox();
            txtOptionA = new System.Windows.Forms.TextBox();
            rbOptionD = new System.Windows.Forms.RadioButton();
            rbOptionC = new System.Windows.Forms.RadioButton();
            rbOptionB = new System.Windows.Forms.RadioButton();
            rbOptionA = new System.Windows.Forms.RadioButton();
            txtQuestionText = new System.Windows.Forms.TextBox();
            questionType = new System.Windows.Forms.ComboBox();
            label22 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            editQuestionPanel = new System.Windows.Forms.Panel();
            button4 = new System.Windows.Forms.Button();
            panel6 = new System.Windows.Forms.Panel();
            applyEdit = new System.Windows.Forms.Button();
            txtTitle = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            txtTotalQuestions = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            txtTimeLimit = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            viewQuizesPanel = new System.Windows.Forms.Panel();
            button2 = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            quizDataGridView = new System.Windows.Forms.DataGridView();
            myQuizTab = new System.Windows.Forms.TabPage();
            addQuizPanel = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            totallQuestionsBox = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            quizDescBox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            timeBox = new System.Windows.Forms.TextBox();
            quizTitleBox = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            btnPanel = new System.Windows.Forms.Panel();
            addTeacherBtn = new System.Windows.Forms.Button();
            tabPage3 = new System.Windows.Forms.TabPage();
            tabPage4 = new System.Windows.Forms.TabPage();
            tabPage5 = new System.Windows.Forms.TabPage();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sideBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuBtn).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            teacherActionPage.SuspendLayout();
            AllQuizTab.SuspendLayout();
            addQuestionsPanel.SuspendLayout();
            panel5.SuspendLayout();
            trueFalsePanel.SuspendLayout();
            multpleChoosePanel.SuspendLayout();
            editQuestionPanel.SuspendLayout();
            panel6.SuspendLayout();
            viewQuizesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quizDataGridView).BeginInit();
            myQuizTab.SuspendLayout();
            addQuizPanel.SuspendLayout();
            panel4.SuspendLayout();
            btnPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.BackColor = System.Drawing.Color.FromArgb(0, 153, 255);
            sideBar.Controls.Add(panel1);
            sideBar.Controls.Add(panel2);
            sideBar.Controls.Add(teacherBtn);
            sideBar.Controls.Add(studentBtn);
            sideBar.Controls.Add(msgBtn);
            sideBar.Controls.Add(profileBtn);
            sideBar.Controls.Add(panel3);
            sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            sideBar.ForeColor = System.Drawing.SystemColors.ControlLight;
            sideBar.Location = new System.Drawing.Point(0, 0);
            sideBar.MaximumSize = new System.Drawing.Size(201, 450);
            sideBar.MinimumSize = new System.Drawing.Size(46, 900);
            sideBar.Name = "sideBar";
            sideBar.Size = new System.Drawing.Size(201, 900);
            sideBar.TabIndex = 0;
            sideBar.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(usrLabel);
            panel1.Controls.Add(menulabel);
            panel1.Controls.Add(menuBtn);
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(197, 127);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // usrLabel
            // 
            usrLabel.AutoSize = true;
            usrLabel.Font = new System.Drawing.Font("Sitka Banner", 11.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 161);
            usrLabel.Location = new System.Drawing.Point(41, 55);
            usrLabel.Name = "usrLabel";
            usrLabel.Size = new System.Drawing.Size(64, 21);
            usrLabel.TabIndex = 2;
            usrLabel.Text = "Wellcome";
            // 
            // menulabel
            // 
            menulabel.AutoSize = true;
            menulabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            menulabel.Location = new System.Drawing.Point(41, 16);
            menulabel.Name = "menulabel";
            menulabel.Size = new System.Drawing.Size(54, 23);
            menulabel.TabIndex = 1;
            menulabel.Text = "Menu";
            // 
            // menuBtn
            // 
            menuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            menuBtn.Image = (System.Drawing.Image)resources.GetObject("menuBtn.Image");
            menuBtn.Location = new System.Drawing.Point(3, 3);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new System.Drawing.Size(32, 36);
            menuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            menuBtn.TabIndex = 0;
            menuBtn.TabStop = false;
            menuBtn.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(allQuizBtn);
            panel2.Location = new System.Drawing.Point(3, 136);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(197, 38);
            panel2.TabIndex = 2;
            // 
            // allQuizBtn
            // 
            allQuizBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            allQuizBtn.ForeColor = System.Drawing.SystemColors.Control;
            allQuizBtn.Image = (System.Drawing.Image)resources.GetObject("allQuizBtn.Image");
            allQuizBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            allQuizBtn.Location = new System.Drawing.Point(0, 0);
            allQuizBtn.Name = "allQuizBtn";
            allQuizBtn.Size = new System.Drawing.Size(194, 38);
            allQuizBtn.TabIndex = 1;
            allQuizBtn.Text = "All Quiz";
            allQuizBtn.UseVisualStyleBackColor = true;
            allQuizBtn.Click += allQuizBtn_Click_1;
            // 
            // teacherBtn
            // 
            teacherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            teacherBtn.ForeColor = System.Drawing.SystemColors.Control;
            teacherBtn.Image = (System.Drawing.Image)resources.GetObject("teacherBtn.Image");
            teacherBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            teacherBtn.Location = new System.Drawing.Point(3, 180);
            teacherBtn.MaximumSize = new System.Drawing.Size(194, 38);
            teacherBtn.Name = "teacherBtn";
            teacherBtn.Size = new System.Drawing.Size(194, 38);
            teacherBtn.TabIndex = 2;
            teacherBtn.Text = "Add quiz";
            teacherBtn.UseVisualStyleBackColor = true;
            teacherBtn.Click += teacherBtn_Click;
            // 
            // studentBtn
            // 
            studentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            studentBtn.ForeColor = System.Drawing.SystemColors.Control;
            studentBtn.Image = (System.Drawing.Image)resources.GetObject("studentBtn.Image");
            studentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            studentBtn.Location = new System.Drawing.Point(3, 224);
            studentBtn.Name = "studentBtn";
            studentBtn.Size = new System.Drawing.Size(194, 38);
            studentBtn.TabIndex = 2;
            studentBtn.Text = "Students";
            studentBtn.UseVisualStyleBackColor = true;
            studentBtn.Click += button2_Click_1;
            // 
            // msgBtn
            // 
            msgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            msgBtn.ForeColor = System.Drawing.SystemColors.Control;
            msgBtn.Image = (System.Drawing.Image)resources.GetObject("msgBtn.Image");
            msgBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            msgBtn.Location = new System.Drawing.Point(3, 268);
            msgBtn.Name = "msgBtn";
            msgBtn.Size = new System.Drawing.Size(194, 38);
            msgBtn.TabIndex = 2;
            msgBtn.Text = "Messages";
            msgBtn.UseVisualStyleBackColor = true;
            msgBtn.Click += button3_Click;
            // 
            // profileBtn
            // 
            profileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            profileBtn.ForeColor = System.Drawing.SystemColors.Control;
            profileBtn.Image = (System.Drawing.Image)resources.GetObject("profileBtn.Image");
            profileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            profileBtn.Location = new System.Drawing.Point(3, 312);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new System.Drawing.Size(194, 38);
            profileBtn.TabIndex = 3;
            profileBtn.Text = "Profile";
            profileBtn.UseVisualStyleBackColor = true;
            profileBtn.Click += profileBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new System.Drawing.Point(3, 356);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(194, 84);
            panel3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(50, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(134, 15);
            label2.TabIndex = 1;
            label2.Text = "2025 All Rights Reserved";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(50, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "Student Quiz System";
            // 
            // sideBarTimer
            // 
            sideBarTimer.Interval = 10;
            sideBarTimer.Tick += timer1_Tick;
            // 
            // teacherActionPage
            // 
            teacherActionPage.Controls.Add(AllQuizTab);
            teacherActionPage.Controls.Add(myQuizTab);
            teacherActionPage.Controls.Add(tabPage3);
            teacherActionPage.Controls.Add(tabPage4);
            teacherActionPage.Controls.Add(tabPage5);
            teacherActionPage.Location = new System.Drawing.Point(207, -30);
            teacherActionPage.Name = "teacherActionPage";
            teacherActionPage.SelectedIndex = 0;
            teacherActionPage.Size = new System.Drawing.Size(936, 603);
            teacherActionPage.TabIndex = 1;
            // 
            // AllQuizTab
            // 
            AllQuizTab.Controls.Add(addQuestionsPanel);
            AllQuizTab.Controls.Add(editQuestionPanel);
            AllQuizTab.Controls.Add(viewQuizesPanel);
            AllQuizTab.Location = new System.Drawing.Point(4, 24);
            AllQuizTab.Name = "AllQuizTab";
            AllQuizTab.Padding = new System.Windows.Forms.Padding(3);
            AllQuizTab.Size = new System.Drawing.Size(928, 575);
            AllQuizTab.TabIndex = 0;
            AllQuizTab.Text = "quiz";
            AllQuizTab.UseVisualStyleBackColor = true;
            AllQuizTab.Click += tabPage1_Click;
            // 
            // addQuestionsPanel
            // 
            addQuestionsPanel.Controls.Add(panel5);
            addQuestionsPanel.Controls.Add(label14);
            addQuestionsPanel.Location = new System.Drawing.Point(0, 0);
            addQuestionsPanel.Name = "addQuestionsPanel";
            addQuestionsPanel.Size = new System.Drawing.Size(922, 560);
            addQuestionsPanel.TabIndex = 13;
            addQuestionsPanel.Visible = false;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.DarkGray;
            panel5.Controls.Add(button5);
            panel5.Controls.Add(saveBtn);
            panel5.Controls.Add(trueFalsePanel);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(multpleChoosePanel);
            panel5.Controls.Add(txtQuestionText);
            panel5.Controls.Add(questionType);
            panel5.Controls.Add(label22);
            panel5.Controls.Add(label20);
            panel5.Controls.Add(label15);
            panel5.Location = new System.Drawing.Point(102, 57);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(636, 389);
            panel5.TabIndex = 8;
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.Color.Red;
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button5.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button5.ForeColor = System.Drawing.SystemColors.Control;
            button5.Image = (System.Drawing.Image)resources.GetObject("button5.Image");
            button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button5.Location = new System.Drawing.Point(312, 285);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(116, 38);
            button5.TabIndex = 18;
            button5.Text = "Cancel";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = System.Drawing.Color.FromArgb(0, 153, 255);
            saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            saveBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            saveBtn.ForeColor = System.Drawing.SystemColors.Control;
            saveBtn.Image = (System.Drawing.Image)resources.GetObject("saveBtn.Image");
            saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            saveBtn.Location = new System.Drawing.Point(105, 285);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new System.Drawing.Size(164, 38);
            saveBtn.TabIndex = 17;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += button3_Click_1;
            // 
            // trueFalsePanel
            // 
            trueFalsePanel.Controls.Add(rbFalse);
            trueFalsePanel.Controls.Add(rbTrue);
            trueFalsePanel.Location = new System.Drawing.Point(324, 67);
            trueFalsePanel.Name = "trueFalsePanel";
            trueFalsePanel.Size = new System.Drawing.Size(256, 170);
            trueFalsePanel.TabIndex = 9;
            trueFalsePanel.Visible = false;
            // 
            // rbFalse
            // 
            rbFalse.AutoSize = true;
            rbFalse.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbFalse.Location = new System.Drawing.Point(128, 31);
            rbFalse.Name = "rbFalse";
            rbFalse.Size = new System.Drawing.Size(72, 30);
            rbFalse.TabIndex = 6;
            rbFalse.TabStop = true;
            rbFalse.Text = "False";
            rbFalse.UseVisualStyleBackColor = true;
            rbFalse.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // rbTrue
            // 
            rbTrue.AutoSize = true;
            rbTrue.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbTrue.Location = new System.Drawing.Point(26, 30);
            rbTrue.Name = "rbTrue";
            rbTrue.Size = new System.Drawing.Size(68, 30);
            rbTrue.TabIndex = 5;
            rbTrue.TabStop = true;
            rbTrue.Text = "True";
            rbTrue.UseVisualStyleBackColor = true;
            rbTrue.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label16.Location = new System.Drawing.Point(185, 146);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(20, 21);
            label16.TabIndex = 16;
            label16.Text = "A";
            // 
            // multpleChoosePanel
            // 
            multpleChoosePanel.Controls.Add(txtOptionD);
            multpleChoosePanel.Controls.Add(txtOptionB);
            multpleChoosePanel.Controls.Add(txtOptionC);
            multpleChoosePanel.Controls.Add(txtOptionA);
            multpleChoosePanel.Controls.Add(rbOptionD);
            multpleChoosePanel.Controls.Add(rbOptionC);
            multpleChoosePanel.Controls.Add(rbOptionB);
            multpleChoosePanel.Controls.Add(rbOptionA);
            multpleChoosePanel.Location = new System.Drawing.Point(327, 67);
            multpleChoosePanel.Name = "multpleChoosePanel";
            multpleChoosePanel.Size = new System.Drawing.Size(253, 173);
            multpleChoosePanel.TabIndex = 15;
            multpleChoosePanel.Visible = false;
            // 
            // txtOptionD
            // 
            txtOptionD.Location = new System.Drawing.Point(49, 128);
            txtOptionD.Name = "txtOptionD";
            txtOptionD.Size = new System.Drawing.Size(142, 23);
            txtOptionD.TabIndex = 8;
            // 
            // txtOptionB
            // 
            txtOptionB.Location = new System.Drawing.Point(49, 56);
            txtOptionB.Name = "txtOptionB";
            txtOptionB.Size = new System.Drawing.Size(142, 23);
            txtOptionB.TabIndex = 7;
            // 
            // txtOptionC
            // 
            txtOptionC.Location = new System.Drawing.Point(49, 92);
            txtOptionC.Name = "txtOptionC";
            txtOptionC.Size = new System.Drawing.Size(142, 23);
            txtOptionC.TabIndex = 6;
            txtOptionC.TextChanged += textBox4_TextChanged;
            // 
            // txtOptionA
            // 
            txtOptionA.Location = new System.Drawing.Point(49, 19);
            txtOptionA.Name = "txtOptionA";
            txtOptionA.Size = new System.Drawing.Size(142, 23);
            txtOptionA.TabIndex = 5;
            // 
            // rbOptionD
            // 
            rbOptionD.AutoSize = true;
            rbOptionD.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbOptionD.Location = new System.Drawing.Point(3, 121);
            rbOptionD.Name = "rbOptionD";
            rbOptionD.Size = new System.Drawing.Size(43, 30);
            rbOptionD.TabIndex = 4;
            rbOptionD.TabStop = true;
            rbOptionD.Text = "D";
            rbOptionD.UseVisualStyleBackColor = true;
            // 
            // rbOptionC
            // 
            rbOptionC.AutoSize = true;
            rbOptionC.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbOptionC.Location = new System.Drawing.Point(3, 85);
            rbOptionC.Name = "rbOptionC";
            rbOptionC.Size = new System.Drawing.Size(42, 30);
            rbOptionC.TabIndex = 3;
            rbOptionC.TabStop = true;
            rbOptionC.Text = "C";
            rbOptionC.UseVisualStyleBackColor = true;
            // 
            // rbOptionB
            // 
            rbOptionB.AutoSize = true;
            rbOptionB.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbOptionB.Location = new System.Drawing.Point(3, 49);
            rbOptionB.Name = "rbOptionB";
            rbOptionB.Size = new System.Drawing.Size(41, 30);
            rbOptionB.TabIndex = 1;
            rbOptionB.TabStop = true;
            rbOptionB.Text = "B";
            rbOptionB.UseVisualStyleBackColor = true;
            // 
            // rbOptionA
            // 
            rbOptionA.AutoSize = true;
            rbOptionA.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            rbOptionA.Location = new System.Drawing.Point(3, 13);
            rbOptionA.Name = "rbOptionA";
            rbOptionA.Size = new System.Drawing.Size(42, 30);
            rbOptionA.TabIndex = 0;
            rbOptionA.TabStop = true;
            rbOptionA.Text = "A";
            rbOptionA.UseVisualStyleBackColor = true;
            // 
            // txtQuestionText
            // 
            txtQuestionText.Location = new System.Drawing.Point(185, 30);
            txtQuestionText.Name = "txtQuestionText";
            txtQuestionText.Size = new System.Drawing.Size(342, 23);
            txtQuestionText.TabIndex = 13;
            // 
            // questionType
            // 
            questionType.FormattingEnabled = true;
            questionType.Items.AddRange(new object[] { "TrueFalse", "MultipleChoice" });
            questionType.Location = new System.Drawing.Point(185, 88);
            questionType.Name = "questionType";
            questionType.Size = new System.Drawing.Size(117, 23);
            questionType.TabIndex = 12;
            questionType.SelectedIndexChanged += questionType_SelectedIndexChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label22.Location = new System.Drawing.Point(45, 86);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(121, 21);
            label22.TabIndex = 11;
            label22.Text = "Question Type : ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label20.Location = new System.Drawing.Point(45, 146);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(117, 21);
            label20.TabIndex = 9;
            label20.Text = "Correct Answer";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label15.Location = new System.Drawing.Point(45, 28);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(105, 21);
            label15.TabIndex = 4;
            label15.Text = "Question Text";
            label15.Click += label15_Click;
            // 
            // label14
            // 
            label14.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label14.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            label14.Location = new System.Drawing.Point(227, 13);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(393, 41);
            label14.TabIndex = 3;
            label14.Text = "Adding Questions to Quiz";
            label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label14.Click += label14_Click;
            // 
            // editQuestionPanel
            // 
            editQuestionPanel.Controls.Add(button4);
            editQuestionPanel.Controls.Add(panel6);
            editQuestionPanel.Controls.Add(label9);
            editQuestionPanel.Location = new System.Drawing.Point(0, 12);
            editQuestionPanel.Name = "editQuestionPanel";
            editQuestionPanel.Size = new System.Drawing.Size(925, 557);
            editQuestionPanel.TabIndex = 1;
            editQuestionPanel.Visible = false;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.FromArgb(0, 153, 255);
            button4.Image = (System.Drawing.Image)resources.GetObject("button4.Image");
            button4.Location = new System.Drawing.Point(19, 14);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(33, 32);
            button4.TabIndex = 12;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel6
            // 
            panel6.BackColor = System.Drawing.Color.DarkGray;
            panel6.Controls.Add(applyEdit);
            panel6.Controls.Add(txtTitle);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(txtTotalQuestions);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(txtTimeLimit);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(txtDescription);
            panel6.Controls.Add(label10);
            panel6.Location = new System.Drawing.Point(166, 63);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(516, 367);
            panel6.TabIndex = 11;
            // 
            // applyEdit
            // 
            applyEdit.BackColor = System.Drawing.Color.FromArgb(0, 153, 255);
            applyEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            applyEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            applyEdit.ForeColor = System.Drawing.SystemColors.Control;
            applyEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            applyEdit.Location = new System.Drawing.Point(184, 277);
            applyEdit.MaximumSize = new System.Drawing.Size(194, 38);
            applyEdit.Name = "applyEdit";
            applyEdit.Size = new System.Drawing.Size(164, 38);
            applyEdit.TabIndex = 11;
            applyEdit.Text = "Apply";
            applyEdit.UseVisualStyleBackColor = false;
            applyEdit.Click += applyEdit_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new System.Drawing.Point(289, 38);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new System.Drawing.Size(123, 23);
            txtTitle.TabIndex = 7;
            // 
            // label13
            // 
            label13.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label13.Location = new System.Drawing.Point(76, 214);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(146, 23);
            label13.TabIndex = 6;
            label13.Text = "Total Question :";
            // 
            // txtTotalQuestions
            // 
            txtTotalQuestions.Location = new System.Drawing.Point(289, 214);
            txtTotalQuestions.Name = "txtTotalQuestions";
            txtTotalQuestions.Size = new System.Drawing.Size(123, 23);
            txtTotalQuestions.TabIndex = 8;
            txtTotalQuestions.KeyPress += txtTotalQuestions_KeyPress;
            // 
            // label12
            // 
            label12.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label12.Location = new System.Drawing.Point(76, 149);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(100, 23);
            label12.TabIndex = 5;
            label12.Text = "Time Limit";
            // 
            // txtTimeLimit
            // 
            txtTimeLimit.Location = new System.Drawing.Point(289, 149);
            txtTimeLimit.Name = "txtTimeLimit";
            txtTimeLimit.Size = new System.Drawing.Size(123, 23);
            txtTimeLimit.TabIndex = 9;
            txtTimeLimit.KeyPress += txtTimeLimit_KeyPress;
            // 
            // label11
            // 
            label11.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label11.Location = new System.Drawing.Point(76, 87);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(129, 32);
            label11.TabIndex = 4;
            label11.Text = "Description :";
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(289, 87);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(123, 23);
            txtDescription.TabIndex = 10;
            // 
            // label10
            // 
            label10.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.Location = new System.Drawing.Point(76, 38);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(100, 23);
            label10.TabIndex = 3;
            label10.Text = "Title :";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            label9.Location = new System.Drawing.Point(227, 5);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(393, 41);
            label9.TabIndex = 2;
            label9.Text = "Edit Quiz";
            label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // viewQuizesPanel
            // 
            viewQuizesPanel.Controls.Add(button2);
            viewQuizesPanel.Controls.Add(label6);
            viewQuizesPanel.Controls.Add(quizDataGridView);
            viewQuizesPanel.Location = new System.Drawing.Point(3, 9);
            viewQuizesPanel.Name = "viewQuizesPanel";
            viewQuizesPanel.Size = new System.Drawing.Size(922, 563);
            viewQuizesPanel.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(0, 153, 255);
            button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
            button2.Location = new System.Drawing.Point(769, 16);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(35, 33);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_2;
            // 
            // label6
            // 
            label6.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            label6.Location = new System.Drawing.Point(163, 18);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(412, 45);
            label6.TabIndex = 1;
            label6.Text = "All Avaliable quizes";
            label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // quizDataGridView
            // 
            quizDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            quizDataGridView.Location = new System.Drawing.Point(40, 66);
            quizDataGridView.Name = "quizDataGridView";
            quizDataGridView.Size = new System.Drawing.Size(879, 404);
            quizDataGridView.TabIndex = 0;
            quizDataGridView.CellClick += quizDataGridView_CellClick;
            // 
            // myQuizTab
            // 
            myQuizTab.Controls.Add(addQuizPanel);
            myQuizTab.Controls.Add(btnPanel);
            myQuizTab.Location = new System.Drawing.Point(4, 24);
            myQuizTab.Name = "myQuizTab";
            myQuizTab.Padding = new System.Windows.Forms.Padding(3);
            myQuizTab.Size = new System.Drawing.Size(928, 575);
            myQuizTab.TabIndex = 1;
            myQuizTab.Text = "tabPage2";
            myQuizTab.UseVisualStyleBackColor = true;
            // 
            // addQuizPanel
            // 
            addQuizPanel.Controls.Add(panel4);
            addQuizPanel.Controls.Add(label3);
            addQuizPanel.Location = new System.Drawing.Point(0, 102);
            addQuizPanel.Name = "addQuizPanel";
            addQuizPanel.Size = new System.Drawing.Size(929, 467);
            addQuizPanel.TabIndex = 2;
            addQuizPanel.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.Silver;
            panel4.Controls.Add(totallQuestionsBox);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(quizDescBox);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(timeBox);
            panel4.Controls.Add(quizTitleBox);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(button1);
            panel4.Location = new System.Drawing.Point(188, 40);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(455, 300);
            panel4.TabIndex = 1;
            // 
            // totallQuestionsBox
            // 
            totallQuestionsBox.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            totallQuestionsBox.Location = new System.Drawing.Point(171, 176);
            totallQuestionsBox.Name = "totallQuestionsBox";
            totallQuestionsBox.Size = new System.Drawing.Size(68, 23);
            totallQuestionsBox.TabIndex = 13;
            totallQuestionsBox.KeyPress += textBox2_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(43, 179);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(113, 20);
            label8.TabIndex = 12;
            label8.Text = "Total questions:";
            // 
            // quizDescBox
            // 
            quizDescBox.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            quizDescBox.Location = new System.Drawing.Point(171, 89);
            quizDescBox.Name = "quizDescBox";
            quizDescBox.Size = new System.Drawing.Size(149, 23);
            quizDescBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(43, 131);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(79, 20);
            label5.TabIndex = 10;
            label5.Text = "Time Limit";
            // 
            // timeBox
            // 
            timeBox.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            timeBox.Location = new System.Drawing.Point(171, 131);
            timeBox.Name = "timeBox";
            timeBox.Size = new System.Drawing.Size(68, 23);
            timeBox.TabIndex = 8;
            timeBox.TextChanged += lastNameBox_TextChanged;
            timeBox.KeyPress += lastNameBox_KeyPress;
            // 
            // quizTitleBox
            // 
            quizTitleBox.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            quizTitleBox.Location = new System.Drawing.Point(171, 40);
            quizTitleBox.Name = "quizTitleBox";
            quizTitleBox.Size = new System.Drawing.Size(149, 23);
            quizTitleBox.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(43, 88);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(92, 20);
            label7.TabIndex = 5;
            label7.Text = "Description :";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(43, 39);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(75, 20);
            label4.TabIndex = 2;
            label4.Text = "Quiz Title:";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(0, 153, 255);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.SystemColors.Control;
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            button1.Location = new System.Drawing.Point(178, 220);
            button1.Margin = new System.Windows.Forms.Padding(2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(77, 30);
            button1.TabIndex = 1;
            button1.Text = "Add ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            label3.Location = new System.Drawing.Point(250, 7);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(193, 30);
            label3.TabIndex = 0;
            label3.Text = "Adding A new Quiz";
            // 
            // btnPanel
            // 
            btnPanel.BackColor = System.Drawing.Color.Silver;
            btnPanel.Controls.Add(addTeacherBtn);
            btnPanel.Location = new System.Drawing.Point(0, 12);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new System.Drawing.Size(922, 88);
            btnPanel.TabIndex = 0;
            // 
            // addTeacherBtn
            // 
            addTeacherBtn.BackColor = System.Drawing.Color.FromArgb(0, 153, 255);
            addTeacherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addTeacherBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            addTeacherBtn.ForeColor = System.Drawing.SystemColors.Control;
            addTeacherBtn.Image = (System.Drawing.Image)resources.GetObject("addTeacherBtn.Image");
            addTeacherBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            addTeacherBtn.Location = new System.Drawing.Point(5, 10);
            addTeacherBtn.Margin = new System.Windows.Forms.Padding(2);
            addTeacherBtn.Name = "addTeacherBtn";
            addTeacherBtn.Size = new System.Drawing.Size(152, 30);
            addTeacherBtn.TabIndex = 0;
            addTeacherBtn.Text = "Add Quiz";
            addTeacherBtn.UseVisualStyleBackColor = false;
            addTeacherBtn.Click += addTeacherBtn_Click;
            // 
            // tabPage3
            // 
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(928, 575);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new System.Drawing.Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(3);
            tabPage4.Size = new System.Drawing.Size(928, 575);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new System.Drawing.Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new System.Windows.Forms.Padding(3);
            tabPage5.Size = new System.Drawing.Size(928, 575);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // teacherPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1145, 576);
            Controls.Add(teacherActionPage);
            Controls.Add(sideBar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "teacherPage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "adminPage";
            Load += adminPage_Load_2;
            sideBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuBtn).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            teacherActionPage.ResumeLayout(false);
            AllQuizTab.ResumeLayout(false);
            addQuestionsPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            trueFalsePanel.ResumeLayout(false);
            trueFalsePanel.PerformLayout();
            multpleChoosePanel.ResumeLayout(false);
            multpleChoosePanel.PerformLayout();
            editQuestionPanel.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            viewQuizesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)quizDataGridView).EndInit();
            myQuizTab.ResumeLayout(false);
            addQuizPanel.ResumeLayout(false);
            addQuizPanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            btnPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion


        public teacherPage(User user)
        {
            InitializeComponent();
            this.userAdmin = user; // Assign to the class-level variable

            // Use the User object to customize the form
            LoadUserData(userAdmin);
        }

        // Method to load user data into the form
        private void LoadUserData(User userAdmin)
        {
            if (userAdmin != null)
            {
                this.Text = $"Admin, {userAdmin.FirstName} {userAdmin.LastName}";
                usrLabel.Text = $"Welcome, {userAdmin.FirstName} {userAdmin.LastName}";
            }
        }

        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button allQuizBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button teacherBtn;
        private System.Windows.Forms.Button studentBtn;
        private System.Windows.Forms.Button msgBtn;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox menuBtn;
        private System.Windows.Forms.Label menulabel;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.TabControl teacherActionPage;
        private System.Windows.Forms.TabPage AllQuizTab;
        private System.Windows.Forms.TabPage myQuizTab;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label usrLabel;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button addTeacherBtn;
        private System.Windows.Forms.Panel addQuizPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox quizTitleBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totallQuestionsBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox quizDescBox;
        private System.Windows.Forms.Panel viewQuizesPanel;
        private System.Windows.Forms.DataGridView quizDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel editQuestionPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotalQuestions;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTimeLimit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button applyEdit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel addQuestionsPanel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtQuestionText;
        private System.Windows.Forms.ComboBox questionType;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel multpleChoosePanel;
        private System.Windows.Forms.RadioButton rbOptionD;
        private System.Windows.Forms.RadioButton rbOptionC;
        private System.Windows.Forms.RadioButton rbOptionB;
        private System.Windows.Forms.RadioButton rbOptionA;
        private System.Windows.Forms.TextBox txtOptionB;
        private System.Windows.Forms.TextBox txtOptionC;
        private System.Windows.Forms.TextBox txtOptionA;
        private System.Windows.Forms.TextBox txtOptionD;
        private System.Windows.Forms.Panel trueFalsePanel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbFalse;
        private System.Windows.Forms.RadioButton rbTrue;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button saveBtn;
    }
}