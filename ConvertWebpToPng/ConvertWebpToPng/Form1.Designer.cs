namespace ConvertWebpToPng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblInstruction = new Label();
            txtFilePath = new TextBox();
            btnConvert = new Button();
            btnBrowse = new Button();
            lblStatus = new Label();
            btnConvertToIco = new Button();
            btnOpenConvertedFiles = new Button();
            btnOpenConvertedIconFiles = new Button();
            SuspendLayout();
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Location = new Point(12, 9);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(201, 15);
            lblInstruction.TabIndex = 0;
            lblInstruction.Text = "Select a WebP file to convert to PNG.";
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(12, 27);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(734, 23);
            txtFilePath.TabIndex = 1;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(93, 56);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(12, 56);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 118);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 4;
            // 
            // btnConvertToIco
            // 
            btnConvertToIco.Location = new Point(174, 56);
            btnConvertToIco.Name = "btnConvertToIco";
            btnConvertToIco.Size = new Size(119, 23);
            btnConvertToIco.TabIndex = 5;
            btnConvertToIco.Text = "Convert to ICO";
            btnConvertToIco.UseVisualStyleBackColor = true;
            btnConvertToIco.Click += btnConvertToIco_Click;
            // 
            // btnOpenConvertedFiles
            // 
            btnOpenConvertedFiles.Location = new Point(12, 85);
            btnOpenConvertedFiles.Name = "btnOpenConvertedFiles";
            btnOpenConvertedFiles.Size = new Size(119, 23);
            btnOpenConvertedFiles.TabIndex = 6;
            btnOpenConvertedFiles.Text = "Open PNG Folder";
            btnOpenConvertedFiles.UseVisualStyleBackColor = true;
            btnOpenConvertedFiles.Click += btnOpenConvertedFiles_Click;
            // 
            // btnOpenConvertedIconFiles
            // 
            btnOpenConvertedIconFiles.Location = new Point(146, 85);
            btnOpenConvertedIconFiles.Name = "btnOpenConvertedIconFiles";
            btnOpenConvertedIconFiles.Size = new Size(119, 23);
            btnOpenConvertedIconFiles.TabIndex = 7;
            btnOpenConvertedIconFiles.Text = "Open ICO Folder";
            btnOpenConvertedIconFiles.UseVisualStyleBackColor = true;
            btnOpenConvertedIconFiles.Click += btnOpenConvertedIconFiles_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 152);
            Controls.Add(btnOpenConvertedIconFiles);
            Controls.Add(btnOpenConvertedFiles);
            Controls.Add(btnConvertToIco);
            Controls.Add(lblStatus);
            Controls.Add(btnBrowse);
            Controls.Add(btnConvert);
            Controls.Add(txtFilePath);
            Controls.Add(lblInstruction);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Convert Webp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstruction;
        private TextBox txtFilePath;
        private Button btnConvert;
        private Button btnBrowse;
        private Label lblStatus;
        private Button btnConvertToIco;
        private Button btnOpenConvertedFiles;
        private Button btnOpenConvertedIconFiles;
    }
}
