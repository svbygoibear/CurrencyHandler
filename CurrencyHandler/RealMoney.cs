using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CurrencyHandler.Interfaces;
using CurrencyHandler.Helpers;

namespace CurrencyHandler {
    public class RealMoney : ICurrency {
        #region fields
        private bool negativity;
        private string currency;
        private int? wholeValue;
        private int? decimalValue;
        private string wordValue;
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

        public int? WholeValue {
            get { return wholeValue; }
            set { wholeValue = value; }
        }

        public int? DecimalValue {
            get { return decimalValue; }
            set { decimalValue = value; }
        }

        public string WordValue {
            get { return wordValue; }
            //set { wordValue = value; }
        }
        #endregion

        #region constructors
        public RealMoney() { }

        public RealMoney(bool negativity, string currency, int? wholeValue, int? decimalValue) {
            this.Negativity = negativity;
            this.Currency = currency;
            this.WholeValue = wholeValue;
            this.DecimalValue = decimalValue;
            this.wordValue = toWord(); // generates the to word value
        }
        #endregion constructorsconstructors

        #region public methods
        public override string ToString() {
            return string.Format("Value: {0}", this.wholeValue); 
        }
        #endregion public methods

        #region private methods
        /// <summary>
        /// Generates a to word value for the current real money object
        /// </summary>
        /// <returns>To Word value in string</returns>
        private string toWord() {
            var result = "";
            if (!this.wholeValue.HasValue && !this.decimalValue.HasValue)
                result += "Error (empty string)";
            else if (!this.wholeValue.HasValue)
                result += "Error (invalid rand value)";
            else if (!this.decimalValue.HasValue)
                result += "Error (invalid cents values)";
            else {
                var randValue = this.wholeValue.Value.NumbersToWords();
                var centValue = this.decimalValue.Value.NumbersToWords();

                result += (this.negativity ? "Minus " : "") // Negativity indictor
                    + (randValue) // Rand value
                    + (this.currency.getCurrency() == "" ? "R" : $" {this.currency.getCurrency()} ") // Currency
                    + ("and " + centValue + (this.decimalValue == 1 ? " Cent" : " Cents")); // Cent value
            }

            return result;
        }
        #endregion private methods
    }
}
