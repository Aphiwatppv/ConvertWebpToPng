namespace ConvertWebpToPng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "WebP Files (*.webp)|*.webp",
                Title = "Select a WebP File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
                lblStatus.Text = "File selected. Ready for conversion.";
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePath.Text) || !File.Exists(txtFilePath.Text))
            {
                MessageBox.Show("Please select a valid WebP file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // **Call the AskUserForImageSize method here:**
            if (!AskUserForImageSize(out bool useOriginalSize))
            {
                lblStatus.Text = "Operation canceled by user.";
                return;
            }

            string webpFilePath = txtFilePath.Text;

            string defaultName = Path.GetFileNameWithoutExtension(webpFilePath);
            string fileName = PromptForFileName(defaultName);

            if (string.IsNullOrEmpty(fileName))
            {
                lblStatus.Text = "Operation canceled by user.";
                return;
            }

            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string saveFolder = Path.Combine(appDirectory, "ConvertedFiles");

            if (!Directory.Exists(saveFolder))
            {
                Directory.CreateDirectory(saveFolder);
            }

            string pngFilePath = Path.Combine(saveFolder, fileName + ".png");

            try
            {
                WebPToPngConverter converter = new WebPToPngConverter();
                bool success = converter.ConvertWebPToPng(webpFilePath, pngFilePath, useOriginalSize);

                if (success)
                {
                    lblStatus.Text = $"Conversion successful! PNG saved at: {pngFilePath}";
                    MessageBox.Show($"Conversion successful!\nPNG saved at: {pngFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblStatus.Text = "Conversion failed.";
                    MessageBox.Show("Failed to convert the WebP file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error occurred.";
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConvertToIco_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePath.Text) || !File.Exists(txtFilePath.Text))
            {
                MessageBox.Show("Please select a valid WebP file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // **Call the AskUserForImageSize method here:**
            if (!AskUserForImageSize(out bool useOriginalSize))
            {
                lblStatus.Text = "Operation canceled by user.";
                return;
            }

            string webpFilePath = txtFilePath.Text;
            string defaultName = Path.GetFileNameWithoutExtension(webpFilePath);
            string fileName = PromptForFileName(defaultName);

            if (string.IsNullOrEmpty(fileName))
            {
                lblStatus.Text = "Operation canceled by user.";
                return;
            }

            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string saveFolder = Path.Combine(appDirectory, "ConvertedIconFiles");

            if (!Directory.Exists(saveFolder))
            {
                Directory.CreateDirectory(saveFolder);
            }

            string icoFilePath = Path.Combine(saveFolder, fileName + ".ico");

            try
            {
                WebPToPngConverter converter = new WebPToPngConverter();
                bool success = converter.ConvertWebPToIco(webpFilePath, icoFilePath, useOriginalSize);

                if (success)
                {
                    lblStatus.Text = $"Conversion to ICO successful! File saved at: {icoFilePath}";
                    MessageBox.Show($"Conversion successful!\nICO saved at: {icoFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblStatus.Text = "ICO conversion failed.";
                    MessageBox.Show("Failed to convert the WebP file to ICO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error occurred.";
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void OpenFolder(string folderName)
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = Path.Combine(appDirectory, folderName);

            if (Directory.Exists(folderPath))
            {
                System.Diagnostics.Process.Start("explorer.exe", folderPath);
            }
            else
            {
                MessageBox.Show($"The folder '{folderName}' does not exist.", "Folder Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOpenConvertedFiles_Click(object sender, EventArgs e)
        {
            OpenFolder("ConvertedFiles");
        }

        private void btnOpenConvertedIconFiles_Click(object sender, EventArgs e)
        {
            OpenFolder("ConvertedIconFiles");
        }

        private bool AskUserForImageSize(out bool useOriginalSize)
        {
            var result = MessageBox.Show("Do you want to use the original size?\nClick 'Yes' for Original Size or 'No' for 128x128 Size.",
                                         "Choose Image Size",
                                         MessageBoxButtons.YesNoCancel,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                useOriginalSize = true;
                return true; // Proceed with conversion
            }
            else if (result == DialogResult.No)
            {
                useOriginalSize = false;
                return true; // Proceed with conversion
            }
            else
            {
                useOriginalSize = false;
                return false; // Cancel the operation
            }
        }


        private string PromptForFileName(string defaultName)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the name for the saved file (without extension):",
                "Set File Name",
                defaultName);

            return string.IsNullOrWhiteSpace(input) ? null : input.Trim();
        }


    }
}
