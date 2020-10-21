using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parsing;
using System.Collections.Generic;

namespace ParsingTests
{
    [TestClass]
    public class PhoneParsingTest
    {
        [TestMethod]
        public void ParsePhoneNumbers_TwoMobileNumbers()
        {
            //Arange
            List<string> numbers = new List<string>() {"+375292303432","+7 911 234-12-12","11212121212"};
            int expected = 2;
            List<string> mobileNumbers = new List<string>();
            List<string> homeNumbers = new List<string>();
            List<string> incorrectNumbers = new List<string>();
            //Act
            PhoneParsing.ParsePhoneNumbers(numbers, mobileNumbers, homeNumbers, incorrectNumbers);
            //Assert
            Assert.AreEqual(expected, mobileNumbers.Count);
        }

        [TestMethod]
        public void ParsePhoneNumbers_ThreeHomeNumbers()
        {
            //Arange
            List<string> numbers = new List<string>() { "+375292303432", "23 5 31-34-12", "12 2 3 31-5-56","25 3 45-61-34" };
            int expected = 3;
            List<string> mobileNumbers = new List<string>();
            List<string> homeNumbers = new List<string>();
            List<string> incorrectNumbers = new List<string>();
            //Act
            PhoneParsing.ParsePhoneNumbers(numbers, mobileNumbers, homeNumbers, incorrectNumbers);
            //Assert
            Assert.AreEqual(expected, homeNumbers.Count);
        }

        [TestMethod]
        public void ParsePhoneNumbers_ThreeIncorrectNumbers()
        {
            //Arange
            List<string> numbers = new List<string>() { "+375292303432", "253 5 34-1h2", "12 2 3 31-5-56", "225 3 45-61-34","79112305489" };
            int expected = 3;
            List<string> mobileNumbers = new List<string>();
            List<string> homeNumbers = new List<string>();
            List<string> incorrectNumbers = new List<string>();
            //Act
            PhoneParsing.ParsePhoneNumbers(numbers, mobileNumbers, homeNumbers, incorrectNumbers);
            //Assert
            Assert.AreEqual(expected, incorrectNumbers.Count);
        }
        [TestMethod]
        public void ParsePhoneNumbers_AllIncorrectNumbers()
        {
            //Arange
            List<string> numbers = new List<string>() { "75292303432", "253 5 34-1h2", "12 2 3 31-5-56", "225 3 45-61-34", "1-1-1-1-1-1-1" };
            int expected = 4;
            List<string> mobileNumbers = new List<string>();
            List<string> homeNumbers = new List<string>();
            List<string> incorrectNumbers = new List<string>();
            //Act
            PhoneParsing.ParsePhoneNumbers(numbers, mobileNumbers, homeNumbers, incorrectNumbers);
            //Assert
            Assert.AreEqual(expected, incorrectNumbers.Count);
        }
    }
}
