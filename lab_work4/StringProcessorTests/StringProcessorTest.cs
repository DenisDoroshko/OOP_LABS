using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringProcessing;

namespace StringProcessorTests
{
    [TestClass]
    public class StringProcessorTest
    {
        [TestMethod]
        public void CountWord_InputedOnlyOneSpace()
        {
            //Arange
            string initialString = " ";
            string searchedWord = "hello";
            int expected = 0;
            //Act
            int result = StringProcessor.CountWord(initialString, searchedWord);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CountWord_InputedTwoSearchingWord()
        {
            //Arange
            string initialString = "World hello,hello everyone,hello friend!";
            string searchedWord = "hello";
            int expected = 3;
            //Act
            int result = StringProcessor.CountWord(initialString, searchedWord);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CountWord_SearchedWordWithMistake()
        {
            //Arange
            string initialString = "helllo everyone!";
            string searchedWord = "hello";
            int expected = 0;
            //Act
            int result = StringProcessor.CountWord(initialString, searchedWord);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CountWord_SearchedWordsWithDifferentCase()
        {
            //Arange
            string initialString = "Hello,hello everyone!Hello world and hello friend.";
            string searchedWord = "hello";
            int expected = 4;
            //Act
            int result = StringProcessor.CountWord(initialString, searchedWord);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CountWord_SearchedWordsAreMerged()
        {
            //Arange
            string initialString = "Hellohello everyone!";
            string searchedWord = "hello";
            int expected = 0;
            //Act
            int result = StringProcessor.CountWord(initialString, searchedWord);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CountWord_NothingInputed()
        {
            //Arange
            string initialString = "";
            string searchedWord = "hello";
            int expected = 0;
            //Act
            int result = StringProcessor.CountWord(initialString, searchedWord);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CountWord_ManySearchedWords()
        {
            //Arange
            string initialString = "Привет привет привет привет привет привет привет привет привет!Привет привет привет привет привет!";
            string searchedWord = "привет";
            int expected = 14;
            //Act
            int result = StringProcessor.CountWord(initialString, searchedWord);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ExtractRussian_TwoRussianSentences()
        {
            //Arange
            string initialText = "Привет мир!How are you?У меня все хорошо.";
            int expected = 2;
            //Act
            StringBuilder[] russianSentenses = StringProcessor.ExtractRussian(initialText);
            //Assert
            Assert.AreEqual(expected, russianSentenses.Length);
        }
        [TestMethod]
        public void ExtractRussian_TextWithoutRussianLanguage()
        {
            //Arange
            string initialText = "Hello world!How are you?This text haven't russian sentenses.";
            int expected = 0;
            //Act
            StringBuilder[] russianSentenses = StringProcessor.ExtractRussian(initialText);
            //Assert
            Assert.AreEqual(expected, russianSentenses.Length);
        }

        [TestMethod]
        public void ExtractRussian_OnlyRussianSentences()
        {
            //Arange
            string initialText = "Привет мир!Как дела?У меня все хорошо.";
            int expected = 3;
            //Act
            StringBuilder[] russianSentenses = StringProcessor.ExtractRussian(initialText);
            //Assert
            Assert.AreEqual(expected, russianSentenses.Length);
        }
        [TestMethod]
        public void ExtractRussian_InputedTextWhithoutWords()
        {
            //Arange
            string initialText = ".";
            int expected = 0;
            //Act
            StringBuilder[] russianSentenses = StringProcessor.ExtractRussian(initialText);
            //Assert
            Assert.AreEqual(expected, russianSentenses.Length);
        }
        [TestMethod]
        public void ExtractRussian_NothingInputed()
        {
            //Arange
            string initialText = "";
            int expected = 0;
            //Act
            StringBuilder[] russianSentenses = StringProcessor.ExtractRussian(initialText);
            //Assert
            Assert.AreEqual(expected, russianSentenses.Length);
        }
        [TestMethod]
        public void ExtractRussian_FiveRussianSentences()
        {
            //Arange
            string initialText = "Привет!Как дела?Что делаешь?У меня все хорошо!Пока?";
            int expected = 5;
            //Act
            StringBuilder[] russianSentenses = StringProcessor.ExtractRussian(initialText);
            //Assert
            Assert.AreEqual(expected, russianSentenses.Length);
        }
        [TestMethod]
        public void ExtractRussian_RussianSentesesWithEnglishWords()
        {
            //Arange
            string initialText = "Привет мир-world!Как дела?Что делаешь?";
            int expected = 3;
            //Act
            StringBuilder[] russianSentenses = StringProcessor.ExtractRussian(initialText);
            //Assert
            Assert.AreEqual(expected, russianSentenses.Length);
        }
        [TestMethod]
        public void ExtractRussian_InputedNumberInsteadOfSentences()
        {
            //Arange
            string initialText = "123! 0101010?9?";
            int expected = 0;
            //Act
            StringBuilder[] russianSentenses = StringProcessor.ExtractRussian(initialText);
            //Assert
            Assert.AreEqual(expected, russianSentenses.Length);
        }


    }
}
