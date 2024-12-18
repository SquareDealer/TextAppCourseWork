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
            // ���������� ���� � ��������� ������
            if (wordsConstuctorForm.ShowDialog() == DialogResult.OK)
            {
                // �������� ������ �� �������� InputText
                List<Sentence> receivedData = wordsConstuctorForm.sentenceList;
                MessageBox.Show($"�� �����: {receivedData[0].DisplayInfo}", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("�� �������� ����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
