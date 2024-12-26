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
using static System.Net.Mime.MediaTypeNames;

namespace TextApp
{
    public partial class TextEditorForm : Form
    {
        TextEditor editor;
        public TextEditorForm(Text ManagedText)
        {
            InitializeComponent();
            editor = new TextEditor(ManagedText);

            editor.SentenceRemoved += OnSentenceRemoved;
            editor.TextFormatted += OnTextFormatted;

            UpdateTextBox();
        }

        private void OnSentenceRemoved(string message)
        {
            MessageBox.Show(message, "Удалено предложение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateTextBox(); // Обновляем содержимое RichTextBox
        }

        private void OnTextFormatted(string message)
        {
            MessageBox.Show(message, "Текст форматирован", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateTextBox(); // Обновляем содержимое RichTextBox
        }

        private void formatTextBtn_Click(object sender, EventArgs e)
        {
            editor.FormatText();
            UpdateTextBox();
        }

        private void UpdateTextBox()
        {
            // Очищаем richTextBox1
            richTextBox1.Clear();

            // Проверяем объект text
            if (editor != null)
            {
                // Получаем список предложений
                List<Sentence> sentencesList = editor.getSentencesList();

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
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteSentenceBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int index))
            {
                // Получаем список предложений
                List<Sentence> sentencesList = editor.ManagedText.getSentencesList();

                if (sentencesList != null && index >= 0 && index < sentencesList.Count)
                {
                    // Удаляем предложение через TextEditor, чтобы событие SentenceRemoved сработало
                    editor.RemoveSentence(sentencesList[index]);

                    // Обновляем RichTextBox после удаления
                    UpdateTextBox();
                }
                else
                {
                    MessageBox.Show("Указанный индекс выходит за пределы списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите корректный числовой индекс.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
