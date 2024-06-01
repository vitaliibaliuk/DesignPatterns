using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1task.lab1classes
{
    public class Product
    {
        public string Name { get; set; }
        public Money Price { get; set; }
        public int Categori { get; set; }
        public string Category { get; }

        public Product(string name, Money price, int categori)
        {
            Name = name;
            Price = price;
            Categori = categori;
            switch (Categori)
            {
                case 1: { Category = "Electronics"; break; }
                case 2: { Category = "Home Appliances"; break; }
                case 3: { Category = "Furniture"; break; }
                case 4: { Category = "Clothing"; break; }
                case 5: { Category = "Footwear"; break; }
                case 6: { Category = "Books"; break; }
                case 7: { Category = "Toys"; break; }
            };
        }

        public void ReducePrice(Money reduction)
        {
            int totalPriceCents = Price.Dollars * 100 + Price.Cents;
            int reductionCents = reduction.Dollars * 100 + reduction.Cents;
            int newTotalCents = totalPriceCents - reductionCents;

            if (newTotalCents < 0)
            {
                newTotalCents = 0;
            }

            Price.Dollars = newTotalCents / 100;
            Price.Cents = newTotalCents % 100;
        }

        public override string ToString()
        {
            return $"Category: {Category}, Product: {Name}, Price: {Price}";
        }
    }
}
