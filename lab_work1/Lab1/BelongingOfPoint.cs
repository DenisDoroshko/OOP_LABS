using System;

namespace Lab1
{
    /// <summary>
    /// Класс содержащий метод проверяющий принадлежность точки
    /// </summary>
    public class BelongingOfPoint
    {
        /// <summary>
        /// Проверка принадлежности точки и возвращение сообщения
        /// </summary>
        /// <param name="square">
        /// Экземпляр класса Figure
        /// </param>
        public void CheckBelonging(Figure square)
        {
            Console.WriteLine("Введите координаты точки: ");
            int coorinateX = Convert.ToInt32(Console.ReadLine());
            int coorinateY = Convert.ToInt32(Console.ReadLine());
            Point[] points = new Point[4];
            for (int i = 0; i < 4; i++)
            {
                points[i] = new Point();
            }
            points[0].X = square.FirstPointX;
            points[0].Y = square.FirstPointY;
            points[1].X = square.SecondPointX;
            points[1].Y = square.SecondPointY;
            points[2].X = square.ThirdPointX;
            points[2].Y = square.ThirdPointY;
            points[3].X = square.FourthPointX;
            points[3].Y = square.FourthPointY;
            for (int i = 0; i < 4; i++)
            {
                points[i].SumCoordinate = Math.Abs(points[i].X) + Math.Abs(points[i].Y);
            }

            Point tmp;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3 - i; j++)
                {
                    if (points[j + 1].SumCoordinate < points[j].SumCoordinate)
                    {
                        tmp = points[j + 1];
                        points[j + 1] = points[j];
                        points[j] = tmp;
                    }
                }
            }
            double FirstSide = Math.Sqrt(Math.Pow(points[0].X - points[1].X, 2) + Math.Pow(points[0].Y - points[1].Y, 2));
            double SecondSide = Math.Sqrt(Math.Pow(points[1].X - points[2].X, 2) + Math.Pow(points[1].Y - points[2].Y, 2));
            if (SecondSide != FirstSide)
            {
                tmp = points[2];
                points[2] = points[3];
                points[3] = tmp;
            }
           
            bool border = false;
            void CheckBorder(int mark,Point FirstPoint,Point SecondPoint)
            {
                if (mark == 0)
                {
                    if (FirstPoint.X < SecondPoint.X)
                    {
                        if (coorinateX >= FirstPoint.X && coorinateX <= SecondPoint.X)
                            border = true;
                    }
                    else if (FirstPoint.X > SecondPoint.X)
                    {
                        if (coorinateX >= SecondPoint.X && coorinateX <= FirstPoint.X)
                            border = true;
                    }
                    else
                    {
                        if (FirstPoint.Y < SecondPoint.Y)
                        {
                            if (coorinateY >= FirstPoint.Y && coorinateY <= SecondPoint.Y)
                            {
                                border = true;
                            }
                        }
                        else if (coorinateY >= SecondPoint.Y && coorinateY <= FirstPoint.Y)
                        {
                            border = true;
                        }

                    }
                }
            }
            int mark1 = (points[0].Y - points[1].Y) * coorinateX + (points[1].X - points[0].X) * coorinateY + (points[0].X * points[1].Y - points[1].X * points[0].Y);
            CheckBorder(mark1, points[0], points[1]);
            int mark2 = (points[1].Y - points[2].Y) * coorinateX + (points[2].X - points[1].X) * coorinateY + (points[1].X * points[2].Y - points[2].X * points[1].Y);
            CheckBorder(mark2, points[1], points[2]);
            int mark3 = (points[2].Y - points[3].Y) * coorinateX + (points[3].X - points[2].X) * coorinateY + (points[2].X * points[3].Y - points[3].X * points[2].Y);
            CheckBorder(mark3, points[2], points[3]);
            int mark4 = (points[3].Y - points[0].Y) * coorinateX + (points[0].X - points[3].X) * coorinateY + (points[3].X * points[0].Y - points[0].X * points[3].Y);
            CheckBorder(mark4, points[3], points[0]);
            if ((mark1 > 0 && mark2 > 0 && mark3 > 0 && mark4 > 0 )|| (mark1 < 0 && mark2 < 0 && mark3 < 0 && mark4 < 0))
            {
                Console.WriteLine("Точка принадлежит фигуре");
            }
            else if(border)
            {
                Console.WriteLine("Точка лежит на границе фигуры");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит фигуре");
            }
        }
    }
}
