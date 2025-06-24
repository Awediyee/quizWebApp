using Microsoft.VisualBasic.ApplicationServices;

namespace quizSystem
{
    partial class studentPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private User userStudent; // Declare at class level

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentPage));
            sideBar = new System.Windows.Forms.FlowLayoutPanel();
            panel1 = new System.Windows.Forms.Panel();
            usrLabel = new System.Windows.Forms.Label();
            menulabel = new System.Windows.Forms.Label();
            menuBtn = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            allQuizBtn = new System.Windows.Forms.Button();
            teacherBtn = new System.Windows.Forms.Button();
            msgBtn = new System.Windows.Forms.Button();
            profileBtn = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            sideBarTimer = new System.Windows.Forms.Timer(components);
            mainTab = new System.Windows.Forms.TabControl();
            allQuizTab = new System.Windows.Forms.TabPage();
            quizStartedPanel = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            optionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            lblQuestion = new System.Windows.Forms.Label();
            btnFinish = new System.Windows.Forms.Button();
            btnNext = new System.Windows.Forms.Button();
            btnPrevious = new System.Windows.Forms.Button();
            panelQuizzes = new System.Windows.Forms.FlowLayoutPanel();
            tabPage2 = new System.Windows.Forms.TabPage();
            panel4 = new System.Windows.Forms.Panel();
            resultDataGrid = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            tabPage3 = new System.Windows.Forms.TabPage();
            tabPage4 = new System.Windows.Forms.TabPage();
            tabPage5 = new System.Windows.Forms.TabPage();
            sideBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuBtn).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            mainTab.SuspendLayout();
            allQuizTab.SuspendLayout();
            quizStartedPanel.SuspendLayout();
            panel5.SuspendLayout();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultDataGrid).BeginInit();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.BackColor = System.Drawing.Color.FromArgb(0, 153, 255);
            sideBar.Controls.Add(panel1);
            sideBar.Controls.Add(panel2);
            sideBar.Controls.Add(teacherBtn);
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
            teacherBtn.Text = "Results";
            teacherBtn.UseVisualStyleBackColor = true;
            teacherBtn.Click += teacherBtn_Click;
            // 
            // msgBtn
            // 
            msgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            msgBtn.ForeColor = System.Drawing.SystemColors.Control;
            msgBtn.Image = (System.Drawing.Image)resources.GetObject("msgBtn.Image");
            msgBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            msgBtn.Location = new System.Drawing.Point(3, 224);
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
            profileBtn.Location = new System.Drawing.Point(3, 268);
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
            panel3.Location = new System.Drawing.Point(3, 312);
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
            // mainTab
            // 
            mainTab.Controls.Add(allQuizTab);
            mainTab.Controls.Add(tabPage2);
            mainTab.Controls.Add(tabPage3);
            mainTab.Controls.Add(tabPage4);
            mainTab.Controls.Add(tabPage5);
            mainTab.Location = new System.Drawing.Point(207, -30);
            mainTab.Name = "mainTab";
            mainTab.SelectedIndex = 0;
            mainTab.Size = new System.Drawing.Size(936, 603);
            mainTab.TabIndex = 1;
            // 
            // allQuizTab
            // 
            allQuizTab.Controls.Add(quizStartedPanel);
            allQuizTab.Controls.Add(panelQuizzes);
            allQuizTab.Location = new System.Drawing.Point(4, 24);
            allQuizTab.Name = "allQuizTab";
            allQuizTab.Padding = new System.Windows.Forms.Padding(3);
            allQuizTab.Size = new System.Drawing.Size(928, 575);
            allQuizTab.TabIndex = 0;
            allQuizTab.Text = "quiz";
            allQuizTab.UseVisualStyleBackColor = true;
            allQuizTab.Click += tabPage1_Click;
            // 
            // quizStartedPanel
            // 
            quizStartedPanel.Controls.Add(panel5);
            quizStartedPanel.Location = new System.Drawing.Point(0, 9);
            quizStartedPanel.Name = "quizStartedPanel";
            quizStartedPanel.Size = new System.Drawing.Size(890, 560);
            quizStartedPanel.TabIndex = 0;
            quizStartedPanel.Visible = false;
            quizStartedPanel.Paint += quizStartedPanel_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.Gray;
            panel5.Controls.Add(optionsPanel);
            panel5.Controls.Add(lblQuestion);
            panel5.Controls.Add(btnFinish);
            panel5.Controls.Add(btnNext);
            panel5.Controls.Add(btnPrevious);
            panel5.Location = new System.Drawing.Point(100, 41);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(593, 405);
            panel5.TabIndex = 0;
            panel5.Paint += panel5_Paint;
            // 
            // optionsPanel
            // 
            optionsPanel.Location = new System.Drawing.Point(81, 42);
            optionsPanel.Name = "optionsPanel";
            optionsPanel.Size = new System.Drawing.Size(456, 220);
            optionsPanel.TabIndex = 22;
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblQuestion.Location = new System.Drawing.Point(3, 19);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new System.Drawing.Size(534, 35);
            lblQuestion.TabIndex = 21;
            lblQuestion.Click += label5_Click;
            // 
            // btnFinish
            // 
            btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFinish.ForeColor = System.Drawing.SystemColors.Control;
            btnFinish.Image = (System.Drawing.Image)resources.GetObject("btnFinish.Image");
            btnFinish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFinish.Location = new System.Drawing.Point(339, 312);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new System.Drawing.Size(96, 38);
            btnFinish.TabIndex = 20;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += button4_Click;
            // 
            // btnNext
            // 
            btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNext.ForeColor = System.Drawing.SystemColors.Control;
            btnNext.Image = (System.Drawing.Image)resources.GetObject("btnNext.Image");
            btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNext.Location = new System.Drawing.Point(216, 312);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(96, 38);
            btnNext.TabIndex = 19;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrevious.ForeColor = System.Drawing.SystemColors.Control;
            btnPrevious.Image = (System.Drawing.Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPrevious.Location = new System.Drawing.Point(81, 312);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new System.Drawing.Size(113, 38);
            btnPrevious.TabIndex = 18;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // panelQuizzes
            // 
            panelQuizzes.Location = new System.Drawing.Point(6, 12);
            panelQuizzes.Name = "panelQuizzes";
            panelQuizzes.Size = new System.Drawing.Size(884, 242);
            panelQuizzes.TabIndex = 0;
            panelQuizzes.Paint += panelQuizzes_Paint;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel4);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(928, 575);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(resultDataGrid);
            panel4.Controls.Add(button1);
            panel4.Location = new System.Drawing.Point(6, 12);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(916, 557);
            panel4.TabIndex = 0;
            // 
            // resultDataGrid
            // 
            resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultDataGrid.Location = new System.Drawing.Point(57, 109);
            resultDataGrid.Name = "resultDataGrid";
            resultDataGrid.Size = new System.Drawing.Size(675, 262);
            resultDataGrid.TabIndex = 4;
            resultDataGrid.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(0, 153, 255);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ForeColor = System.Drawing.SystemColors.Control;
            button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.Location = new System.Drawing.Point(57, 45);
            button1.MaximumSize = new System.Drawing.Size(194, 38);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(194, 38);
            button1.TabIndex = 3;
            button1.Text = "Display All Results";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
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
            // studentPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1145, 576);
            Controls.Add(mainTab);
            Controls.Add(sideBar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "studentPage";
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
            mainTab.ResumeLayout(false);
            allQuizTab.ResumeLayout(false);
            quizStartedPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resultDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion


        public studentPage(User user)
        {
            InitializeComponent();
            this.userStudent = user; // Assign to the class-level variable

            // Use the User object to customize the form
            LoadUserData(userStudent);
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
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage allQuizTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label usrLabel;
        private System.Windows.Forms.FlowLayoutPanel panelQuizzes;
        private System.Windows.Forms.Panel quizStartedPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.FlowLayoutPanel optionsPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView resultDataGrid;
    }
}