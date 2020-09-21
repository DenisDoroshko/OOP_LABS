using System;

namespace Lab1
{
    /// <summary>
    /// Класс представляющий собой плоскую фигуру
    /// </summary>
    public class Figure
    {
        /// <summary>
        /// Периметр фигуры
        /// </summary>
        public double Perimeter { get; set; }
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Area { get; set; }
        /// <summary>
        /// Длина стороны фигуры
        /// </summary>
        public double LengthSide { get; set; }
        /// <summary>
        /// X-координата первой вершины фигуры
        /// </summary>
        public int FirstPointX { get; set; }
        /// <summary>
        /// Y-координата первой вершины фигуры
        /// </summary>
        public int FirstPointY { get; set; }
        /// <summary>
        /// X-координата второй вершины фигуры
        /// </summary>
        public int SecondPointX { get; set; }
        /// <summary>
        /// X-координата второй вершины фигуры
        /// </summary>
        public int SecondPointY { get; set; }
        /// <summary>
        /// X-координата третьей вершины фигуры
        /// </summary>
        public int ThirdPointX { get; set; }
        /// <summary>
        /// Y-координата третьей вершины фигуры
        /// </summary>
        public int ThirdPointY { get; set; }
        /// <summary>
        /// X-координата четвертой вершины фигуры
        /// </summary>
        public int FourthPointX { get; set; }
        /// <summary>
        /// Y-координата четвертой вершины фигуры
        /// </summary>
        public int FourthPointY { get; set; }
        /// <summary>
        /// Существует ли фигура
        /// </summary>
        public bool FigureValid { get; set; } = false;
        /// <summary>
        /// Создана ли фигура
        /// </summary>
        public bool FigureExistence { get; set; } = false;
        /// <summary>
        /// Метод вычисляющий значение длины стороны
        /// </summary>
        public void CalculateSides()
        {
            double[] Sides = new double[6];
            Sides[0] = Math.Sqrt(Math.Pow(FirstPointX - SecondPointX, 2) + Math.Pow(FirstPointY - SecondPointY, 2));
            Sides[1] = Math.Sqrt(Math.Pow(FirstPointX - ThirdPointX, 2) + Math.Pow(FirstPointY - ThirdPointY, 2));
            Sides[2] = Math.Sqrt(Math.Pow(FirstPointX - FourthPointX, 2) + Math.Pow(FirstPointY - FourthPointY, 2));
            Sides[3] = Math.Sqrt(Math.Pow(SecondPointX - ThirdPointX, 2) + Math.Pow(SecondPointY - ThirdPointY, 2));
            Sides[4] = Math.Sqrt(Math.Pow(SecondPointX - FourthPointX, 2) + Math.Pow(SecondPointY - FourthPointY, 2));
            Sides[5] = Math.Sqrt(Math.Pow(ThirdPointX - FourthPointX, 2) + Math.Pow(ThirdPointY - FourthPointY, 2));
            double tmp;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    if (Sides[j + 1] < Sides[j])
                    {
                        tmp = Sides[j + 1];
                        Sides[j + 1] = Sides[j];
                        Sides[j] = tmp;
                    }
                }
            }
            LengthSide = Math.Round(Sides[0],3);
        }
        /// <summary>
        /// Метод вычисляющий площадь фигуры
        /// </summary>
        public void CalculateArea()
        {
            Area = Math.Pow(LengthSide, 2);
        }
        /// <summary>
        /// Метод вычисляющий периметр фигуры
        /// </summary>
        public void CalculatePerimeter()
        {
            Perimeter = LengthSide * 4;
        }
        /// <summary>
        /// Инициализирует новый экземпляр класса
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="x3"></param>
        /// <param name="y3"></param>
        /// <param name="x4"></param>
        /// <param name="y4"></param>
        public Figure(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            FirstPointX = x1;
            FirstPointY = y1;
            SecondPointX = x2;
            SecondPointY = y2;
            ThirdPointX = x3;
            ThirdPointY = y3;
            FourthPointX = x4;
            FourthPointY = y4;
        }
        /// <summary>
        /// Инициализирует новый экземпляр класса
        /// </summary>
        public Figure()
        {

        }
    }
}
