using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface ITextOperations
    {
        // Подсчет количества гласных букв
        int CountVowels(string input);

        // Подсчет общего количества букв
        int CountLetters(string input);

        // Сохранение текста в файл
        void SaveToFile(string filePath, string content);

        // Загрузка текста из файла
        string ReadFromFile(string filePath);

        // Поиск строки в тексте
        public void SearchByString(string input, string content, StringBuilder result);
    }
}
