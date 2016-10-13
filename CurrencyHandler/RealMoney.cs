using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CurrencyHandler.Interfaces;

namespace CurrencyHandler {
    public class RealMoney : ICurrency {
        #region fields
        private bool negativity;
        private string currency;
        private string wholeValue;
        private string decimalValue;
        private Dictionary<string, string> curr = new Dictionary<string, string> { { "R", "rand" } };
        private Dictionary<int, string> specialNames = new Dictionary<int, string> { { 3, "hundred" }, { 5, "thousand" } };
        private Dictionary<int, string> tenNames = new Dictionary<int, string> { { 1, "ten" }, { 2, "twenty" }, { 3, "thirty"}, { 4, "fourty"}, { 5, "fifty"}, { 6, "sixty"}, { 7, "seventy"}, { 8, "eighty"}, { 9, "ninety"} };
        private Dictionary<int, string> numNames = new Dictionary<int, string> { { 1, "zero" }, { 2, "two" }, { 3, "three" }, { 4, "four" }, { 5, "five" }, { 6, "six" }, { 7, "seven" }, { 8, "eight" }, { 9, "nine" } };
        #endregion fields

        #region properties
        public bool Negativity {
            get { return negativity; }
            set { negativity = value; }
        }
        
        public string Currency {
            get { return currency; }
            set { currency = value; }
        }

        public string WholeValue {
            get { return wholeValue; }
            set { wholeValue = value; }
        }

        public string DecimalValue {
            get { return decimalValue; }
            set { decimalValue = value; }
        }
        #endregion

        #region constructors
        public RealMoney() { }

        public RealMoney(bool negativity, string currency, string wholeValue, string decimalValue) {
            this.Negativity = negativity;
            this.Currency = currency;
            this.WholeValue = wholeValue;
            this.DecimalValue = decimalValue;
        }
        #endregion constructorsconstructors

        #region public methods
        /// <summary>
        /// Converts this instance of a RealMoney object to a word value
        /// </summary>
        /// <returns>Returns the word value of the money</returns>
        public string ToWordValue() {
            var res = "";

            if (this.negativity)
                res += "minus";

            res += this.wholeValue != null ? numericToWord(this.wholeValue, false) : "";
            res += this.currency != "" ? curr[(this.currency.ToLower()).ToString()] : ""; // adds converted currency from pre-defined source
            res += this.decimalValue != null ? numericToWord(this.decimalValue, true) + " cents " : "";

            return res;
        }

        public override string ToString() {
            return string.Format("Value: {0}", ToWordValue()); 
        }
        #endregion public methods

        private string numericToWord(string numericalValue, bool isCent) {
            var res = "";
            var charr = numericalValue.ToCharArray().ToList();

            if(isCent == false)  //whole number
                res = wholeConversion(charr);
            else //cent
                res = centConversion(charr);

            return res;
        }

        private string wholeConversion(List<char> charr) {
            var res = "";
            for (int i = charr.Count; i != 0; i--) {
                if(i == 5)
                    res += tenNames[i] + numNames[charr[i]] + specialNames[i];
                else if(i == 4 && charr.Count == 4)
                    res += numNames[charr[i]] + specialNames[i];
                else if (i == 3)
                    res += numNames[charr[i]] + specialNames[i];
                else if (i == 2)
                    res += charr[i] == '0' ? "zero" : numNames[charr[i]] + tenNames[i];
                else if (i == 1)
                    res += numNames[charr[i]];
            }
            return res;
        }

        private string centConversion(List<char> charr) {
            var res = "";
            for (int i = charr.Count; i != 0; i--) {
                if (i == 2)
                    res += charr[i] == '0' ? "zero" : numNames[charr[i]] + tenNames[i];
                else if (i == 1)
                    res += numNames[charr[i]];
            }
            return res;
        }
    }
}
