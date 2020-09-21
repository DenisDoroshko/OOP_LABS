using Lab1;
using System;
using System.Runtime.ConstrainedExecution;

namespace ConsoleMenu
{
    /// <summary>
    /// Класс предоставляющий интерфейс пользователя
    /// </summary>
    public class MenuOfApplication
    {
        /// <summary>
        /// Метод выполняющий определенные действия в соответствии с выбором пользователя
        /// </summary>
        public void ShowMenu()
        {
            int choice;
            InteractionWithUser Menu = new InteractionWithUser();
            Figure square = new Figure();
            while ((choice = MakeChoice()) != 5)
            {
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        square = Menu.CreateFigure();
                        break;
                    case 2:
                        if (square.FigureExistence)
                        {
                            Menu.CheckExsisting(square);
                        }
                        else
                        {
                            Console.WriteLine("Создайте фигуру");
                        }
                        break;
                    case 3:
                        if (square.FigureExistence && square.FigureValid)
                        {
                            Menu.Calculate(square);
                        }
                        else
                        {
                            Console.WriteLine("Фигура не создана либо не является квадратом");
                        }
                        break;
                    case 4:
                        if (square.FigureExistence && square.FigureValid)
                        {
                            Menu.ShowBelonging(square);
                        }
                        else
                        {
                            Console.WriteLine("Фигура не создана либо не является квадратом");
                        }
                        break;
                    default:
                        Console.WriteLine("Ошибка выбора");
                        break;
                }
                
            }
            
        }
        /// <summary>
        /// Метод предлагающий пользователю сделать выбор
        /// </summary>
        /// <returns>Номер выбранного пункта меню</returns>
        static int MakeChoice()
        {
            int choice;
            Console.WriteLine("Выберите:\n1.Создать фигуру\n2.Проверить возможность существования фигуры" +
                "\n3.Вычисление параметров фигуры\n4.Проверить принадлежность точки\n5.Выход\n");
            string input = Console.ReadLine();
            if (int.TryParse(input, out choice))
            {
            }
            return choice;
        }
       
    }
}
