using System;
using Matrixes;

namespace UserInterface
{
    /// <summary>
    /// Класс хранящий методы взаимодействия с пользователем
    /// </summary>
    public class InteractionMethods
    {
        /// <summary>
        /// Выпополняет действия в соответствии с выбором пользователя
        /// </summary>
        public static void ShowMenu()
        {
            int choice;
            bool inputStatus=false;
            Matrix matrixA = new Matrix();
            Matrix matrixB = new Matrix();
            Matrix matrixC = new Matrix();
            while ((choice = InputChoice()) != 6)
            {
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        bool inputResult=true;
                        Console.WriteLine("Ввод матрицы А:");
                        if (!matrixA.InputMatrix())
                            inputResult = false;
                        Console.WriteLine("Ввод матрицы B:");
                        if (!matrixB.InputMatrix())
                            inputResult = false;
                        Console.WriteLine("Ввод матрицы C:");
                        if (!matrixC.InputMatrix())
                            inputResult = false;
                        if (inputResult)
                            inputStatus = true;
                        else
                            Console.WriteLine("Матрицы не были добавлены");
                        break;
                    case 2:
                        if (inputStatus)
                        {
                            Console.WriteLine("Матрица А:");
                            matrixA.ShowMatrix();
                            Console.WriteLine("Матрица B:");
                            matrixB.ShowMatrix();
                            Console.WriteLine("Матрица C:");
                            matrixC.ShowMatrix();
                        }
                        else
                            Console.WriteLine("Нужно ввести матрицы");
                        
                        break;
                    case 3:
                        if (inputStatus)
                        {
                            double resultSum = CalculateNumberSumSquares(matrixA, matrixB);
                            Console.WriteLine($"Сумма квадратов элементов матриц А и В больших 83.6 :{resultSum}");
                        }
                        else
                            Console.WriteLine("Нужно ввести матрицы");
                        break;
                    case 4:
                        if (inputStatus)
                        {
                            double result = CalculateLocatedSumSquares(matrixA, matrixB, matrixC);
                            if (result != 0)
                                Console.WriteLine($"Сумма квадратов элементов матриц А и В больших 83.6:{result}");
                            else
                                Console.WriteLine($"Некоректный выбор элемента");
                        }
                        else
                            Console.WriteLine("Нужно ввести матрицы");
                        break;
                    case 5:
                        if (inputStatus)
                        {
                            if (ReplaceNegativeNumbers(ref matrixA, ref matrixB, ref matrixC))
                                Console.WriteLine($"Матрицы равны поэтому заменены отрицательные элементы в последнем столбце");
                            else
                            {
                                Matrix resultProduction = new Matrix();
                                if (Matrix.ScalarMultiple(matrixC, matrixB, ref resultProduction))
                                {
                                    Console.WriteLine("Результат произведения С*В:");
                                    resultProduction.ShowMatrix();
                                }
                                else
                                    Console.WriteLine("Произведение C на B невозможно");
                            }
                                
                            Console.WriteLine($"Матрицы не равны,результат произведения");
                        }
                        else
                            Console.WriteLine("Нужно ввести матрицы");
                        break;
                    default:
                        Console.WriteLine("Некоректный ввод");
                        break;
                }
            }
        }
        /// <summary>
        /// Предлагает пользователю сделать выбор
        /// </summary>
        /// <returns>Выбор пользователя</returns>
        static int InputChoice()
        {
            int choice;
            Console.WriteLine("Выберите:\n1.Ввести матрицы\n2.Вывести матрицы\n" +
                "3.Вычисление и вывод суммы квадратов элементов матриц A и B, больших 83.6\n" +
                "4. Вычисление и вывод суммы квадратов элементов матриц С и В*А,расположенных после заданного элемента\n" +
                "5.Если А=В=С, заменить нулями все отрицательные элементы последнего столбца в каждой матрице, в противном случае " +
                "\nвычислить С*В, если это возможно\n6.Выход");
            string input = Console.ReadLine();
            int.TryParse(input, out choice);
            return choice;
        }
        /// <summary>
        /// Вычисляет сумму квадратов элементов матрицы больших числа 83.6
        /// </summary>
        /// <param name="A">Первая матрица</param>
        /// <param name="B">Вторая матрица</param>
        /// <returns>Сумма сумм квадратов двух матриц</returns>
        public static double CalculateNumberSumSquares(Matrix A,Matrix B)
        {
            return A.CalculateSumSquares(83.6) + B.CalculateSumSquares(83.6);
        }
        /// <summary>
        /// Вычисляет сумму квадратов элементов матрицы расположенных после заданного элемента
        /// </summary>
        /// <param name="A">Первая матрица</param>
        /// <param name="B">Вторая матрица</param>
        /// <param name="C">Третья матрица</param>
        /// <returns>Сумма сумм квадратов</returns>
        public static double CalculateLocatedSumSquares(Matrix A,Matrix B, Matrix C)
        {
            int row;
            int column;
            Matrix resultProduction = new Matrix();
            Matrix.ScalarMultiple(B, A,ref resultProduction);
            Console.WriteLine("Введите номер строки элемента");
            int.TryParse(Console.ReadLine(), out row);
            Console.WriteLine("Введите номер столбца элемента");
            int.TryParse(Console.ReadLine(), out column);
            if(row == 0 || column == 0 || row > resultProduction.NumberRows || column > resultProduction.NumberColumns 
                || row > C.NumberRows || column > C.NumberColumns)
            {
                return 0;
            }
            else
            {
                return resultProduction.CalculateSumSquares(row, column)+C.CalculateSumSquares(row, column);
            }
        }
        /// <summary>
        /// Если матрицы равны заменяет отрицательные элементы последнего столбца нулями
        /// </summary>
        /// <param name="A">Первая матрица</param>
        /// <param name="B">Вторая матрица</param>
        /// <param name="C">Третья матрица</param>
        /// <returns>Равны ли три матрицы</returns>
        public static bool ReplaceNegativeNumbers(ref Matrix A,ref Matrix B,ref Matrix C)
        {
            bool result = false;
            if (A == B && A == C)
            {
                for (int i = 0; i < A.NumberRows; i++)
                {
                    if (A.Numbers[i, A.NumberColumns - 1] < 0)
                        A.Numbers[i, A.NumberColumns - 1] = 0;
                    if (B.Numbers[i, B.NumberColumns - 1] < 0)
                        B.Numbers[i, B.NumberColumns - 1] = 0;
                    if (C.Numbers[i, C.NumberColumns - 1] < 0)
                        C.Numbers[i, C.NumberColumns - 1] = 0;
                }
                result = true;
            }
            return result;        
        }
    }
}
