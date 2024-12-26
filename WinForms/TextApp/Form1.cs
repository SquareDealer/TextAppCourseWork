using ClassLibrary;
using System.Diagnostics.Eventing.Reader;
namespace TextApp
{
    public partial class Form1 : Form
    {
        List<Sentence> receivedData = new List<Sentence>();
        Text text;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (WordsConstuctorForm wordsConstuctorForm = new WordsConstuctorForm())
            {
                wordsConstuctorForm.ShowDialog(); // ���������� ����

                // ������ ������������� ���� ������
                receivedData = wordsConstuctorForm.sentenceList;

                if (receivedData != null && receivedData.Count > 0)
                {
                    MessageBox.Show($"����������� ���������", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("������ ����������� ���� ��� �� ������.", "���������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void createTextObject_Click(object sender, EventArgs e)
        {
            if (receivedData != null && receivedData.Count > 0)
            {
                text = new Text();
                for (int i = 0; i < receivedData.Count; i++)
                {
                    text.AddSentence(receivedData[i]);
                }
                string textRepresentation = text.ToString(); // ��������� ��������� �������������
                richTextBox1.Text = textRepresentation;
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
                openFileDialog.Title = "������� ��������� ����";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // ������ ����� � ����������� ����������� � TextBox
                    string fileContent = File.ReadAllText(openFileDialog.FileName);
                    richTextBox1.Text = fileContent;
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
                saveFileDialog.Title = "��������� ��������� ����";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // ���������� ������ �� text � ����
                    File.WriteAllText(saveFileDialog.FileName, text.ToString());
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openTextAnalyser_Click(object sender, EventArgs e)
        {
            using (TextAnalyserForm textAnalyserForm = new TextAnalyserForm())
            {
                textAnalyserForm.ShowDialog(); // ���������� ����
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (text != null)
            {
                text = null; // �������� ������ �� ������
                MessageBox.Show("������ text �����.");
            }
            else
            {
                MessageBox.Show("������ text �� ���������� ��� ��� �����.");
            }
            UpdateRichTextBox();
        }

        private void UpdateRichTextBox()
        {
            // ������� richTextBox1
            richTextBox1.Clear();

            // ��������� ������ text
            if (text != null)
            {
                // �������� ������ �����������
                List<Sentence> sentencesList = text.getSentencesList();

                // ���� ������ ����������� ����������, ��������� �� � RichTextBox
                if (sentencesList != null && sentencesList.Count > 0)
                {
                    foreach (Sentence sentence in sentencesList)
                    {
                        richTextBox1.AppendText(sentence.ToString() + " ");
                    }
                }
                else
                {
                    MessageBox.Show("������ ����������� ����.", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (text != null)
            {
                using (TextEditorForm textEditorForm = new TextEditorForm(text))
                {
                    textEditorForm.ShowDialog(); // ���������� ����
                }
            }
            else
            {
                MessageBox.Show("������� �������� ������ ������ text!.", "��������������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
