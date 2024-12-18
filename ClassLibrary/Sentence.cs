using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Sentence : TextElement
    {
        private List<Word> Words { get; set; } = new List<Word>();

        public void AddWord(Word word)
        {
            Words.Add(word);
        }
        public void RemoveWord(Word word)
        {
            Words.Remove(word);
        }
        public void RemoveWordByIndex(int index)
        {
            if (index >= 0 && index < Words.Count)
            {
                Words.RemoveAt(index);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Индекс выходит за пределы списка слов.");
            }
        }

        public List<Word> getWordsList() { return Words; }

        // Реализация абстрактного метода подсчета букв
        public override int CountLetters()
        {
            return Words.Sum(w => w.CountLetters());
        }

        // Реализация метода для текстового представления
        public override string ToString()
        {
            return string.Join(" ", Words.Select(w => w.ToString())) + ".";
        }

        // Переопределение метода DisplayInfo
        public override string DisplayInfo()
        {
            return ($"Предложение: {ToString()}, Количество букв: {CountLetters()}");
        }
    }
}
