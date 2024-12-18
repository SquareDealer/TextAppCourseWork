using ClassLibrary;
namespace TextApp
{
    public partial class Form1 : Form
    {
        Text text = new Text();
        List<Sentence> sentenceList = new List<Sentence>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WordsConstuctorForm wordsConstuctorForm = new WordsConstuctorForm();
            // Показываем окно в модальном режиме
            if (wordsConstuctorForm.ShowDialog() == DialogResult.OK)
            {
                // Получаем данные из свойства InputText
                List<Sentence> receivedData = wordsConstuctorForm.sentenceList;
                MessageBox.Show($"Вы ввели: {receivedData[0].DisplayInfo}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Вы отменили ввод.", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
