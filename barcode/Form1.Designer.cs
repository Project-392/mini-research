namespace barcode
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.RichTextBox rtxtResults;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlScroll;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnlScroll = new System.Windows.Forms.Panel();
            this.rtxtResults = new System.Windows.Forms.RichTextBox();
            this.txtAPI = new System.Windows.Forms.TextBox();
            this.btn_database = new System.Windows.Forms.Button();
            this.pnlScroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(9, 8);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(178, 22);
            this.txtBarcode.TabIndex = 0;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(9, 32);
            this.btnScan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(89, 22);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(107, 32);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(89, 22);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // pnlScroll
            // 
            this.pnlScroll.AutoScroll = true;
            this.pnlScroll.Controls.Add(this.rtxtResults);
            this.pnlScroll.Location = new System.Drawing.Point(9, 75);
            this.pnlScroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlScroll.Name = "pnlScroll";
            this.pnlScroll.Size = new System.Drawing.Size(569, 280);
            this.pnlScroll.TabIndex = 0;
            // 
            // rtxtResults
            // 
            this.rtxtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtResults.Location = new System.Drawing.Point(0, 0);
            this.rtxtResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtResults.Name = "rtxtResults";
            this.rtxtResults.ReadOnly = true;
            this.rtxtResults.Size = new System.Drawing.Size(569, 280);
            this.rtxtResults.TabIndex = 3;
            this.rtxtResults.Text = "";
            // 
            // txtAPI
            // 
            this.txtAPI.Location = new System.Drawing.Point(249, 8);
            this.txtAPI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAPI.Name = "txtAPI";
            this.txtAPI.Size = new System.Drawing.Size(261, 22);
            this.txtAPI.TabIndex = 3;
            this.txtAPI.Text = "API KEY HERE";
            // 
            // btn_database
            // 
            this.btn_database.Location = new System.Drawing.Point(204, 396);
            this.btn_database.Name = "btn_database";
            this.btn_database.Size = new System.Drawing.Size(192, 84);
            this.btn_database.TabIndex = 4;
            this.btn_database.Text = "Database Integration";
            this.btn_database.UseVisualStyleBackColor = true;
            this.btn_database.Click += new System.EventHandler(this.btn_database_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 516);
            this.Controls.Add(this.btn_database);
            this.Controls.Add(this.txtAPI);
            this.Controls.Add(this.pnlScroll);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.btnScan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Barcode Scanner";
            this.pnlScroll.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtAPI;
        private System.Windows.Forms.Button btn_database;
    }
}
