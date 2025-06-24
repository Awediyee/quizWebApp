using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;

namespace quizSystem
{
    partial class adminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPage));
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
            adminActionPage = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            pendingQuizPanel = new System.Windows.Forms.Panel();
            pendingQuizGrid = new System.Windows.Forms.DataGridView();
            button2 = new System.Windows.Forms.Button();
            teacherTab = new System.Windows.Forms.TabPage();
            showTeacherPanel = new System.Windows.Forms.Panel();
            teacherDataGridView = new System.Windows.Forms.DataGridView();
            editPanel = new System.Windows.Forms.Panel();
            editUsernameBox = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            editRoleComboBox = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            editComboBox = new System.Windows.Forms.ComboBox();
            label33 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            editLnameBox = new System.Windows.Forms.TextBox();
            editFnameBox = new System.Windows.Forms.TextBox();
            addTeacherPanel = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            departmentComboBox = new System.Windows.Forms.ComboBox();
            lastNameBox = new System.Windows.Forms.TextBox();
            firtsNameBox = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            techAddBtn = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            btnPanel = new System.Windows.Forms.Panel();
            showTeachersBtn = new System.Windows.Forms.Button();
            addTeacherBtn = new System.Windows.Forms.Button();
            studentTab = new System.Windows.Forms.TabPage();
            panel5 = new System.Windows.Forms.Panel();
            showStudentBtn = new System.Windows.Forms.Button();
            addStudentBtn = new System.Windows.Forms.Button();
            studentAddPanel = new System.Windows.Forms.Panel();
            panell = new System.Windows.Forms.Panel();
            studentComboBox = new System.Windows.Forms.ComboBox();
            studentLnameBox = new System.Windows.Forms.TextBox();
            studentFnameBox = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            stdAddBtn = new System.Windows.Forms.Button();
            label10 = new System.Windows.Forms.Label();
            studentShowPanel = new System.Windows.Forms.Panel();
            StudentDataGridView = new System.Windows.Forms.DataGridView();
            sEditPanel = new System.Windows.Forms.Panel();
            tDeletePanel = new System.Windows.Forms.Panel();
            tabPage4 = new System.Windows.Forms.TabPage();
            tabPage5 = new System.Windows.Forms.TabPage();
            sideBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuBtn).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            adminActionPage.SuspendLayout();
            tabPage1.SuspendLayout();
            pendingQuizPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pendingQuizGrid).BeginInit();
            teacherTab.SuspendLayout();
            showTeacherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teacherDataGridView).BeginInit();
            editPanel.SuspendLayout();
            addTeacherPanel.SuspendLayout();
            panel4.SuspendLayout();
            btnPanel.SuspendLayout();
            studentTab.SuspendLayout();
            panel5.SuspendLayout();
            studentAddPanel.SuspendLayout();
            panell.SuspendLayout();
            studentShowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentDataGridView).BeginInit();
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
            teacherBtn.Text = "Teachers";
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
            // adminActionPage
            // 
            adminActionPage.Controls.Add(tabPage1);
            adminActionPage.Controls.Add(teacherTab);
            adminActionPage.Controls.Add(studentTab);
            adminActionPage.Controls.Add(tabPage4);
            adminActionPage.Controls.Add(tabPage5);
            adminActionPage.Location = new System.Drawing.Point(207, -30);
            adminActionPage.Name = "adminActionPage";
            adminActionPage.SelectedIndex = 0;
            adminActionPage.Size = new System.Drawing.Size(936, 603);
            adminActionPage.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pendingQuizPanel);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(928, 575);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "quiz";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // pendingQuizPanel
            // 
            pendingQuizPanel.Controls.Add(pendingQuizGrid);
            pendingQuizPanel.Controls.Add(button2);
            pendingQuizPanel.Location = new System.Drawing.Point(6, 18);
            pendingQuizPanel.Name = "pendingQuizPanel";
            pendingQuizPanel.Size = new System.Drawing.Size(916, 551);
            pendingQuizPanel.TabIndex = 0;
            pendingQuizPanel.Paint += panel6_Paint;
            // 
            // pendingQuizGrid
            // 
            pendingQuizGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pendingQuizGrid.Location = new System.Drawing.Point(13, 66);
            pendingQuizGrid.Name = "pendingQuizGrid";
            pendingQuizGrid.Size = new System.Drawing.Size(669, 272);
            pendingQuizGrid.TabIndex = 3;
            pendingQuizGrid.Visible = false;
            pendingQuizGrid.CellClick += pendingQuizGrid_CellClick;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(0, 153, 255);
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.ForeColor = System.Drawing.SystemColors.Control;
            button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
            button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button2.Location = new System.Drawing.Point(13, 7);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(194, 38);
            button2.TabIndex = 2;
            button2.Text = "Approve All Quiz";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_2;
            // 
            // teacherTab
            // 
            teacherTab.Controls.Add(showTeacherPanel);
            teacherTab.Controls.Add(addTeacherPanel);
            teacherTab.Controls.Add(btnPanel);
            teacherTab.Location = new System.Drawing.Point(4, 24);
            teacherTab.Name = "teacherTab";
            teacherTab.Padding = new System.Windows.Forms.Padding(3);
            teacherTab.Size = new System.Drawing.Size(928, 575);
            teacherTab.TabIndex = 1;
            teacherTab.Text = "tabPage2";
            teacherTab.UseVisualStyleBackColor = true;
            // 
            // showTeacherPanel
            // 
            showTeacherPanel.Controls.Add(teacherDataGridView);
            showTeacherPanel.Controls.Add(editPanel);
            showTeacherPanel.Location = new System.Drawing.Point(0, 99);
            showTeacherPanel.Name = "showTeacherPanel";
            showTeacherPanel.Size = new System.Drawing.Size(922, 476);
            showTeacherPanel.TabIndex = 1;
            showTeacherPanel.Visible = false;
            // 
            // teacherDataGridView
            // 
            teacherDataGridView.AllowUserToAddRows = false;
            teacherDataGridView.AllowUserToDeleteRows = false;
            teacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teacherDataGridView.Location = new System.Drawing.Point(5, 7);
            teacherDataGridView.Name = "teacherDataGridView";
            teacherDataGridView.ReadOnly = true;
            teacherDataGridView.Size = new System.Drawing.Size(601, 463);
            teacherDataGridView.TabIndex = 1;
            teacherDataGridView.CellContentClick += dataGridView1_CellContentClick;
            teacherDataGridView.Click += teacherDataGridView_Click;
            // 
            // editPanel
            // 
            editPanel.Controls.Add(editUsernameBox);
            editPanel.Controls.Add(label14);
            editPanel.Controls.Add(label13);
            editPanel.Controls.Add(editRoleComboBox);
            editPanel.Controls.Add(button1);
            editPanel.Controls.Add(editComboBox);
            editPanel.Controls.Add(label33);
            editPanel.Controls.Add(label12);
            editPanel.Controls.Add(label11);
            editPanel.Controls.Add(editLnameBox);
            editPanel.Controls.Add(editFnameBox);
            editPanel.Location = new System.Drawing.Point(612, 3);
            editPanel.Name = "editPanel";
            editPanel.Size = new System.Drawing.Size(307, 370);
            editPanel.TabIndex = 0;
            editPanel.Visible = false;
            // 
            // editUsernameBox
            // 
            editUsernameBox.Enabled = false;
            editUsernameBox.Location = new System.Drawing.Point(153, 31);
            editUsernameBox.Name = "editUsernameBox";
            editUsernameBox.Size = new System.Drawing.Size(100, 23);
            editUsernameBox.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(52, 223);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(30, 15);
            label14.TabIndex = 9;
            label14.Text = "Role";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(44, 31);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(60, 15);
            label13.TabIndex = 8;
            label13.Text = "Username";
            // 
            // editRoleComboBox
            // 
            editRoleComboBox.Enabled = false;
            editRoleComboBox.FormattingEnabled = true;
            editRoleComboBox.Items.AddRange(new object[] { "Teacher", "Student" });
            editRoleComboBox.Location = new System.Drawing.Point(137, 225);
            editRoleComboBox.Name = "editRoleComboBox";
            editRoleComboBox.Size = new System.Drawing.Size(113, 23);
            editRoleComboBox.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(140, 287);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // editComboBox
            // 
            editComboBox.FormattingEnabled = true;
            editComboBox.Items.AddRange(new object[] { "Computer Science", "Marketing", "Accounting", "Managment" });
            editComboBox.Location = new System.Drawing.Point(137, 172);
            editComboBox.Name = "editComboBox";
            editComboBox.Size = new System.Drawing.Size(113, 23);
            editComboBox.TabIndex = 5;
            editComboBox.SelectedIndexChanged += editComboBox_SelectedIndexChanged;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new System.Drawing.Point(38, 175);
            label33.Name = "label33";
            label33.Size = new System.Drawing.Size(70, 15);
            label33.TabIndex = 4;
            label33.Text = "Department";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(39, 131);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(63, 15);
            label12.TabIndex = 3;
            label12.Text = "Last Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(38, 87);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(64, 15);
            label11.TabIndex = 2;
            label11.Text = "First Name";
            // 
            // editLnameBox
            // 
            editLnameBox.Location = new System.Drawing.Point(137, 128);
            editLnameBox.Name = "editLnameBox";
            editLnameBox.Size = new System.Drawing.Size(113, 23);
            editLnameBox.TabIndex = 1;
            // 
            // editFnameBox
            // 
            editFnameBox.Location = new System.Drawing.Point(137, 84);
            editFnameBox.Name = "editFnameBox";
            editFnameBox.Size = new System.Drawing.Size(113, 23);
            editFnameBox.TabIndex = 0;
            // 
            // addTeacherPanel
            // 
            addTeacherPanel.Controls.Add(panel4);
            addTeacherPanel.Controls.Add(label3);
            addTeacherPanel.Location = new System.Drawing.Point(0, 106);
            addTeacherPanel.Name = "addTeacherPanel";
            addTeacherPanel.Size = new System.Drawing.Size(929, 463);
            addTeacherPanel.TabIndex = 2;
            addTeacherPanel.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.Silver;
            panel4.Controls.Add(departmentComboBox);
            panel4.Controls.Add(lastNameBox);
            panel4.Controls.Add(firtsNameBox);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(techAddBtn);
            panel4.Location = new System.Drawing.Point(250, 69);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(455, 275);
            panel4.TabIndex = 1;
            // 
            // departmentComboBox
            // 
            departmentComboBox.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Items.AddRange(new object[] { "Computer Science", "Marketing", "Accounting", "Managment" });
            departmentComboBox.Location = new System.Drawing.Point(171, 124);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new System.Drawing.Size(149, 23);
            departmentComboBox.TabIndex = 9;
            // 
            // lastNameBox
            // 
            lastNameBox.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            lastNameBox.Location = new System.Drawing.Point(171, 88);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new System.Drawing.Size(149, 23);
            lastNameBox.TabIndex = 8;
            // 
            // firtsNameBox
            // 
            firtsNameBox.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            firtsNameBox.Location = new System.Drawing.Point(171, 40);
            firtsNameBox.Name = "firtsNameBox";
            firtsNameBox.Size = new System.Drawing.Size(149, 23);
            firtsNameBox.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(71, 88);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(86, 20);
            label7.TabIndex = 5;
            label7.Text = "Last Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(71, 132);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(89, 20);
            label6.TabIndex = 4;
            label6.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(70, 40);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 20);
            label4.TabIndex = 2;
            label4.Text = "First Name :";
            // 
            // techAddBtn
            // 
            techAddBtn.BackColor = System.Drawing.Color.FromArgb(0, 153, 255);
            techAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            techAddBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            techAddBtn.ForeColor = System.Drawing.SystemColors.Control;
            techAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            techAddBtn.Location = new System.Drawing.Point(204, 176);
            techAddBtn.Margin = new System.Windows.Forms.Padding(2);
            techAddBtn.Name = "techAddBtn";
            techAddBtn.Size = new System.Drawing.Size(77, 30);
            techAddBtn.TabIndex = 1;
            techAddBtn.Text = "Add ";
            techAddBtn.UseVisualStyleBackColor = false;
            techAddBtn.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            label3.Location = new System.Drawing.Point(250, 7);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(223, 30);
            label3.TabIndex = 0;
            label3.Text = "Adding A new Teacher";
            // 
            // btnPanel
            // 
            btnPanel.BackColor = System.Drawing.Color.Silver;
            btnPanel.Controls.Add(showTeachersBtn);
            btnPanel.Controls.Add(addTeacherBtn);
            btnPanel.Location = new System.Drawing.Point(0, 12);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new System.Drawing.Size(922, 88);
            btnPanel.TabIndex = 0;
            // 
            // showTeachersBtn
            // 
            showTeachersBtn.BackColor = System.Drawing.Color.FromArgb(0, 153, 255);
            showTeachersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            showTeachersBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            showTeachersBtn.ForeColor = System.Drawing.SystemColors.Control;
            showTeachersBtn.Image = (System.Drawing.Image)resources.GetObject("showTeachersBtn.Image");
            showTeachersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            showTeachersBtn.Location = new System.Drawing.Point(2, 45);
            showTeachersBtn.Margin = new System.Windows.Forms.Padding(2);
            showTeachersBtn.Name = "showTeachersBtn";
            showTeachersBtn.Size = new System.Drawing.Size(170, 37);
            showTeachersBtn.TabIndex = 2;
            showTeachersBtn.Text = "Show Teachers";
            showTeachersBtn.UseVisualStyleBackColor = false;
            showTeachersBtn.Click += showTeachersBtn_Click;
            // 
            // addTeacherBtn
            // 
            addTeacherBtn.BackColor = System.Drawing.Color.FromArgb(0, 153, 255);
            addTeacherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addTeacherBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            addTeacherBtn.ForeColor = System.Drawing.SystemColors.Control;
            addTeacherBtn.Image = (System.Drawing.Image)resources.GetObject("addTeacherBtn.Image");
            addTeacherBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            addTeacherBtn.Location = new System.Drawing.Point(5, 5);
            addTeacherBtn.Margin = new System.Windows.Forms.Padding(2);
            addTeacherBtn.Name = "addTeacherBtn";
            addTeacherBtn.Size = new System.Drawing.Size(152, 30);
            addTeacherBtn.TabIndex = 0;
            addTeacherBtn.Text = "Add Teacher";
            addTeacherBtn.UseVisualStyleBackColor = false;
            addTeacherBtn.Click += addTeacherBtn_Click;
            // 
            // studentTab
            // 
            studentTab.Controls.Add(panel5);
            studentTab.Controls.Add(studentAddPanel);
            studentTab.Controls.Add(studentShowPanel);
            studentTab.Location = new System.Drawing.Point(4, 24);
            studentTab.Name = "studentTab";
            studentTab.Padding = new System.Windows.Forms.Padding(3);
            studentTab.Size = new System.Drawing.Size(928, 575);
            studentTab.TabIndex = 2;
            studentTab.Text = "tabPage3";
            studentTab.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.Silver;
            panel5.Controls.Add(showStudentBtn);
            panel5.Controls.Add(addStudentBtn);
            panel5.Location = new System.Drawing.Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(922, 102);
            panel5.TabIndex = 4;
            // 
            // showStudentBtn
            // 
            showStudentBtn.BackColor = System.Drawing.Color.FromArgb(0, 153, 255);
            showStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            showStudentBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            showStudentBtn.ForeColor = System.Drawing.SystemColors.Control;
            showStudentBtn.Image = (System.Drawing.Image)resources.GetObject("showStudentBtn.Image");
            showStudentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            showStudentBtn.Location = new System.Drawing.Point(5, 57);
            showStudentBtn.Margin = new System.Windows.Forms.Padding(2);
            showStudentBtn.Name = "showStudentBtn";
            showStudentBtn.Size = new System.Drawing.Size(170, 37);
            showStudentBtn.TabIndex = 2;
            showStudentBtn.Text = "Show Students";
            showStudentBtn.UseVisualStyleBackColor = false;
            showStudentBtn.Click += showStudentBtn_Click;
            // 
            // addStudentBtn
            // 
            addStudentBtn.BackColor = System.Drawing.Color.FromArgb(0, 153, 255);
            addStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addStudentBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            addStudentBtn.ForeColor = System.Drawing.SystemColors.Control;
            addStudentBtn.Image = (System.Drawing.Image)resources.GetObject("addStudentBtn.Image");
            addStudentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            addStudentBtn.Location = new System.Drawing.Point(5, 18);
            addStudentBtn.Margin = new System.Windows.Forms.Padding(2);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new System.Drawing.Size(152, 30);
            addStudentBtn.TabIndex = 0;
            addStudentBtn.Text = "Add Student";
            addStudentBtn.UseVisualStyleBackColor = false;
            addStudentBtn.Click += addStudentBtn_Click_1;
            // 
            // studentAddPanel
            // 
            studentAddPanel.Controls.Add(panell);
            studentAddPanel.Controls.Add(label10);
            studentAddPanel.Location = new System.Drawing.Point(0, 108);
            studentAddPanel.Name = "studentAddPanel";
            studentAddPanel.Size = new System.Drawing.Size(929, 464);
            studentAddPanel.TabIndex = 3;
            studentAddPanel.Visible = false;
            // 
            // panell
            // 
            panell.BackColor = System.Drawing.Color.Silver;
            panell.Controls.Add(studentComboBox);
            panell.Controls.Add(studentLnameBox);
            panell.Controls.Add(studentFnameBox);
            panell.Controls.Add(label5);
            panell.Controls.Add(label8);
            panell.Controls.Add(label9);
            panell.Controls.Add(stdAddBtn);
            panell.Location = new System.Drawing.Point(250, 69);
            panell.Name = "panell";
            panell.Size = new System.Drawing.Size(455, 275);
            panell.TabIndex = 1;
            // 
            // studentComboBox
            // 
            studentComboBox.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            studentComboBox.FormattingEnabled = true;
            studentComboBox.Items.AddRange(new object[] { "Computer Science", "Marketing", "Accounting", "Managment" });
            studentComboBox.Location = new System.Drawing.Point(171, 124);
            studentComboBox.Name = "studentComboBox";
            studentComboBox.Size = new System.Drawing.Size(149, 23);
            studentComboBox.TabIndex = 9;
            // 
            // studentLnameBox
            // 
            studentLnameBox.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            studentLnameBox.Location = new System.Drawing.Point(171, 88);
            studentLnameBox.Name = "studentLnameBox";
            studentLnameBox.Size = new System.Drawing.Size(149, 23);
            studentLnameBox.TabIndex = 8;
            // 
            // studentFnameBox
            // 
            studentFnameBox.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            studentFnameBox.Location = new System.Drawing.Point(171, 40);
            studentFnameBox.Name = "studentFnameBox";
            studentFnameBox.Size = new System.Drawing.Size(149, 23);
            studentFnameBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(71, 88);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(86, 20);
            label5.TabIndex = 5;
            label5.Text = "Last Name :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(71, 132);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(89, 20);
            label8.TabIndex = 4;
            label8.Text = "Department";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(70, 40);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(87, 20);
            label9.TabIndex = 2;
            label9.Text = "First Name :";
            // 
            // stdAddBtn
            // 
            stdAddBtn.BackColor = System.Drawing.Color.FromArgb(0, 153, 255);
            stdAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            stdAddBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            stdAddBtn.ForeColor = System.Drawing.SystemColors.Control;
            stdAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            stdAddBtn.Location = new System.Drawing.Point(204, 176);
            stdAddBtn.Margin = new System.Windows.Forms.Padding(2);
            stdAddBtn.Name = "stdAddBtn";
            stdAddBtn.Size = new System.Drawing.Size(77, 30);
            stdAddBtn.TabIndex = 1;
            stdAddBtn.Text = "Add ";
            stdAddBtn.UseVisualStyleBackColor = false;
            stdAddBtn.Click += stdAddBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            label10.Location = new System.Drawing.Point(348, 22);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(222, 30);
            label10.TabIndex = 0;
            label10.Text = "Adding A new Student";
            // 
            // studentShowPanel
            // 
            studentShowPanel.Controls.Add(StudentDataGridView);
            studentShowPanel.Controls.Add(sEditPanel);
            studentShowPanel.Controls.Add(tDeletePanel);
            studentShowPanel.Location = new System.Drawing.Point(0, 108);
            studentShowPanel.Name = "studentShowPanel";
            studentShowPanel.Size = new System.Drawing.Size(922, 404);
            studentShowPanel.TabIndex = 4;
            studentShowPanel.Visible = false;
            // 
            // StudentDataGridView
            // 
            StudentDataGridView.AllowUserToAddRows = false;
            StudentDataGridView.AllowUserToDeleteRows = false;
            StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentDataGridView.Location = new System.Drawing.Point(5, 7);
            StudentDataGridView.Name = "StudentDataGridView";
            StudentDataGridView.ReadOnly = true;
            StudentDataGridView.Size = new System.Drawing.Size(601, 463);
            StudentDataGridView.TabIndex = 1;
            StudentDataGridView.CellContentClick += StudentDataGridView_CellContentClick;
            // 
            // sEditPanel
            // 
            sEditPanel.Location = new System.Drawing.Point(612, 3);
            sEditPanel.Name = "sEditPanel";
            sEditPanel.Size = new System.Drawing.Size(307, 191);
            sEditPanel.TabIndex = 0;
            // 
            // tDeletePanel
            // 
            tDeletePanel.Location = new System.Drawing.Point(612, 3);
            tDeletePanel.Name = "tDeletePanel";
            tDeletePanel.Size = new System.Drawing.Size(307, 194);
            tDeletePanel.TabIndex = 0;
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
            // adminPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1145, 576);
            Controls.Add(adminActionPage);
            Controls.Add(sideBar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "adminPage";
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
            adminActionPage.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            pendingQuizPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pendingQuizGrid).EndInit();
            teacherTab.ResumeLayout(false);
            showTeacherPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)teacherDataGridView).EndInit();
            editPanel.ResumeLayout(false);
            editPanel.PerformLayout();
            addTeacherPanel.ResumeLayout(false);
            addTeacherPanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            btnPanel.ResumeLayout(false);
            studentTab.ResumeLayout(false);
            panel5.ResumeLayout(false);
            studentAddPanel.ResumeLayout(false);
            studentAddPanel.PerformLayout();
            panell.ResumeLayout(false);
            panell.PerformLayout();
            studentShowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StudentDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion


        public adminPage(User user)
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
                int userId= userAdmin.UserId;
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
        private System.Windows.Forms.TabControl adminActionPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage teacherTab;
        private System.Windows.Forms.TabPage studentTab;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label usrLabel;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button addTeacherBtn;
        private System.Windows.Forms.Button showTeachersBtn;
        private System.Windows.Forms.Panel showTeacherPanel;
        private System.Windows.Forms.DataGridView teacherDataGridView;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Panel addTeacherPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button techAddBtn;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firtsNameBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button showStudentBtn;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Panel studentShowPanel;
        private System.Windows.Forms.DataGridView StudentDataGridView;
        private System.Windows.Forms.Panel sEditPanel;
        private System.Windows.Forms.Panel tDeletePanel;
        private System.Windows.Forms.Panel studentAddPanel;
        private System.Windows.Forms.Panel panell;
        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.TextBox studentLnameBox;
        private System.Windows.Forms.TextBox studentFnameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button stdAddBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox editFnameBox;
        private System.Windows.Forms.ComboBox editComboBox;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox editLnameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox editUsernameBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox editRoleComboBox;
        private System.Windows.Forms.Panel pendingQuizPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView pendingQuizGrid;
    }
}