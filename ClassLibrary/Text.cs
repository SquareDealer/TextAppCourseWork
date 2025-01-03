﻿using System.IO;
using System.Linq;
using System.Collections.Generic;
using ClassLibrary;
using System.Text;

public class Text : ITextOperations
{
    private List<Sentence> Sentences { get; set; } = new List<Sentence>();

    // Конструктор по умолчанию
    public Text() { }

    // Конструктор для инициализации списка предложений
    public Text(IEnumerable<Sentence> sentences)
    {
        Sentences = new List<Sentence>(sentences);
    }

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

    // Получения списка предложений
    public List<Sentence> getSentencesList() { return Sentences; }

    // Реализация метода подсчета гласных
    public int CountVowels(string input)
    {
        return input.Count(c => "AEIOUaeiouАЕЁИОУЫЭЮЯаеёиоуыэюя".Contains(c));
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

    public void SearchByString(string input, string content, StringBuilder result)
    {

    }
}