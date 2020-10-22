using System;
using System.Text;

namespace StringProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            int exit = 4;
            int choice = 0;
            while (choice != exit)
            {
                choice = GetChoice();
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите исходную  строку для подсчета ");
                        string initialString = Console.ReadLine();
                        Console.WriteLine("Введите слово, которое искать ");
                        string searchedWord = Console.ReadLine();
                        int result = StringProcessor.CountWord(initialString, searchedWord);
                        Console.WriteLine($"Найденных слов в строке: {result}");
                        break;
                    case 2:
                        Console.WriteLine("Введите исходный текст ");
                        string inputedText = Console.ReadLine();
                        StringBuilder[] russianSentences = StringProcessor.ExtractRussian(inputedText);
                        foreach (StringBuilder sentence in russianSentences)
                        {
                            Console.WriteLine(sentence);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Введите исходный текст ");
                        string text = Console.ReadLine();
                        Console.WriteLine(StringProcessor.ParseSymbols(text));
                        break;
                    default:
                        Console.WriteLine("Ошибка ввода");
                        break;
                }
            }
        }
        static int GetChoice()
        {
            int choice;
            Console.WriteLine("Выберите:\n1.Определить сколько раз в заданной строке встречается заданное слово\n" +
                "2.Задать текст содержащий предложения на русском и английском языках,выделить русские предложения\n3.В заданном тексте убрать буквы и цифры\n4.Выход");
            string input = Console.ReadLine();
            int.TryParse(input, out choice);
            return choice;
        }
    }
}
