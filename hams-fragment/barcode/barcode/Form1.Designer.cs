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
            this.pnlScroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(10, 10);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(200, 26);
            this.txtBarcode.TabIndex = 0;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(10, 40);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(100, 28);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(120, 40);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 28);
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
            this.pnlScroll.Location = new System.Drawing.Point(10, 94);
            this.pnlScroll.Name = "pnlScroll";
            this.pnlScroll.Size = new System.Drawing.Size(640, 350);
            this.pnlScroll.TabIndex = 0;
            // 
            // rtxtResults
            // 
            this.rtxtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtResults.Location = new System.Drawing.Point(0, 0);
            this.rtxtResults.Name = "rtxtResults";
            this.rtxtResults.ReadOnly = true;
            this.rtxtResults.Size = new System.Drawing.Size(640, 350);
            this.rtxtResults.TabIndex = 3;
            this.rtxtResults.Text = "";
            // 
            // txtAPI
            // 
            this.txtAPI.Location = new System.Drawing.Point(280, 10);
            this.txtAPI.Name = "txtAPI";
            this.txtAPI.Size = new System.Drawing.Size(293, 26);
            this.txtAPI.TabIndex = 3;
            this.txtAPI.Text = "API KEY HERE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 645);
            this.Controls.Add(this.txtAPI);
            this.Controls.Add(this.pnlScroll);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.btnScan);
            this.Name = "Form1";
            this.Text = "Barcode Scanner";
            this.pnlScroll.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtAPI;
    }
}
