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

        public string ReadFromFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        public int CountWords(string input)
        {
            return input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public void AnalyzeText(ITextOperations textOperations, string textContent)
        {
            Console.WriteLine($"Анализируемый текст: {textContent}");
            Console.WriteLine($"Гласных: {textOperations.CountVowels(textContent)}");
            Console.WriteLine($"Всего букв: {textOperations.CountLetters(textContent)}");
        }
    }
}
