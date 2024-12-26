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
    public partial class WordsConstuctorForm : Form
    {
        public List<Sentence> sentenceList = new List<Sentence>();
        public Sentence newSentence = new Sentence();
        public WordsConstuctorForm()
        {
            InitializeComponent();
        }

        private void addWordBtn_Click(object sender, EventArgs e)
        {

            string wordString = addSentenceTextBox.Text;
   

            Word word = new Word(wordString);
            newSentence.AddWord(word);
            //richTextBox1.Text += word.Value.ToString();
            UpdateRichTextBox();
            addSentenceTextBox.Clear();
            updateIndexPickerComboBox();
        }

        private void addSentenceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteSentenceByIndexBtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateRichTextBox()
        {
            richTextBox1.Clear();
            indexPickerComboBox.SelectedIndex = -1;
            List<Word> wordsList = newSentence.getWordsList();
            foreach (Word word in wordsList)
            {
                richTextBox1.AppendText(word.Value + " ");
            }

        }

        private void indexPickerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void autoSpaceCBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void updateIndexPickerComboBox()
        {
            indexPickerComboBox.Items.Clear();

            List<Word> wordsList = newSentence.getWordsList();

            for (int i = 0; i < wordsList.Count; i++)
            {
                indexPickerComboBox.Items.Add($"{i}: {wordsList[i].Value}");
            }
        }

        private void createSentenceBtn_Click(object sender, EventArgs e)
        {
            if (newSentence != null && newSentence.getWordsList().Count > 0)
            {
                sentenceList.Add(newSentence); // Добавляем новое предложение в список
                MessageBox.Show($"Предложение успешно сохранено! {newSentence.DisplayInfo()}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox2.AppendText(newSentence.DisplayInfo() + '\n');

                // Создаем новый объект предложения для дальнейшего ввода
                newSentence = new Sentence();
                UpdateRichTextBox(); // Обновляем отображение интерфейса
                updateIndexPickerComboBox(); // Обновляем ComboBox
            }
            else
            {
                MessageBox.Show("Предложение пустое. Добавьте хотя бы одно слово перед сохранением.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteWordByIndexBtn_Click(object sender, EventArgs e)
        {
            int wordIndex = indexPickerComboBox.SelectedIndex;
            newSentence.RemoveWordByIndex(wordIndex);
            UpdateRichTextBox();
            updateIndexPickerComboBox();
        }

        private void indexPickerComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void WordsConstuctorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Проверяем причину закрытия формы
            if (this.DialogResult != DialogResult.OK && e.CloseReason == CloseReason.UserClosing)
            {
                // Устанавливаем значение DialogResult как OK (или другой нужный результат)
                this.DialogResult = DialogResult.OK;
            }
        }

        private void autoSpaceCBox_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
