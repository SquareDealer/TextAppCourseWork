using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TextEditor
    {
        public Text ManagedText { get; private set; }

        // Делегаты
        public delegate void TextModifiedEventHandler(string message);

        // События
        public event TextModifiedEventHandler? SentenceRemoved;
        public event TextModifiedEventHandler? TextFormatted;

        public TextEditor(Text text)
        {
            ManagedText = text;
        }

        public void FormatText()
        {
            // Получаем список предложений из объекта ManagedText
            var sentencesList = ManagedText.getSentencesList();

            if (sentencesList == null || sentencesList.Count == 0)
            {
                throw new InvalidOperationException("Текст пуст или не содержит предложений.");
            }

            foreach (var sentence in sentencesList)
            {
                // Получаем список слов в предложении
                var wordsList = sentence.getWordsList();

                // Проверяем, есть ли слова в предложении
                if (wordsList != null && wordsList.Count > 0)
                {
                    // Делаем первую букву первого слова заглавной
                    wordsList[0].CapitalizeFirstLetter();
                }
            }

            // Уведомляем о завершении форматирования
            TextFormatted?.Invoke("Текст успешно отформатирован: первое слово в каждом предложении стало заглавным.");
        }

        public List<Sentence> getSentencesList() { return ManagedText.getSentencesList(); }

        // Метод для удаления предложения
        public void RemoveSentence(Sentence sentence)
        {
            ManagedText.RemoveSentence(sentence);
            SentenceRemoved?.Invoke($"Предложение удалено: \"{sentence}\"");
        }
    }
}
