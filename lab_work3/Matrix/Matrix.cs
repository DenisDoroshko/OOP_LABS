using System;

namespace Matrixes
{
    /// <summary>
    /// Represents a matrix of real numbers
    /// </summary>

    public class Matrix
    {
        private double[,] numbers;
        private int numberRows;
        private int numberColumns;

        /// <summary>
        /// Two-dimensional array of real numbers
        /// </summary>

        public double[,] Numbers
        {
            get { return numbers; }
            set { numbers = value; }

        }

        /// <summary>
        /// Number of rows
        /// </summary>

        public int NumberRows
        {
            get { return numberRows; }
            set { numberRows = value; }
        }

        /// <summary>
        /// Number of columns
        /// </summary>

        public int NumberColumns
        {
            get { return numberColumns; }
            set { numberColumns = value; }
        }

        /// <summary>
        /// Creates an instance of the matrix
        /// </summary>
        /// <param name="NumberRows">Number of lines</param>
        /// <param name="NumberColumns">Number of columns</param>
        /// <param name="Numbers">Two-dimensional array of real numbers</param>

        public Matrix(int NumberRows, int NumberColumns, double[,] Numbers)
        {
            numberRows = NumberRows;
            numberColumns = NumberColumns;
            numbers = Numbers;
        }

        /// <summary>
        /// Creates an instance of the matrix
        /// </summary>

        public Matrix()
        {

        }

        /// <summary>
        /// Calculates the sum of squares of matrix elements larger than the specified number
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Sum of squares</returns>

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
        /// Calculates the sum of squares of elements located after the specified element
        /// </summary>
        /// <param name="row">Row number of the specified element</param>
        /// <param name="column">Column number of the specified element</param>
        /// <returns>Sum of squares</returns>

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
        /// Calculates the product of two matrices
        /// </summary>
        /// <param name="firstMatrix">The first source matrix</param>
        /// <param name="secondMatrix">The second source matrix</param>
        /// <param name="resultMatrix">A new matrix that is the result of the product</param>
        /// <returns>The value is true if the work was completed correctly; otherwise, the value is false</returns>

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
        /// Operator overloading is the relationship between the two matrices
        /// </summary>
        /// <param name="firstMatrix">The first matrix</param>
        /// <param name="secondMatrix">The second matrix</param>
        /// <returns>True if the matrices are equal; otherwise, false</returns>

        public static bool operator ==(Matrix firstMatrix, Matrix secondMatrix)
        {
            return firstMatrix.Equals(secondMatrix);
        }

        /// <summary>
        /// Operator overloading is the relationship between the two matrices
        /// </summary>
        /// <param name="firstMatrix">The first matrix</param>
        /// <param name="secondMatrix">The second matrix</param>
        /// <returns>True if the matrices are not equal; otherwise, false</returns>

        public static bool operator !=(Matrix firstMatrix, Matrix secondMatrix)
        {
            return !firstMatrix.Equals(secondMatrix);
        }

        /// <summary>
        /// Redefining the Equals method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false</returns>

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
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
                    for (int i = 0; i < numberRows; i++)
                    {
                        for (int j = 0; j < numberColumns; j++)
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
        /// Redefining the GetHashCode method that calculates the hash code of the current object
        /// </summary>
        /// <returns>Hash code of the current object</returns>

        public override int GetHashCode()
        {
            return numberRows * numberColumns / 2;
        }
    }
}
