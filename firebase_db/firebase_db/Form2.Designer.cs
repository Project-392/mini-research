namespace firebase_db
{
    partial class Form2
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
            label1 = new Label();
            tb_userID = new TextBox();
            btn_logout = new Button();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tb_petName = new TextBox();
            tb_petAge = new TextBox();
            tb_petBreed = new TextBox();
            tb_bio = new RichTextBox();
            tb_diet = new RichTextBox();
            tb_medicalHistory = new RichTextBox();
            tb_scanHistory = new RichTextBox();
            label10 = new Label();
            tb_petHistory = new RichTextBox();
            label11 = new Label();
            btn_retrieve_all_pets = new Button();
            btn_retrieve_pet = new Button();
            btn_submit = new Button();
            btn_show_scan_history = new Button();
            btn_add_scan_history = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(376, 37);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Unique User_ID";
            // 
            // tb_userID
            // 
            tb_userID.Location = new Point(506, 37);
            tb_userID.Name = "tb_userID";
            tb_userID.Size = new Size(280, 27);
            tb_userID.TabIndex = 1;
            // 
            // btn_logout
            // 
            btn_logout.AccessibleRole = AccessibleRole.None;
            btn_logout.Location = new Point(1534, 19);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 62);
            btn_logout.TabIndex = 2;
            btn_logout.Text = "Log Out";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(574, 81);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 3;
            label2.Text = "Pet Information Below";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(285, 254);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 10;
            label6.Text = "Pet Breed:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(285, 206);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 9;
            label5.Text = "Pet Age: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 152);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 8;
            label4.Text = "Pet Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 547);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 13;
            label3.Text = "Medical History";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(285, 423);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 12;
            label7.Text = "Diet";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(282, 300);
            label8.Name = "label8";
            label8.Size = new Size(31, 20);
            label8.TabIndex = 11;
            label8.Text = "Bio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1011, 81);
            label9.Name = "label9";
            label9.Size = new Size(88, 20);
            label9.TabIndex = 14;
            label9.Text = "Scan history";
            // 
            // tb_petName
            // 
            tb_petName.Location = new Point(415, 145);
            tb_petName.Name = "tb_petName";
            tb_petName.Size = new Size(280, 27);
            tb_petName.TabIndex = 15;
            // 
            // tb_petAge
            // 
            tb_petAge.Location = new Point(415, 199);
            tb_petAge.Name = "tb_petAge";
            tb_petAge.Size = new Size(280, 27);
            tb_petAge.TabIndex = 16;
            // 
            // tb_petBreed
            // 
            tb_petBreed.Location = new Point(415, 247);
            tb_petBreed.Name = "tb_petBreed";
            tb_petBreed.Size = new Size(280, 27);
            tb_petBreed.TabIndex = 17;
            // 
            // tb_bio
            // 
            tb_bio.Location = new Point(415, 300);
            tb_bio.Name = "tb_bio";
            tb_bio.Size = new Size(534, 98);
            tb_bio.TabIndex = 18;
            tb_bio.Text = "";
            // 
            // tb_diet
            // 
            tb_diet.Location = new Point(415, 423);
            tb_diet.Name = "tb_diet";
            tb_diet.Size = new Size(534, 98);
            tb_diet.TabIndex = 19;
            tb_diet.Text = "";
            // 
            // tb_medicalHistory
            // 
            tb_medicalHistory.Location = new Point(415, 547);
            tb_medicalHistory.Name = "tb_medicalHistory";
            tb_medicalHistory.Size = new Size(534, 98);
            tb_medicalHistory.TabIndex = 20;
            tb_medicalHistory.Text = "";
            // 
            // tb_scanHistory
            // 
            tb_scanHistory.Location = new Point(1106, 128);
            tb_scanHistory.Name = "tb_scanHistory";
            tb_scanHistory.Size = new Size(534, 98);
            tb_scanHistory.TabIndex = 21;
            tb_scanHistory.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1034, 487);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 22;
            label10.Text = "Pet History";
            // 
            // tb_petHistory
            // 
            tb_petHistory.Location = new Point(1106, 528);
            tb_petHistory.Name = "tb_petHistory";
            tb_petHistory.Size = new Size(534, 98);
            tb_petHistory.TabIndex = 23;
            tb_petHistory.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1246, 487);
            label11.Name = "label11";
            label11.Size = new Size(161, 20);
            label11.TabIndex = 24;
            label11.Text = "Shows all pet's entered";
            // 
            // btn_retrieve_all_pets
            // 
            btn_retrieve_all_pets.Location = new Point(1207, 650);
            btn_retrieve_all_pets.Name = "btn_retrieve_all_pets";
            btn_retrieve_all_pets.Size = new Size(337, 82);
            btn_retrieve_all_pets.TabIndex = 25;
            btn_retrieve_all_pets.Text = "Retrive All Pets";
            btn_retrieve_all_pets.UseVisualStyleBackColor = true;
            btn_retrieve_all_pets.Click += btn_retrieve_all_pets_Click;
            // 
            // btn_retrieve_pet
            // 
            btn_retrieve_pet.Location = new Point(399, 668);
            btn_retrieve_pet.Name = "btn_retrieve_pet";
            btn_retrieve_pet.Size = new Size(246, 64);
            btn_retrieve_pet.TabIndex = 26;
            btn_retrieve_pet.Text = "Retrive Pet Info using Pet Name";
            btn_retrieve_pet.UseVisualStyleBackColor = true;
            btn_retrieve_pet.Click += btn_retrieve_pet_Click;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(102, 668);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(231, 64);
            btn_submit.TabIndex = 27;
            btn_submit.Text = "Submit Pet Info";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // btn_show_scan_history
            // 
            btn_show_scan_history.Location = new Point(1423, 269);
            btn_show_scan_history.Name = "btn_show_scan_history";
            btn_show_scan_history.Size = new Size(205, 82);
            btn_show_scan_history.TabIndex = 28;
            btn_show_scan_history.Text = "Show Scan History";
            btn_show_scan_history.UseVisualStyleBackColor = true;
            btn_show_scan_history.Click += btn_show_scan_history_Click_1;
            // 
            // btn_add_scan_history
            // 
            btn_add_scan_history.Location = new Point(1122, 272);
            btn_add_scan_history.Name = "btn_add_scan_history";
            btn_add_scan_history.Size = new Size(205, 82);
            btn_add_scan_history.TabIndex = 29;
            btn_add_scan_history.Text = "Add to Scan History";
            btn_add_scan_history.UseVisualStyleBackColor = true;
            btn_add_scan_history.Click += btn_add_scan_history_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1670, 836);
            Controls.Add(btn_add_scan_history);
            Controls.Add(btn_show_scan_history);
            Controls.Add(btn_submit);
            Controls.Add(btn_retrieve_pet);
            Controls.Add(btn_retrieve_all_pets);
            Controls.Add(label11);
            Controls.Add(tb_petHistory);
            Controls.Add(label10);
            Controls.Add(tb_scanHistory);
            Controls.Add(tb_medicalHistory);
            Controls.Add(tb_diet);
            Controls.Add(tb_bio);
            Controls.Add(tb_petBreed);
            Controls.Add(tb_petAge);
            Controls.Add(tb_petName);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btn_logout);
            Controls.Add(tb_userID);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_userID;
        private Button btn_logout;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tb_petName;
        private TextBox tb_petAge;
        private TextBox tb_petBreed;
        private RichTextBox tb_bio;
        private RichTextBox tb_diet;
        private RichTextBox tb_medicalHistory;
        private RichTextBox tb_scanHistory;
        private Label label10;
        private RichTextBox tb_petHistory;
        private Label label11;
        private Button btn_retrieve_all_pets;
        private Button btn_retrieve_pet;
        private Button btn_submit;
        private Button btn_show_scan_history;
        private Button btn_add_scan_history;
    }
}