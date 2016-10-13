using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurrencyHandler.Interfaces {
    public interface ICurrency {
        bool? Negativity { get; set; }
        string Currency { get; set; }
        int? WholeValue { get; set; }
        int? DecimalValue { get; set; }
    }
}
