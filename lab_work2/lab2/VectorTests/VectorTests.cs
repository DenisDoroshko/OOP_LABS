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
        public void ScalarMiltiplyVectorsAllNegative()
        {
            int expected = 1425;
            Vector firstTestVector = new Vector(-10, -21, -34);
            Vector secondTestVector = new Vector(-20, -13, -28);
            int result = firstTestVector * secondTestVector;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ScalarMiltiplyVectorsAllNull()
        {
            int expected = 0;
            Vector firstTestVector = new Vector(0, 0, 0);
            Vector secondTestVector = new Vector(0, 0, 0);
            int result = firstTestVector * secondTestVector;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ScalarMiltiplyVectorsDifferentCoordinates()
        {
            int expected = 52;
            Vector firstTestVector = new Vector(11, 3, 0);
            Vector secondTestVector = new Vector(-1, 21, 5);
            int result = firstTestVector * secondTestVector;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ScalarMiltiplyVectorsBigCoordinates()
        {
            int expected = -20523975;
            Vector firstTestVector = new Vector(1112, -2313, 1323);
            Vector secondTestVector = new Vector(5262, 6472, -8621);
            int result = firstTestVector * secondTestVector;
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void VectorMiltiplyVectorsAllNegative()
        {
            Vector expected = new Vector(0, -39, 18);
            Vector firstTestVector = new Vector(-5, -6, -13);
            Vector secondTestVector = new Vector(-2, -6, -13);
            Vector result = Vector.VectorMultiple(firstTestVector, secondTestVector);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void VectorMiltiplyVectorsAllNull()
        {
            Vector expected = new Vector(0, 0, 0);
            Vector firstTestVector = new Vector(0, 0, 0);
            Vector secondTestVector = new Vector(0, 0, 0);
            Vector result = Vector.VectorMultiple(firstTestVector, secondTestVector);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void VectorMiltiplyVectorsDifferentCoordinates()
        {
            Vector expected = new Vector(62, 8, 1412);
            Vector firstTestVector = new Vector(4, -31, 0);
            Vector secondTestVector = new Vector(44, 12, -2);
            Vector result = Vector.VectorMultiple(firstTestVector, secondTestVector);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void VectorMiltiplyVectorsBigCoordinates()
        {
            Vector expected = new Vector(-1531329346, -496032504, -1194897724);
            Vector firstTestVector = new Vector(20152, 13042, -31240);
            Vector secondTestVector = new Vector(23150, -44312, -11273);
            Vector result = Vector.VectorMultiple(firstTestVector, secondTestVector);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MixedMiltiplyVectorsAllNegative()
        {
            int expected = -327;
            Vector firstTestVector = new Vector(-11, -28, -1);
            Vector secondTestVector = new Vector(-3, -6, -2);
            Vector thirdTestVector = new Vector(-11, -7, -5);
            int result = Vector.MixedMultiply(firstTestVector, secondTestVector, thirdTestVector);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MixeвMiltiplyVectorsAllNull()
        {
            int expected = 0;
            Vector firstTestVector = new Vector(0, 0, 0);
            Vector secondTestVector = new Vector(0, 0, 0);
            Vector thirdTestVector = new Vector(0, 0, 0);
            int result = Vector.MixedMultiply(firstTestVector, secondTestVector, thirdTestVector);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MixedMiltiplyVectorsDifferentCoordinates()
        {
            int expected = 3744;
            Vector firstTestVector = new Vector(12, 0, -10);
            Vector secondTestVector = new Vector(2, 16, -5);
            Vector thirdTestVector = new Vector(25, 8, -3);
            int result = Vector.MixedMultiply(firstTestVector, secondTestVector, thirdTestVector);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MixedMiltiplyVectorsBigCoordinates()
        {
            int expected = -262270125;
            Vector firstTestVector = new Vector(852, 355, -501);
            Vector secondTestVector = new Vector(921,141, -522);
            Vector thirdTestVector = new Vector(512, 412, 951);
            int result = Vector.MixedMultiply(firstTestVector, secondTestVector, thirdTestVector);
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
