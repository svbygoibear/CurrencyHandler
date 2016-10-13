using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurrencyHandler.Helpers {
    public static class MyExtensions {
        /// <summary>
        /// This method is used to convert string values into real money objects
        /// </summary>
        /// <param name="value">String item to be converted</param>
        /// <returns>RealMoney object</returns>
        public static RealMoney stringToRealMoney(this string value) {
            var res = new RealMoney();

            return res;
        }
    }
}
