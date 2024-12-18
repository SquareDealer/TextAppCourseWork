using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();

            TextAnalyzer analyzer = new TextAnalyzer();
            analyzer.AnalyzeText(text, text.ToString());

            string filePath = "text.txt";
            text.SaveToFile(filePath, text.ToString());
            string loadedText = analyzer.ReadFromFile(filePath);
            analyzer.AnalyzeText(analyzer, loadedText);
        }
    }
}
