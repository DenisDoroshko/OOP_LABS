using System;

namespace Matrixes
{
    /// <summary>
    /// Представляет матрицу вещественных чисел
    /// </summary>
    public class Matrix
    {
        private double[,] numbers;
        private int numberRows;
        private int numberColumns;
        /// <summary>
        /// Двумерный массив вещественных чисел
        /// </summary>
        public double[,] Numbers
        {
            get { return numbers; }

        }
        /// <summary>
        /// Количество строк
        /// </summary>
        public int NumberRows
        {
            get { return numberRows; }
        }
        /// <summary>
        /// Количесво столбов
        /// </summary>
        public int NumberColumns
        {
            get { return numberColumns; }
        }
        /// <summary>
        /// Создает экземпляр матрицы
        /// </summary>
        /// <param name="NumberRows">Количество строк</param>
        /// <param name="NumberColumns">Количество столбцов</param>
        /// <param name="Numbers">Двумерный массив вещественных чисел</param>
        public Matrix(int NumberRows, int NumberColumns, double[,] Numbers)
        {
            numberRows = NumberRows;
            numberColumns = NumberColumns;
            numbers = Numbers;
        }
        /// <summary>
        /// Создает экземпляр матрицы
        /// </summary>
        public Matrix()
        {

        }
        /// <summary>
        /// Вводит матрицу
        /// </summary>
        /// <returns>Была ли введена матрица</returns>
        public bool InputMatrix()
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
                    numbers = tempMassiv;
                    numberRows = rows;
                    numberColumns = columns;
                }
                else
                {
                    resultInput = false;
                }
            }
            else
            {
                Console.WriteLine("Некоректный ввод количества строк-столбцов");
            }
            return resultInput;
        }
        /// <summary>
        /// Выводит матрицу
        /// </summary>
        public void ShowMatrix()
        {
            for (int i = 0; i < numberRows; i++)
            {
                for (int j = 0; j < numberColumns; j++)
                {
                    Console.Write($"{numbers[i, j]} ");
                }
                Console.Write("\n");
            }
        }
        /// <summary>
        /// Вычисляет сумму квадратов элементов матрицы больших заданного числа
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Сумма квадратов</returns>
        public double CalculateSumSquares(double number)
        {
            double sum = 0;
            for (int i = 0; i < numberRows; i++)
            {
                for (int j = 0; j < numberColumns; j++)
                {
                    if (numbers[i, j] > number)
                    {
                        sum += Math.Pow(numbers[i, j], 2);
                    }
                }
            }
            return sum;
        }
        /// <summary>
        /// Вычисляет сумму квадратов элементов расположенных после заданного элемента
        /// </summary>
        /// <param name="row">Строка заданного элемента</param>
        /// <param name="column">Столбец заданного элемента</param>
        /// <returns>Сумма квадартов</returns>
        public double CalculateSumSquares(int row, int column)
        {
            double sum = 0;
            row -= 1;
            for (int i = row; i < numberRows; i++)
            {
                for (int j = column; j < numberColumns; j++)
                {
                    sum += Math.Pow(numbers[i, j], 2);
                }
                column = 0;
            }
            return sum;
        }
        /// <summary>
        /// Вичисляет произведение двух матриц
        /// </summary>
        /// <param name="firstMatrix">Первая исходная матрица</param>
        /// <param name="secondMatrix">Вторая исходная матрица</param>
        /// <param name="resultMatrix">Новая матрица являющаяся результатом произведения</param>
        /// <returns>Умножены ли матрицы</returns>
        public static bool ScalarMultiple(Matrix firstMatrix, Matrix secondMatrix, ref Matrix resultMatrix)
        {
            int indexColumn;
            bool resultOperation = false;
            if (firstMatrix.NumberColumns == secondMatrix.NumberRows)
            {
                double[,] tempMassiv = new double[firstMatrix.NumberRows, secondMatrix.NumberColumns];
                resultMatrix.numbers = tempMassiv;
                resultMatrix.numberRows = firstMatrix.NumberRows;
                resultMatrix.numberColumns = secondMatrix.NumberColumns;
                for (int i = 0; i < firstMatrix.NumberRows; i++)
                {
                    indexColumn = 0;
                    while (indexColumn < secondMatrix.NumberColumns)
                    {
                        for (int j = 0; j < firstMatrix.NumberColumns; j++)
                        {
                            resultMatrix.Numbers[i, indexColumn] += firstMatrix.Numbers[i, j] * secondMatrix.Numbers[j, indexColumn];
                        }
                        indexColumn++;
                    }

                }
                resultOperation = true;
            }
            return resultOperation;
        }
        /// <summary>
        /// Перегрузка оператора отношения двух матриц
        /// </summary>
        /// <param name="firstMatrix">Первая матрица</param>
        /// <param name="secondMatrix">Вторая матрица</param>
        /// <returns>Возвращает истину если матрицы равны</returns>
        public static bool operator == (Matrix firstMatrix, Matrix secondMatrix)
        {
            return firstMatrix.Equals(secondMatrix);
        }
        /// <summary>
        /// Перегрузка оператора отношения двух матриц
        /// </summary>
        /// <param name="firstMatrix">Первая матрица</param>
        /// <param name="secondMatrix">Вторая матрица</param>
        /// <returns>Возвращает истину если матрицы не равны</returns>
        public static bool operator !=(Matrix firstMatrix, Matrix secondMatrix)
        {
            return !firstMatrix.Equals(secondMatrix);
        }
        /// <summary>
        /// Переопределение матода Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Значение true, если заданный объект равен текущему; в противном случае - значение false</returns>
        public override bool Equals(object obj)
        {
            if(obj == null || GetType()!= obj.GetType())
            {
                return false;
            }
            else
            {
                Matrix checkMatrix = (Matrix)obj;
                if (numberRows != checkMatrix.NumberRows || numberColumns != checkMatrix.NumberColumns)
                {
                    return false;
                }    
                else
                {
                    for(int i=0; i < numberRows; i++)
                    {
                        for(int j=0; j <numberColumns; j++)
                        {
                            if (numbers[i, j] != checkMatrix.Numbers[i, j])
                                return false;
                        }
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Переопределение метода GetHashCode вычисляющего хеш-код текущего объекта
        /// </summary>
        /// <returns>Хеш-код текущего объекта</returns>
        public override int GetHashCode()
        {
            return numberRows * numberColumns /2 ;
        }
    }
}
