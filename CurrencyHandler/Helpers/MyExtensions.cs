using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurrencyHandler.Helpers {
    public static class MyExtensions {
        #region fields
        // These values are hard coded for now - but essentially a database can be written to keep different language formats.
        // These values are also static so they are not instantiated for every use.
        static string[] singleDigits = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        static string[] doubleDigit = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        static string[] tens = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        static string[] specialName = { "", " Thousand", " Million", " Billion" };
        static Dictionary<string, string> currency = new Dictionary<string, string> { { "R", "Rand" }, { "$", "Dollar" } };
        #endregion fields

        #region public methods
        /// <summary>
        /// This method is used to convert string values into real money objects
        /// </summary>
        /// <param name="value">String item to be converted</param>
        /// <returns>RealMoney object</returns>
        public static RealMoney StringToRealMoney(this string value) {
            var res = new RealMoney();

            return res;
        }

        public static string getCurrency(this string s) {
            var curr = "";
            currency.TryGetValue(s.ToUpper(), out curr);
            return curr;
        }

        /// <summary>
        /// Returns the english word value for a numerical value.
        /// </summary>
        /// <param name="number">Integer value to convert</param>
        /// <returns>Converted integer value into words.</returns>
        public static string NumbersToWords(this int number) {
            var result = "";
            result = number == 0 || number == 00 ? "Zero " : //returns zero if both values are empty
                number.numbersToWords(""); //otherwise get the words
            return result.Trim(' ');
        }
        #endregion public methods

        #region private methods
        /// <summary>
        /// This is use to convert number to words up to 999.
        /// </summary>
        /// <param name="number">Integer value to be converted</param>
        /// <param name="friendlyName">Name built up recursively</param>
        /// <returns>Converted integer value into words.</returns>
        private static string numbersToWords(this int number, string friendlyName) {
            friendlyName += number < 10 ? " " + singleDigits[number] : // If less than 10, only perform 1 iteration and get the single digit value.
                number < 20 ? " " + doubleDigit[number - 10] : // Return the double digit value if under 20.
                number < 100 ? " " + (number % 10).numbersToWords(tens[number/ 10 - 2]): // If under 100, get tens value and iterate again.
                number < 1000 ? " " + (number % 100).numbersToWords(singleDigits[number / 100] + " Hundred" + ((number - 100) > 0 ? " and" : "")) : //generates the hundred value range
                "Error (number value out of range)"; // error message when it is out of range
            return friendlyName.Trim(' ');
        }
        #endregion private methods
    }
}
