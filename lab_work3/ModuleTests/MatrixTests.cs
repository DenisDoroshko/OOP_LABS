using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrixes;
using UserInterface;
using System.Net;

namespace ModuleTests
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void CalculateSumSquaresRegularNumber()
        {
            double expected = 329;
            double[,] numbers = { { -13, 4, 12 },{ 12, 3, 0 },{ -26, 4, -51 } };
            Matrix firstMatrix = new Matrix(3,3,numbers);
            double result = firstMatrix.CalculateSumSquares(-12);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateSumSquaresBigNumber()
        {
            double expected = 0;
            double[,] numbers = { { -73, 21, 0 }, { 6, 3, 35 }, { -16, -4, 11 } };
            Matrix firstMatrix = new Matrix(3, 3, numbers);
            double result = firstMatrix.CalculateSumSquares(142);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateSumSquaresRegularElement()
        {
            double expected = 209;
            double[,] numbers = { { 4, -5, 0 }, { 11, -6, 15 }, { 7, -4, 12 } };
            Matrix firstMatrix = new Matrix(3, 3, numbers);
            double result = firstMatrix.CalculateSumSquares(2,3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateSumSquaresLastElement()
        {
            double expected = 0;
            double[,] numbers = { { 14, 8, 7 }, { 16, -16, 0 }, { 17, -4, 6 } };
            Matrix firstMatrix = new Matrix(3, 3, numbers);
            double result = firstMatrix.CalculateSumSquares(3, 3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ScalarMultipleIncorrectRowsColumns()
        {
            bool expected = false;
            double[,] firstNumbers = { { -12, 11, 7 }, { 16, -16, 0 }};
            Matrix firstMatrix = new Matrix(2, 3, firstNumbers);
            double[,] secondNumbers = { { 15, 4, 2 }, { 14, 16, 18 } };
            Matrix secondMatrix = new Matrix(2, 3, secondNumbers);
            Matrix thirdMatrix = new Matrix();
            bool result = Matrix.ScalarMultiple(firstMatrix, secondMatrix, ref thirdMatrix);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ScalarMultipleCorrectRowsColumns()
        {
            bool expected = true;
            double[,] firstNumbers = { { -11, 5, 5 }, { 16, -6, 4 } };
            Matrix firstMatrix = new Matrix(2, 3, firstNumbers);
            double[,] secondNumbers = { { 15, 2, 65 }, { 5, 6, 22 },{ 0, 4, 2 } };
            Matrix secondMatrix = new Matrix(3, 3, secondNumbers);
            Matrix thirdMatrix = new Matrix();
            bool result = Matrix.ScalarMultiple(firstMatrix, secondMatrix, ref thirdMatrix);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ScalarMultipleResultOfProduction()
        {
            double[,] expectedNumbers = { { 94,168,116},{ -144,-80,-152},{ -339,-232,-418} };
            Matrix expected = new Matrix(3,3,expectedNumbers);
            double[,] firstNumbers = { { -12, 11, 7 }, { 16, -16, 4}, { 5, -26, 5 } };
            Matrix firstMatrix = new Matrix(3, 3, firstNumbers);
            double[,] secondNumbers = { { 5, 4, 8 }, { 14, 12, 18 }, { 0, 12, 2 } };
            Matrix secondMatrix = new Matrix(3, 3, secondNumbers);
            Matrix resultMatrix = new Matrix();
            Matrix.ScalarMultiple(firstMatrix, secondMatrix, ref resultMatrix);
            Assert.AreEqual(expected, resultMatrix);
        }

        [TestMethod]
        public void InteractionCalculateSumSquaresNumber()
        {
            double expected = 17225;
            double[,] numbers = { { 4, -5, 11 }, { 14, -6, 20 }};
            Matrix firstMatrix = new Matrix(2, 3, numbers);
            double[,] secondNumbers = { { 83, 4, 0 }, { -5, 100, 6 }, { 0, 85, 2 } };
            Matrix secondMatrix = new Matrix(3, 3, secondNumbers);
            double result = InteractionMethods.CalculateNumberSumSquares(firstMatrix,secondMatrix);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReplaceNegativeNumbersEqualMatrixes()
        {
            double[,] expectedNumbers = { { 4, -5, 11 }, { 14, -6, 0 }, { 2, -12, 0 } };
            Matrix expected = new Matrix(3, 3, expectedNumbers);
            double[,] numbers = { { 4, -5, 11 }, { 14, -6, -4 }, { 2,-12,-5} };
            Matrix firstMatrix = new Matrix(3, 3, numbers);
            double[,] secondNumbers = { { 4, -5, 11 }, { 14, -6, -4 }, { 2, -12, -5 } };
            Matrix secondMatrix = new Matrix(3, 3, secondNumbers);
            double[,] thirdNumbers = { { 4, -5, 11 }, { 14, -6, -4 }, { 2, -12, -5 } };
            Matrix thirdMatrix = new Matrix(3, 3, thirdNumbers);
            InteractionMethods.ReplaceNegativeNumbers(ref firstMatrix,ref secondMatrix,ref thirdMatrix);
            Assert.AreEqual(expected, firstMatrix);
        }

        [TestMethod]
        public void ReplaceNegativeNumbersUnequalMatrixes()
        {
            bool expected = false;
            double[,] numbers = { { 4, -5, 11 }, { 14, -6, -4 }};
            Matrix firstMatrix = new Matrix(2, 3, numbers);
            double[,] secondNumbers = { { 4, -5, 6 }, { 6, -6, -4 }, { 2, -12, -7 } };
            Matrix secondMatrix = new Matrix(3, 3, secondNumbers);
            double[,] thirdNumbers = { { 4, -5, 6 }, { 6, -6, -4 }, { 2, -12, -7 } };
            Matrix thirdMatrix = new Matrix(3, 3, thirdNumbers);
            bool result = InteractionMethods.ReplaceNegativeNumbers(ref firstMatrix, ref secondMatrix, ref thirdMatrix);
            Assert.AreEqual(expected,result);
        }
    }
}
