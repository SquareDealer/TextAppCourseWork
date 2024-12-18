using System.IO;
using System.Linq;
using System.Collections.Generic;
using ClassLibrary;

public class Text : ITextOperations
{
    private List<Sentence> Sentences { get; set; } = new List<Sentence>();

    // Добавление предложения в текст
    public void AddSentence(Sentence sentence)
    {
        Sentences.Add(sentence);
    }

    // Удаление предложения из текста
    public void RemoveSentence(Sentence sentence)
    {
        Sentences.Remove(sentence);
    }

    // Реализация метода подсчета гласных
    public int CountVowels(string input)
    {
        return input.Count(c => "AEIOUaeiouАЕЁИОУЫЭЮЯаеёиоуыэюя".Contains(c));
    }

    // Реализация метода подсчета согласных
    public int CountConsonants(string input)
    {
        return input.Count(c => char.IsLetter(c) && !"AEIOUaeiouАЕЁИОУЫЭЮЯаеёиоуыэюя".Contains(c));
    }

    // Реализация метода подсчета всех букв
    public int CountLetters(string input)
    {
        return input.Count(char.IsLetter);
    }

    // Сохранение текста в файл
    public void SaveToFile(string filePath, string content)
    {
        File.WriteAllText(filePath, content);
    }

    // Чтение текста из файла
    public string ReadFromFile(string filePath)
    {
        return File.ReadAllText(filePath);
    }

    // Получение полного текста в виде строки
    public override string ToString()
    {
        return string.Join(" ", Sentences.Select(s => s.ToString()));
    }
}