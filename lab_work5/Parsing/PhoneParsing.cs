using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Parsing
{
    /// <summary>
    /// A class that provides methods for processing phone numbers
    /// </summary>
    
    public class PhoneParsing
    {
        /// <summary>
        /// Parses phone numbers
        /// </summary>
        /// <param name="phoneNumbers">Intial phone numbers</param>
        /// <param name="mobileNumbers">Mobile numbers</param>
        /// <param name="homeNumbers">Home numbers</param>
        /// <param name="incorrectNumbers">Incorrect numbers</param>
        
        public static void ParsePhoneNumbers(List<string> phoneNumbers, List<string> mobileNumbers, List<string> homeNumbers, List<string> incorrectNumbers)
        {
            string mobileFormat = @"^((8|\+375|\+7|\+380)[\- ]?)\(?\d{2,3}\)?[\- ]?\d{1}[\- ]?\d{1}[\- ]?\d{1}[\- ]?\d{1}[\- ]?\d{1}[\- ]?\d{1}[\- ]?\d{1}$";
            string homeFormat = @"^\d{1}[\- ]?\d{1}[\- ]?\d{1}[\- ]?\d{1}[\- ]?\d{1}[\- ]?\d{1}[\- ]?\d{1}[\- ]?\d{1}[\- ]?\d{1}[\- ]?$";
            bool isCorrect;
            foreach (var number in phoneNumbers)
            {
                isCorrect = false;
                var trimmedNumber = number.Trim();
                if (Regex.IsMatch(trimmedNumber, mobileFormat))
                {
                    mobileNumbers.Add(trimmedNumber);
                    isCorrect = true;
                }

                if (Regex.IsMatch(trimmedNumber, homeFormat))
                {
                    homeNumbers.Add(trimmedNumber);
                    isCorrect = true;
                }

                if (!isCorrect)
                {
                    incorrectNumbers.Add(trimmedNumber);
                }
            }
        }

    }
}
