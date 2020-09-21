using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VectorLibary;

namespace VectorTests
{
    [TestClass]
    public class VectorTests
    {
        [TestMethod]
        public void MiltiplyVectorsAllNegative()
        {
            int expected = 1425;
            Vector firstTestVector = new Vector(-10, -21, -34);
            Vector secondTestVector = new Vector(-20, -13, -28);
            int result = firstTestVector * secondTestVector;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MiltiplyVectorsAllNull()
        {
            int expected = 0;
            Vector firstTestVector = new Vector(0, 0, 0);
            Vector secondTestVector = new Vector(0, 0, 0);
            int result = firstTestVector * secondTestVector;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MiltiplyVectorsDifferentCoordinates()
        {
            int expected = 52;
            Vector firstTestVector = new Vector(11, 3, 0);
            Vector secondTestVector = new Vector(-1, 21, 5);
            int result = firstTestVector * secondTestVector;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MiltiplyVectorByNegativeNumber()
        {
            Vector expected = new Vector(143,0,-325);
            Vector testVector = new Vector(-11, 0, 25);
            int number = -13;
            testVector= testVector * number;
            Assert.AreEqual(expected, testVector);
        }

        [TestMethod]
        public void MiltiplyVectorByPositiveNumber()
        {
            Vector expected = new Vector(126, 18, 96);
            Vector testVector = new Vector(21, 3, 16);
            int number = 6;
            testVector = testVector * number;
            Assert.AreEqual(expected, testVector);
        }

        [TestMethod]
        public void MiltiplyVectorByNull()
        {
            Vector expected = new Vector(0, 0, 0);
            Vector testVector = new Vector(-23, 12, 126);
            int number = 0;
            testVector = testVector * number;
            Assert.AreEqual(expected, testVector);
        }

    }
}
