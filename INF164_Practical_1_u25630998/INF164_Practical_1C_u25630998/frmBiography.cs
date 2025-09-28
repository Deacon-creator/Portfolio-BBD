using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace INF164_Practical_1C_u25630998
{
    public partial class frmBiography: Form
    {
        public frmBiography()
        {
            InitializeComponent();
            // Initial word count when the form loads
            UpdateWordCount();
        }

        private void frmBiography_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "Biography.txt");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "Biography.txt");
            try
            {
                
                string textToSave = rtxLines.Text; // Assuming 'richTextBox1' is your RichTextBox control

                File.WriteAllText(filePath, textToSave);

                MessageBox.Show($"Text saved successfully to: {filePath}", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rtxLines_TextChanged(object sender, EventArgs e)
        {
            UpdateWordCount();
        }

        private void UpdateWordCount()
        {
            string text = rtxLines.Text; // Or inputRichTextBox.Text

            // Trim leading/trailing spaces and then split by spaces
            // Filter out empty strings that might result from multiple spaces
            int wordCount = text.Trim()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Count();

            lblWordCount.Text = $"Total Word(s) count: {wordCount}";
        }
    }
    }

