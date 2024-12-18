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
        public event TextModifiedEventHandler? SentenceAdded;
        public event TextModifiedEventHandler? SentenceRemoved;

        public TextEditor(Text text)
        {
            ManagedText = text;
        }

        // Метод для добавления предложения
        public void AddSentence(Sentence sentence)
        {
            ManagedText.AddSentence(sentence);
            SentenceAdded?.Invoke($"Предложение добавлено: \"{sentence}\"");
        }

        // Метод для удаления предложения
        public void RemoveSentence(Sentence sentence)
        {
            ManagedText.RemoveSentence(sentence);
            SentenceRemoved?.Invoke($"Предложение удалено: \"{sentence}\"");
        }
    }

}
