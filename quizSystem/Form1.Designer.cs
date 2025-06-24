
namespace quizSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            quizTxtLabel = new System.Windows.Forms.Label();
            loginPanel = new System.Windows.Forms.Panel();
            logInBtn = new System.Windows.Forms.Button();
            checkBox1 = new System.Windows.Forms.CheckBox();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            pwdTxtBox = new System.Windows.Forms.TextBox();
            usrTxtBox = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            slogan = new System.Windows.Forms.Label();
            loginPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // quizTxtLabel
            // 
            quizTxtLabel.BackColor = System.Drawing.Color.FromArgb(0, 153, 255);
            quizTxtLabel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            quizTxtLabel.ForeColor = System.Drawing.Color.White;
            quizTxtLabel.Location = new System.Drawing.Point(310, 72);
            quizTxtLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            quizTxtLabel.MinimumSize = new System.Drawing.Size(117, 2);
            quizTxtLabel.Name = "quizTxtLabel";
            quizTxtLabel.Size = new System.Drawing.Size(247, 35);
            quizTxtLabel.TabIndex = 0;
            quizTxtLabel.Text = "Student Quiz System";
            quizTxtLabel.Click += quizTxtLabel_Click;
            // 
            // loginPanel
            // 
            loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            loginPanel.Controls.Add(logInBtn);
            loginPanel.Controls.Add(checkBox1);
            loginPanel.Controls.Add(linkLabel1);
            loginPanel.Controls.Add(pwdTxtBox);
            loginPanel.Controls.Add(usrTxtBox);
            loginPanel.Controls.Add(panel2);
            loginPanel.ForeColor = System.Drawing.Color.FromArgb(128, 128, 255);
            loginPanel.Location = new System.Drawing.Point(48, 110);
            loginPanel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new System.Drawing.Size(710, 266);
            loginPanel.TabIndex = 1;
            loginPanel.Paint += panel1_Paint;
            // 
            // logInBtn
            // 
            logInBtn.BackColor = System.Drawing.Color.FromArgb(0, 153, 255);
            logInBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            logInBtn.ForeColor = System.Drawing.SystemColors.Control;
            logInBtn.Location = new System.Drawing.Point(103, 148);
            logInBtn.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new System.Drawing.Size(254, 39);
            logInBtn.TabIndex = 5;
            logInBtn.Text = "Log In";
            logInBtn.UseVisualStyleBackColor = false;
            logInBtn.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            checkBox1.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            checkBox1.Location = new System.Drawing.Point(103, 122);
            checkBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(102, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Remember";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            linkLabel1.LinkColor = System.Drawing.Color.FromArgb(0, 153, 255);
            linkLabel1.Location = new System.Drawing.Point(99, 208);
            linkLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(227, 18);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Your Username or Password?";
            // 
            // pwdTxtBox
            // 
            pwdTxtBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            pwdTxtBox.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            pwdTxtBox.Location = new System.Drawing.Point(103, 77);
            pwdTxtBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            pwdTxtBox.Name = "pwdTxtBox";
            pwdTxtBox.PasswordChar = '*';
            pwdTxtBox.Size = new System.Drawing.Size(254, 29);
            pwdTxtBox.TabIndex = 2;
            pwdTxtBox.Text = "Admin1234";
            pwdTxtBox.Click += pwdTxtBox_Click;
            pwdTxtBox.TextChanged += textBox2_TextChanged;
            // 
            // usrTxtBox
            // 
            usrTxtBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            usrTxtBox.ForeColor = System.Drawing.Color.FromArgb(0, 153, 255);
            usrTxtBox.Location = new System.Drawing.Point(103, 31);
            usrTxtBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            usrTxtBox.Name = "usrTxtBox";
            usrTxtBox.Size = new System.Drawing.Size(254, 29);
            usrTxtBox.TabIndex = 1;
            usrTxtBox.Text = "abdulkerim";
            usrTxtBox.WordWrap = false;
            usrTxtBox.Click += usrTxtBox_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(0, 153, 255);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(slogan);
            panel2.Location = new System.Drawing.Point(405, 31);
            panel2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(238, 197);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(50, 126);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(135, 26);
            label2.TabIndex = 2;
            label2.Text = "Quiz at a time\"";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(50, 87);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(129, 26);
            label1.TabIndex = 1;
            label1.Text = "Potential One,";
            // 
            // slogan
            // 
            slogan.AutoSize = true;
            slogan.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            slogan.ForeColor = System.Drawing.SystemColors.Control;
            slogan.Location = new System.Drawing.Point(50, 46);
            slogan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            slogan.Name = "slogan";
            slogan.Size = new System.Drawing.Size(126, 26);
            slogan.TabIndex = 0;
            slogan.Text = "\"Decode Your";
            slogan.Click += slogan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(822, 432);
            Controls.Add(loginPanel);
            Controls.Add(quizTxtLabel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(838, 471);
            MinimumSize = new System.Drawing.Size(838, 471);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label quizTxtLabel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox pwdTxtBox;
        private System.Windows.Forms.TextBox usrTxtBox;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label slogan;
    }
}

