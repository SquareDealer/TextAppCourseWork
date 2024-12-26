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
        public void CapitalizeFirstLetter()
        {
            if (!string.IsNullOrEmpty(Value))
            {
                Value = char.ToUpper(Value[0]) + Value.Substring(1);
            }
        }

        // Переопределение метода DisplayInfo
        public override string DisplayInfo()
        {
            return ($"Слово: {ToString()}, Количество букв: {CountLetters()}");
        }
    }
}
