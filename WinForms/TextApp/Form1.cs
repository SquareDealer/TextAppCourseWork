using ClassLibrary;
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
                    MessageBox.Show($"Вы ввели: {receivedData[0].DisplayInfo()}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                foreach (Sentence sentence in receivedData)
                {
                    text.AddSentence(sentence);
                }
                string textRepresentation = text.ToString(); // Сохраните строковое представление
                richTextBox1.Text = textRepresentation;
                MessageBox.Show($"Список предложений пуст или не изменён. {textRepresentation}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void saveTextBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
