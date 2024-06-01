using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1task.lab1classes
{
    public class Money
    {
        public string Currency { get; set; }
        public int Dollars { get; set; }
        public int Cents { get; set; }

        public Money(int dollars = 0, int cents = 0, string currency = "")
        {
            Dollars = dollars;
            Cents = cents;
            Currency = currency;
        }

        public void SetValue(int dollars, int cents, string currency)
        {
            Dollars = dollars;
            Cents = cents;
            Currency = currency;
        }

        public string GetValue()
        {
            return $"{Dollars}.{Cents:D2} {Currency}";
        }

        public override string ToString()
        {
            return $"{Dollars}.{Cents:D2} {Currency}";
        }
    }
}
