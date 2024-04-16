namespace barcode
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxCameras = new System.Windows.Forms.ComboBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.rtxtResults = new System.Windows.Forms.RichTextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pictureBoxBarcode = new System.Windows.Forms.PictureBox(); // Add PictureBox control

            this.SuspendLayout();

            // comboBoxCameras
            this.comboBoxCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCameras.FormattingEnabled = true;
            this.comboBoxCameras.Location = new System.Drawing.Point(12, 12);
            this.comboBoxCameras.Name = "comboBoxCameras";
            this.comboBoxCameras.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCameras.TabIndex = 0;

            // txtBarcode
            this.txtBarcode.Location = new System.Drawing.Point(12, 39);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(260, 20);
            this.txtBarcode.TabIndex = 1;

            // rtxtResults
            this.rtxtResults.Location = new System.Drawing.Point(12, 65);
            this.rtxtResults.Name = "rtxtResults";
            this.rtxtResults.Size = new System.Drawing.Size(260, 96);
            this.rtxtResults.TabIndex = 2;
            this.rtxtResults.Text = "";
            this.rtxtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12); 

            // btnScan
            this.btnScan.Location = new System.Drawing.Point(139, 12);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(133, 23);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);

            // btnUpload
            this.btnUpload.Location = new System.Drawing.Point(139, 161);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(133, 23);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);

            // pictureBoxBarcode
            this.pictureBoxBarcode.Location = new System.Drawing.Point(12, 190);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(360, 100); 
            this.pictureBoxBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom; // or StretchImage
            this.pictureBoxBarcode.TabIndex = 5;
            this.pictureBoxBarcode.TabStop = false;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pictureBoxBarcode); 
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.rtxtResults);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.comboBoxCameras);
            this.Name = "Form1";
            this.Text = "Barcode Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxCameras;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.RichTextBox rtxtResults;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pictureBoxBarcode; 
    }
}
