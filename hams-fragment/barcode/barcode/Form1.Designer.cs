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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Barcode Scanner";

            // initialize textbox for entering barcode
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtBarcode.Location = new System.Drawing.Point(10, 10);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(200, 20);
            this.txtBarcode.TabIndex = 0;

            // initialize button for scanning barcode
            this.btnScan = new System.Windows.Forms.Button();
            this.btnScan.Location = new System.Drawing.Point(10, 40);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(100, 20);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);

            // initiaize button for uploading barcode image
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnUpload.Location = new System.Drawing.Point(120, 40);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 20);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);

            //initialize open file dialog for uploading image
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog.FileName = "openFileDialog";

            // initialize panel for scrollable results
            this.pnlScroll = new System.Windows.Forms.Panel();
            this.pnlScroll.Location = new System.Drawing.Point(10, 70);
            this.pnlScroll.Name = "pnlScroll";
            this.pnlScroll.Size = new System.Drawing.Size(640, 260);
            this.pnlScroll.AutoScroll = true;

            // initialize rich text box for displaying results
            this.rtxtResults = new System.Windows.Forms.RichTextBox();
            this.rtxtResults.Location = new System.Drawing.Point(0, 0);
            this.rtxtResults.Name = "rtxtResults";
            this.rtxtResults.Size = new System.Drawing.Size(640, 260);
            this.rtxtResults.TabIndex = 3;
            this.rtxtResults.Text = "";
            this.rtxtResults.ReadOnly = true;
            this.rtxtResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                    | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));

            // add UI components to form
            this.pnlScroll.Controls.Add(this.rtxtResults);
            this.Controls.Add(this.pnlScroll);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.btnScan);

            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
