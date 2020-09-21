using Lab1;
using System;

namespace ConsoleMenu
{
    /// <summary>
    /// Класс содержащий методы для взаимодействия с пользователем и выполнения операций над фигурой 
    /// </summary>
    public class InteractionWithUser
    {
        /// <summary>
        /// Метод создающий плоскую фигуру по 4 её вершинам
        /// </summary>
        /// <returns>Экземпляр фигуры</returns>
        public Figure CreateFigure()
        {
            Console.WriteLine("Введите координаты первой вершины");
            int FirstX;
            string input = Console.ReadLine();
            CheckInput(input,out FirstX);
            int FirstY;
            input = Console.ReadLine();
            CheckInput(input, out FirstY);
            Console.WriteLine("Введите координаты второй вершины");
            int secondX;
            input = Console.ReadLine();
            CheckInput(input, out secondX);
            int secondY;
            input = Console.ReadLine();
            CheckInput(input, out secondY);
            Console.WriteLine("Введите координаты третьей вершины");
            int thirdX;
            input = Console.ReadLine();
            CheckInput(input, out thirdX);
            int thirdY;
            input = Console.ReadLine();
            CheckInput(input, out thirdY);
            Console.WriteLine("Введите координаты четвертой вершины");
            int fourthX;
            input = Console.ReadLine();
            CheckInput(input, out fourthX);
            int fourthY;
            input = Console.ReadLine();
            CheckInput(input, out fourthY);
            Figure Square = new Figure(FirstX, FirstY, secondX, secondY, thirdX, thirdY, fourthX, fourthY);
            Square.FigureExistence = true;
            Console.WriteLine("Фигура была создана");
            Square.CalculateSides();
            return Square;
        }
        /// <summary>
        /// Метод выполняющий проверку возможности существования фигуры
        /// </summary>
        /// <param name="Square"></param>
        public void CheckExsisting(Figure Square)
        {
            FigureValidator Validator = new FigureValidator();
            Validator.ValidateFigure(Square);
        }
        /// <summary>
        /// Метод вычисляющий выбранный пользователем параметр фигуры
        /// </summary>
        /// <param name="Square"></param>
        public void Calculate(Figure Square)
        {
            Console.WriteLine("Выберите что вычислить(1-3):\n1.Длина стороны\n2.Площадь\n3.Периметр");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Square.CalculateSides();
                    Console.WriteLine($"Длина стороны равна:{Square.LengthSide}");
                    break;
                case 2:
                    Square.CalculateArea();
                    Console.WriteLine($"Площадь фигуры равна:{Square.Area}");
                    break;
                case 3:
                    Square.CalculatePerimeter();
                    Console.WriteLine($"Периметр фигуры равен:{Square.Perimeter}");
                    break;
                default:
                    Console.WriteLine("Ошибка выбора");
                    break;
            }
        }
        /// <summary>
        /// Метод выводящий принадлежность выбранной точки относительно фигуры
        /// </summary>
        /// <param name="Square"></param>
        public void ShowBelonging(Figure Square)
        {
            BelongingOfPoint CheckingPoint = new BelongingOfPoint();
            CheckingPoint.CheckBelonging(Square);
        }

        static int CheckInput(string input,out int coordinate)
        {
            if (int.TryParse(input, out coordinate))
            {
            }
            else
            {
                Console.WriteLine("Некоректный ввод");
            }
            return coordinate;
        }
    }
}
