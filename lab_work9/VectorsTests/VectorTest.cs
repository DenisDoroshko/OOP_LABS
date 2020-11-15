using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vectors;

namespace VectorsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ScalarMiltiplyVectorsAllNegative()
        {
            //Arange
            int expected = 1425;
            Vector firstTestVector = new Vector(-10, -21, -34);
            Vector secondTestVector = new Vector(-20, -13, -28);
            //Act
            int result = firstTestVector * secondTestVector;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ScalarMiltiplyVectorsAllNull()
        {
            //Arange
            int expected = 0;
            Vector firstTestVector = new Vector(0, 0, 0);
            Vector secondTestVector = new Vector(0, 0, 0);
            //Act
            int result = firstTestVector * secondTestVector;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ScalarMiltiplyVectorsDifferentCoordinates()
        {
            //Arange
            int expected = 52;
            Vector firstTestVector = new Vector(11, 3, 0);
            Vector secondTestVector = new Vector(-1, 21, 5);
            //Act
            int result = firstTestVector * secondTestVector;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ScalarMiltiplyVectorsBigCoordinates()
        {
            //Arange
            int expected = -20523975;
            Vector firstTestVector = new Vector(1112, -2313, 1323);
            Vector secondTestVector = new Vector(5262, 6472, -8621);
            //Act
            int result = firstTestVector * secondTestVector;
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void VectorMiltiplyVectorsAllNegative()
        {
            //Arange
            Vector expected = new Vector(0, -39, 18);
            Vector firstTestVector = new Vector(-5, -6, -13);
            Vector secondTestVector = new Vector(-2, -6, -13);
            //Act
            Vector result = Vector.VectorMultiple(firstTestVector, secondTestVector);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void VectorMiltiplyVectorsAllNull()
        {
            //Arange
            Vector expected = new Vector(0, 0, 0);
            Vector firstTestVector = new Vector(0, 0, 0);
            Vector secondTestVector = new Vector(0, 0, 0);
            //Act
            Vector result = Vector.VectorMultiple(firstTestVector, secondTestVector);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void VectorMiltiplyVectorsDifferentCoordinates()
        {
            //Arange
            Vector expected = new Vector(62, 8, 1412);
            Vector firstTestVector = new Vector(4, -31, 0);
            Vector secondTestVector = new Vector(44, 12, -2);
            //Act
            Vector result = Vector.VectorMultiple(firstTestVector, secondTestVector);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void VectorMiltiplyVectorsBigCoordinates()
        {
            //Arange
            Vector expected = new Vector(-1531329346, -496032504, -1194897724);
            Vector firstTestVector = new Vector(20152, 13042, -31240);
            Vector secondTestVector = new Vector(23150, -44312, -11273);
            //Act
            Vector result = Vector.VectorMultiple(firstTestVector, secondTestVector);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MixedMiltiplyVectorsAllNegative()
        {
            //Arange
            int expected = -327;
            Vector firstTestVector = new Vector(-11, -28, -1);
            Vector secondTestVector = new Vector(-3, -6, -2);
            Vector thirdTestVector = new Vector(-11, -7, -5);
            //Act
            int result = Vector.MixedMultiply(firstTestVector, secondTestVector, thirdTestVector);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MixeвMiltiplyVectorsAllNull()
        {
            //Arange
            int expected = 0;
            Vector firstTestVector = new Vector(0, 0, 0);
            Vector secondTestVector = new Vector(0, 0, 0);
            Vector thirdTestVector = new Vector(0, 0, 0);
            //Act
            int result = Vector.MixedMultiply(firstTestVector, secondTestVector, thirdTestVector);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MixedMiltiplyVectorsDifferentCoordinates()
        {
            //Arange
            int expected = 3744;
            Vector firstTestVector = new Vector(12, 0, -10);
            Vector secondTestVector = new Vector(2, 16, -5);
            Vector thirdTestVector = new Vector(25, 8, -3);
            //Act
            int result = Vector.MixedMultiply(firstTestVector, secondTestVector, thirdTestVector);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MixedMiltiplyVectorsBigCoordinates()
        {
            //Arange
            int expected = -262270125;
            Vector firstTestVector = new Vector(852, 355, -501);
            Vector secondTestVector = new Vector(921, 141, -522);
            Vector thirdTestVector = new Vector(512, 412, 951);
            //Act
            int result = Vector.MixedMultiply(firstTestVector, secondTestVector, thirdTestVector);
            //Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void MiltiplyVectorByNegativeNumber()
        {
            //Arange
            Vector expected = new Vector(143, 0, -325);
            Vector testVector = new Vector(-11, 0, 25);
            int number = -13;
            //Act
            testVector = testVector * number;
            //Assert
            Assert.AreEqual(expected, testVector);
        }

        [TestMethod]
        public void MiltiplyVectorByPositiveNumber()
        {
            //Arange
            Vector expected = new Vector(126, 18, 96);
            Vector testVector = new Vector(21, 3, 16);
            int number = 6;
            //Act
            testVector = testVector * number;
            //Assert
            Assert.AreEqual(expected, testVector);
        }

        [TestMethod]
        public void MiltiplyVectorByNull()
        {
            //Arange
            Vector expected = new Vector(0, 0, 0);
            Vector testVector = new Vector(-23, 12, 126);
            int number = 0;
            //Act
            testVector = testVector * number;
            //Assert
            Assert.AreEqual(expected, testVector);
        }
    }
}
