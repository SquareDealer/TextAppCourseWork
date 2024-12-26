using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TextAnalyzer : ITextOperations
    {
        public int CountVowels(string input)
        {
            return input.Count(c => "AEIOUaeiouАЕЁИОУЫЭЮЯаеёиоуыэюя".Contains(c));
        }

        public int CountLetters(string input)
        {
            return input.Count(char.IsLetter);
        }

        public void SaveToFile(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
        }

        public void SearchByString(string input, string content, StringBuilder result)
        {
            // Поиск всех вхождений строки input в content
            int count = 0;
            int index = 0;
            while ((index = content.IndexOf(input, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                count++;
                index += input.Length;
            }

            // Добавление результата в StringBuilder
            result.AppendLine($"Количество вхождений '{input}': {count}");
        }

        public string ReadFromFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        public int CountWords(string input)
        {
            return input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public string AnalyzeText(ITextOperations textOperations, string textContent, bool searchModeEnabled, string searchString = "")
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Анализируемый текст: {textContent}");
            result.AppendLine($"Гласных: {textOperations.CountVowels(textContent)}");
            result.AppendLine($"Всего букв: {textOperations.CountLetters(textContent)}");

            if (searchModeEnabled && !string.IsNullOrEmpty(searchString))
            {
                // Если включен режим поиска, вызываем метод для поиска
                textOperations.SearchByString(searchString, textContent, result);
            }

            return result.ToString();
        }
    }
}
