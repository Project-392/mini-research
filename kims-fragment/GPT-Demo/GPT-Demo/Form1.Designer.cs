namespace GPT_Demo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userInputTxt = new System.Windows.Forms.TextBox();
            this.userSubmitBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gptOutputTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ask GPT-4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your query or prompt below to get a response from the model.";
            // 
            // userInputTxt
            // 
            this.userInputTxt.Location = new System.Drawing.Point(54, 271);
            this.userInputTxt.Multiline = true;
            this.userInputTxt.Name = "userInputTxt";
            this.userInputTxt.Size = new System.Drawing.Size(401, 93);
            this.userInputTxt.TabIndex = 2;
            this.userInputTxt.Text = "Type your message here.";
            // 
            // userSubmitBtn
            // 
            this.userSubmitBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userSubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userSubmitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userSubmitBtn.Location = new System.Drawing.Point(54, 370);
            this.userSubmitBtn.Name = "userSubmitBtn";
            this.userSubmitBtn.Size = new System.Drawing.Size(85, 43);
            this.userSubmitBtn.TabIndex = 3;
            this.userSubmitBtn.Text = "Submit";
            this.userSubmitBtn.UseVisualStyleBackColor = false;
            this.userSubmitBtn.Click += new System.EventHandler(this.userSubmitBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Response";
            // 
            // gptOutputTxt
            // 
            this.gptOutputTxt.Location = new System.Drawing.Point(577, 271);
            this.gptOutputTxt.Multiline = true;
            this.gptOutputTxt.Name = "gptOutputTxt";
            this.gptOutputTxt.Size = new System.Drawing.Size(338, 93);
            this.gptOutputTxt.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 634);
            this.Controls.Add(this.gptOutputTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userSubmitBtn);
            this.Controls.Add(this.userInputTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userInputTxt;
        private System.Windows.Forms.Button userSubmitBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gptOutputTxt;
    }
}

