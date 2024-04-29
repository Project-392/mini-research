namespace firebase_db
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_email = new TextBox();
            tb_password = new TextBox();
            cb_showpassword = new CheckBox();
            btn_signup = new Button();
            btn_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(610, 124);
            label1.Name = "label1";
            label1.Size = new Size(255, 20);
            label1.TabIndex = 0;
            label1.Text = "Login using your email and password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(471, 194);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Email: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(451, 251);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // tb_email
            // 
            tb_email.Location = new Point(556, 197);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(359, 27);
            tb_email.TabIndex = 3;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(556, 251);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(359, 27);
            tb_password.TabIndex = 4;
            // 
            // cb_showpassword
            // 
            cb_showpassword.AutoSize = true;
            cb_showpassword.Location = new Point(938, 254);
            cb_showpassword.Name = "cb_showpassword";
            cb_showpassword.Size = new Size(132, 24);
            cb_showpassword.TabIndex = 5;
            cb_showpassword.Text = "show password";
            cb_showpassword.UseVisualStyleBackColor = true;
            cb_showpassword.CheckedChanged += cb_showpassword_CheckedChanged;
            // 
            // btn_signup
            // 
            btn_signup.Location = new Point(471, 335);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(252, 162);
            btn_signup.TabIndex = 6;
            btn_signup.Text = "sign up";
            btn_signup.UseVisualStyleBackColor = true;
            btn_signup.Click += btn_signup_Click;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(776, 335);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(252, 162);
            btn_login.TabIndex = 7;
            btn_login.Text = "login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1685, 809);
            Controls.Add(btn_login);
            Controls.Add(btn_signup);
            Controls.Add(cb_showpassword);
            Controls.Add(tb_password);
            Controls.Add(tb_email);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Authentication Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_email;
        private TextBox tb_password;
        private CheckBox cb_showpassword;
        private Button btn_signup;
        private Button btn_login;
    }
}
