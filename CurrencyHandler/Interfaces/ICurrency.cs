using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurrencyHandler.Interfaces {
    public interface ICurrency {
        bool Negativity { get; set; }
        string Currency { get; set; }
        string WholeValue { get; set; }
        string DecimalValue { get; set; }
    }
}
