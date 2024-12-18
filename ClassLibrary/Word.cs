using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Word : TextElement
    {
        public string Value { get; private set; }

        // Метод присвоения текста
        public Word(string value)
        {
            Value = value;
        }

        // Реализация абстрактного метода подсчета букв
        public override int CountLetters()
        {
            return Value.Count(char.IsLetter);
        }

        // Реализация метода для текстового представления
        public override string ToString()
        {
            return Value;
        }

        // Переопределение метода DisplayInfo
        public override void DisplayInfo()
        {
            Console.WriteLine($"Слово: {ToString()}, Количество букв: {CountLetters()}");
        }
    }
}
