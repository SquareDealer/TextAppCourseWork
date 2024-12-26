using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextApp
{
    public partial class TextAnalyserForm : Form
    {
        TextAnalyzer textAnalyzer = new TextAnalyzer();
        ITextOperations textOperations = new TextAnalyzer();
        bool searchMode = false;
        public TextAnalyserForm()
        {
            InitializeComponent();
        }

        private void TextAnalyserForm_Load(object sender, EventArgs e)
        {

        }

        private void loadTextFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
                openFileDialog.Title = "Открыть текстовый файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Чтение файла и отображение содержимого в TextBox
                    string fileContent = File.ReadAllText(openFileDialog.FileName);
                    textRichBox.Text = fileContent;
                }
            }
        }

        private void textRichBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveStatistics_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
                saveFileDialog.Title = "Сохранить текстовый файл";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Сохранение текста из TextBox в файл
                    File.WriteAllText(saveFileDialog.FileName, analysedTextBox.Text);
                }
            }
        }

        private void analysedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void analyseTextBtn_Click(object sender, EventArgs e)
        {
            analysedTextBox.Text = textAnalyzer.AnalyzeText(textOperations, textRichBox.Text, searchMode, searchTextBox.Text);
        }

        private void enableSearchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            searchMode = enableSearchCheckBox.Checked;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showStats_Click(object sender, EventArgs e)
        {

        }
    }
}
