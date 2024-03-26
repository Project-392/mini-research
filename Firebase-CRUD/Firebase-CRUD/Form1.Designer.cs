
namespace Firebase_CRUD
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
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_recover = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_deleteAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(358, 108);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(247, 22);
            this.tb_user.TabIndex = 0;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(358, 171);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(247, 22);
            this.tb_name.TabIndex = 1;
            // 
            // tb_city
            // 
            this.tb_city.Location = new System.Drawing.Point(358, 354);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(247, 22);
            this.tb_city.TabIndex = 2;
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(358, 255);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(247, 22);
            this.tb_age.TabIndex = 3;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(211, 111);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(79, 17);
            this.lbl_user.TabIndex = 4;
            this.lbl_user.Text = "User Name";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(229, 174);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "Name";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(243, 354);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(31, 17);
            this.lbl_city.TabIndex = 6;
            this.lbl_city.Text = "City";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(243, 260);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(33, 17);
            this.lbl_age.TabIndex = 7;
            this.lbl_age.Text = "Age";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(288, 409);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(140, 63);
            this.btn_insert.TabIndex = 8;
            this.btn_insert.Text = "Insert user";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_recover
            // 
            this.btn_recover.Location = new System.Drawing.Point(492, 409);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(140, 63);
            this.btn_recover.TabIndex = 9;
            this.btn_recover.Text = "Recover user";
            this.btn_recover.UseVisualStyleBackColor = true;
            this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(288, 517);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(140, 63);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update user";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(492, 517);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(140, 63);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete user";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_deleteAll
            // 
            this.btn_deleteAll.Location = new System.Drawing.Point(264, 610);
            this.btn_deleteAll.Name = "btn_deleteAll";
            this.btn_deleteAll.Size = new System.Drawing.Size(435, 51);
            this.btn_deleteAll.TabIndex = 12;
            this.btn_deleteAll.Text = "Delete all users";
            this.btn_deleteAll.UseVisualStyleBackColor = true;
            this.btn_deleteAll.Click += new System.EventHandler(this.btn_deleteAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 692);
            this.Controls.Add(this.btn_deleteAll);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_recover);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_city);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_user);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_recover;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_deleteAll;
    }
}

