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
        public override void DisplayInfo()
        {
            Console.WriteLine($"Предложение: {ToString()}, Количество букв: {CountLetters()}");
        }
    }
}
