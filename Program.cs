using System;
using System.IO;
using System.Linq;

class EvenLetterWordsFinder
{
    static void Main()
    {
        string inputFilePath = "input.txt";   // шлях до вхідного файлу
        string outputFilePath = "output.txt"; // шлях до вихідного файлу

        try
        {
            // Зчитування тексту з вхідного файлу
            string text = File.ReadAllText(inputFilePath);
            Console.WriteLine("Текст з файлу input.txt: " + text);

            // Розділення тексту на слова та пошук слів із парною кількістю літер
            var evenLetterWords = text
                .Split(new[] { ' ', '\n', '\r', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(word => word.Length % 2 == 0);

            // Запис результату у вихідний файл
            File.WriteAllLines(outputFilePath, evenLetterWords);

            Console.WriteLine("Слова з парною кількістю літер записані у файл output.txt");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Виникла помилка: " + ex.Message);
        }
    }
}
