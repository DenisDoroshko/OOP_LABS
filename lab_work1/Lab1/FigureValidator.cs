using System;

namespace Lab1
{
    /// <summary>
    /// Класс содержащий метод проверки возможности существования фигуры
    /// </summary>
    public class FigureValidator
    {
        /// <summary>
        /// Проверка возможности существования фигуры
        /// </summary>
        /// <param name="Square"></param>
        /// <returns></returns>
        public void ValidateFigure(Figure Square)
        {
            double[] Sides = new double[6];
            Sides[0]= Math.Sqrt(Math.Pow(Square.FirstPointX - Square.SecondPointX,2)+ Math.Pow(Square.FirstPointY - Square.SecondPointY, 2));
            Sides[1] = Math.Sqrt(Math.Pow(Square.FirstPointX - Square.ThirdPointX, 2) + Math.Pow(Square.FirstPointY - Square.ThirdPointY, 2));
            Sides[2] = Math.Sqrt(Math.Pow(Square.FirstPointX - Square.FourthPointX, 2) + Math.Pow(Square.FirstPointY - Square.FourthPointY, 2));
            Sides[3] = Math.Sqrt(Math.Pow(Square.SecondPointX - Square.ThirdPointX, 2) + Math.Pow(Square.SecondPointY - Square.ThirdPointY, 2));
            Sides[4] = Math.Sqrt(Math.Pow(Square.SecondPointX - Square.FourthPointX, 2) + Math.Pow(Square.SecondPointY - Square.FourthPointY, 2));
            Sides[5] = Math.Sqrt(Math.Pow(Square.ThirdPointX - Square.FourthPointX, 2) + Math.Pow(Square.ThirdPointY - Square.FourthPointY, 2));
            double temp;

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5 - i; j++)
                {
                    if (Sides[j + 1] < Sides[j])
                    {
                        temp = Sides[j + 1];
                        Sides[j + 1] = Sides[j];
                        Sides[j] = temp;
                    }
                }
            }
            if (Sides[0]!=0 && Sides[0] == Sides[1] &&Sides[0] == Sides[2] && Sides[0]==Sides[3] && Sides[4]==Sides[5]) 
            {
                Console.WriteLine("Это квадрат");
                Square.FigureValid = true;
            }
            else
            {
                Console.WriteLine("Это не квадрат");
                Square.FigureValid = false;
            }
        }

    }
}
