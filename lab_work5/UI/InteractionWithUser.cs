using System;
using System.Collections.Generic;
using Parsing;
using System.IO;

namespace UI
{
    /// <summary>
    /// A class that provides methods for interacting with a user
    /// </summary>
    
    class InteractionWithUser
    {
        /// <summary>
        /// Performs a selected by user action
        /// </summary>
        
        public static void StartParsing()
        {
            const int exit = 3;
            int choice = 0;
            List<string> phoneNumbers = new List<string>();
            bool isInput = false;
            while (choice != exit)
            {
                choice = GetChoice();
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        isInput = GetNumbers(phoneNumbers);
                        break;
                    case 2:
                        if (isInput)
                        {
                            ShowResults(phoneNumbers);
                        }
                        else
                            Console.WriteLine("Сначала добавьте номера");
                        break;
                    default:
                        Console.WriteLine("Некоректный ввод");
                        break;
                }
            }
        }

        /// <summary>
        /// Gets the user's choice
        /// </summary>
        /// <returns>User's choice</returns>
        
        static int GetChoice()
        {
            int choice;
            Console.WriteLine("1.Добавить номера\n2.Вывести номера по группам\n3.Выход");
            string input = Console.ReadLine();
            int.TryParse(input, out choice);
            return choice;
        }
        
        /// <summary>
        /// Gets phone numbers
        /// </summary>
        /// <param name="phoneNumbers">Phone numbers</param>
        /// <returns>True if number of phone numbers isn't zero,othrewise - false</returns>
        static bool GetNumbers(List<string> phoneNumbers)
        {
            Console.WriteLine("Выберите:\n1.Получить из файла\n2.Ввести");
            int choice;
            string input = Console.ReadLine();
            int.TryParse(input, out choice);
            switch (choice)
            {
                case 1:
                    ReadFile(phoneNumbers);
                    break;
                case 2:
                    InputNumbers(phoneNumbers);
                    break;
                default:
                    Console.WriteLine("Некоректный ввод");
                    break;
            }
            return phoneNumbers.Count != 0;
        }

        /// <summary>
        /// Reads phone numbers from file
        /// </summary>
        /// <param name="phoneNumbers">Phone numbers</param>
        
        static void ReadFile(List<string> phoneNumbers)
        {
            using (var sr = new StreamReader("numbers.txt"))
            {
                while (!sr.EndOfStream)
                {
                    phoneNumbers.Add(sr.ReadLine());
                }
            }
        }

        /// <summary>
        /// Inputs phone numbers
        /// </summary>
        /// <param name="phoneNumbers">Phone numbers</param>
        
        static void InputNumbers(List<string> phoneNumbers)
        {
            Console.WriteLine("Сколько добавить номеров?");
            int number;
            string input = Console.ReadLine();
            int.TryParse(input, out number);
            for(int i=0; i < number; i++)
            {
                Console.WriteLine("Введите номер:");
                phoneNumbers.Add(Console.ReadLine());
            }
        }

        /// <summary>
        /// Calculates and shows results
        /// </summary>
        /// <param name="phoneNumbers">Initial phone numbers</param>
        
        static void ShowResults(List<string> phoneNumbers)
        {
            List<string> mobileNumbers = new List<string>();
            List<string> homeNumbers = new List<string>();
            List<string> incorrectNumbers = new List<string>();
            PhoneParsing.ParsePhoneNumbers(phoneNumbers, mobileNumbers, homeNumbers, incorrectNumbers);
            Console.WriteLine("Мобильные номера телефонов:");
            if (mobileNumbers.Count != 0)
            {
                foreach (var mobile in mobileNumbers)
                {
                    Console.WriteLine(mobile);
                }
            }
            else
                Console.WriteLine("Пусто");
            Console.WriteLine("Домашние номера телефонов:");
            if (homeNumbers.Count != 0)
            {
                foreach (var home in homeNumbers)
                {
                    Console.WriteLine(home);
                }
            }
            else
                Console.WriteLine("Пусто");
            Console.WriteLine("Некоректные номера телефонов:");
            if (incorrectNumbers.Count != 0)
            {
                foreach (var incorrect in incorrectNumbers)
                {
                    Console.WriteLine(incorrect);
                }
            }
            else
                Console.WriteLine("Пусто");
                
        }
    }
}
