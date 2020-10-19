using System;
using Matrixes;

namespace UserInterface
{
    /// <summary>
    /// A class that stores user interaction methods
    /// </summary>
    public class InteractionMethods
    {
        /// <summary>
        /// Performs actions according to the user's choice
        /// </summary>
        public static void ShowMenu()
        {
            const int exit = 6;
            bool inputStatus = false;
            Matrix matrixA = new Matrix();
            Matrix matrixB = new Matrix();
            Matrix matrixC = new Matrix();
            int choice = 0;
            while (choice != exit)
            {
                choice = InputChoice();
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        bool inputResult = true;
                        Console.WriteLine("Ввод матрицы А:");
                        if (!InputMatrix(ref matrixA))
                            inputResult = false;
                        Console.WriteLine("Ввод матрицы B:");
                        if (!InputMatrix(ref matrixB))
                            inputResult = false;
                        Console.WriteLine("Ввод матрицы C:");
                        if (!InputMatrix(ref matrixC))
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
                            ShowMatrix(matrixA);
                            Console.WriteLine("Матрица B:");
                            ShowMatrix(matrixB);
                            Console.WriteLine("Матрица C:");
                            ShowMatrix(matrixC);
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
                                Console.WriteLine($"Сумма квадратов элементов матриц С и В*А расположенных после заданного элемента:{result}");
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
                                    Console.WriteLine("Матрицы не равны,результат произведения С*В:");
                                    ShowMatrix(resultProduction);
                                }
                                else
                                    Console.WriteLine("Матрицы не равны,произведение C на B невозможно");
                            }
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
        /// Prompts to user to make a choice
        /// </summary>
        /// <returns>User selection</returns>

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
        /// Inputes a matrix
        /// </summary>
        /// <returns>The value is true if the matrix input was completed correctly; otherwise, the value is false</returns>

        public static bool InputMatrix(ref Matrix matrix)
        {
            int rows;
            int columns;
            bool resultInput = true;
            Console.WriteLine("Введите количество строк матрицы ");
            int.TryParse(Console.ReadLine(), out rows);
            Console.WriteLine("Введите количество столбцов матрицы ");
            int.TryParse(Console.ReadLine(), out columns);
            if (rows > 0 && columns > 0)
            {
                double[,] tempMassiv = new double[rows, columns];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.WriteLine($"Введите элемент {i + 1}-строки {j + 1}-столбца ");
                        if (!double.TryParse(Console.ReadLine(), out tempMassiv[i, j]))
                        {
                            Console.WriteLine("Некоректный ввод");
                            resultInput = false;
                        }
                    }
                }
                if (resultInput)
                {
                    matrix.Numbers = tempMassiv;
                    matrix.NumberRows = rows;
                    matrix.NumberColumns = columns;
                }
            }
            else
            {
                Console.WriteLine("Некоректный ввод количества строк-столбцов");
                resultInput = false;
            }
            return resultInput;
        }

        /// <summary>
        /// Outputs the matrix
        /// </summary>

        public static void ShowMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.NumberRows; i++)
            {
                for (int j = 0; j < matrix.NumberColumns; j++)
                {
                    Console.Write($"{matrix.Numbers[i, j]} ");
                }
                Console.Write("\n");
            }
        }

        /// <summary>
        ///Calculates the sum of squares of matrix elements of large numbers 83.6
        /// </summary>
        /// <param name="A">The first matrix</param>
        /// <param name="B">The second matrix</param>
        /// <returns>Sum of sums of squares of two matrices</returns>

        public static double CalculateNumberSumSquares(Matrix A, Matrix B)
        {
            return A.CalculateSumSquares(83.6) + B.CalculateSumSquares(83.6);
        }

        /// <summary>
        /// Calculates the sum of squares of matrix elements located after the specified element
        /// </summary>
        /// <param name="A">The first matrix</param>
        /// <param name="B">The second matrix</param>
        /// <param name="C">The third matrix</param>
        /// <returns>Sum of square sums</returns>

        public static double CalculateLocatedSumSquares(Matrix A, Matrix B, Matrix C)
        {
            int row;
            int column;
            Matrix resultProduction = new Matrix();
            Matrix.ScalarMultiple(B, A, ref resultProduction);
            Console.WriteLine("Введите номер строки элемента");
            int.TryParse(Console.ReadLine(), out row);
            Console.WriteLine("Введите номер столбца элемента");
            int.TryParse(Console.ReadLine(), out column);
            if (row == 0 || column == 0 || row > resultProduction.NumberRows || column > resultProduction.NumberColumns
                || row > C.NumberRows || column > C.NumberColumns)
            {
                return 0;
            }
            else
            {
                return resultProduction.CalculateSumSquares(row, column) + C.CalculateSumSquares(row, column);
            }
        }

        /// <summary>
        /// If the matrices are equal replaces the negative elements of the last column with zeros
        /// </summary>
        /// <param name="A">The first matrix</param>
        /// <param name="B">The second matrix</param>
        /// <param name="C">The third matrix</param>
        /// <returns>True if the matrices are equal; otherwise, false</returns>

        public static bool ReplaceNegativeNumbers(ref Matrix A, ref Matrix B, ref Matrix C)
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
