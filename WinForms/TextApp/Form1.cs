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
                wordsConstuctorForm.ShowDialog(); // Показываем окно

                // Прямое использование поля класса
                receivedData = wordsConstuctorForm.sentenceList;

                if (receivedData != null && receivedData.Count > 0)
                {
                    MessageBox.Show($"Предложения сохранены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Список предложений пуст или не изменён.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                string textRepresentation = text.ToString(); // Сохраните строковое представление
                richTextBox1.Text = textRepresentation;
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
                openFileDialog.Title = "Открыть текстовый файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Чтение файла и отображение содержимого в TextBox
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
                saveFileDialog.Title = "Сохранить текстовый файл";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Сохранение текста из text в файл
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
                textAnalyserForm.ShowDialog(); // Показываем окно
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (text != null)
            {
                text = null; // Удаление ссылки на объект
                MessageBox.Show("Объект text удалён.");
            }
            else
            {
                MessageBox.Show("Объект text не существует или уже удалён.");
            }
            UpdateRichTextBox();
        }

        private void UpdateRichTextBox()
        {
            // Очищаем richTextBox1
            richTextBox1.Clear();

            // Проверяем объект text
            if (text != null)
            {
                // Получаем список предложений
                List<Sentence> sentencesList = text.getSentencesList();

                // Если список предложений существует, добавляем их в RichTextBox
                if (sentencesList != null && sentencesList.Count > 0)
                {
                    foreach (Sentence sentence in sentencesList)
                    {
                        richTextBox1.AppendText(sentence.ToString() + " ");
                    }
                }
                else
                {
                    MessageBox.Show("Список предложений пуст.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (text != null)
            {
                using (TextEditorForm textEditorForm = new TextEditorForm(text))
                {
                    textEditorForm.ShowDialog(); // Показываем окно
                }
            }
            else
            {
                MessageBox.Show("Сначала создайте объект класса text!.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
