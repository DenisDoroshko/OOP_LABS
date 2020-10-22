using System;
using System.Text;
using System.Text.RegularExpressions;

namespace StringProcessing
{
    /// <summary>
    /// A class that provides methods for working with string 
    /// </summary>

    public static class StringProcessor
    {

        /// <summary>
        /// Countes how many times a given word appears in a string
        /// </summary>
        /// <param name="givenString">Given string</param>
        /// <param name="givenWord">Given word</param>
        /// <returns>How many times a word has been encountered</returns>
        
        public static int CountWord(string givenString,string givenWord)
        {
            string onlyWords = Regex.Replace(givenString, "[^a-zA-Zа-яА-Я]", " ");
            string[] words = onlyWords.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;
            foreach (string word in words)
            {
                int compareResult = string.Compare(word.ToLower(), givenWord.ToLower());
                if (compareResult == 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        /// <summary>
        /// Forms an array of sentences in Russian
        /// </summary>
        /// <param name="givenString">Given text</param>
        /// <returns>An array of sentences in Russian</returns>
        
        public static StringBuilder[] ExtractRussian(string givenText)
        {
            string[] sentences =givenText.Split(new char[] { '.','!','?'}, StringSplitOptions.RemoveEmptyEntries);
            string symbols = Regex.Replace(givenText, "[^!.?]", "");
            StringBuilder[] resultString;
            if (symbols.Length == sentences.Length)
            {
                for (int i = 0; i < sentences.Length && symbols.Length != 0; i++)
                {
                    sentences[i] += symbols[i];
                }
                int numberOfRussianSentence = 0;
                foreach (string sentence in sentences)
                {
                    if (Regex.IsMatch(sentence, "[а-яА-Я]"))
                    {
                        numberOfRussianSentence++;
                    }
                }
                resultString = new StringBuilder[numberOfRussianSentence];
                numberOfRussianSentence = 0;
                foreach (string sentence in sentences)
                {
                    if (Regex.IsMatch(sentence, "[а-яА-Я]"))
                    {
                        resultString[numberOfRussianSentence] = new StringBuilder(sentence);
                        numberOfRussianSentence++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Sentence is not completed");
                resultString = new StringBuilder[1];
            }
            
            return resultString;
        }

        public static string ParseSymbols(string givenText)
        {
            string onlySymbols = Regex.Replace(givenText, "[a-zA-Zа-яА-Я0-9]", "");
            return onlySymbols;
        }
    }
}
