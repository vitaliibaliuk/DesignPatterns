using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.task2.Interfaces;

namespace lab2.task2.Classes
{
    public class KiaomiLaptop : ILaptop
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public KiaomiLaptop(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"KiaomiLaptop\nName: {Name}, Description: {Description}");
        }
    }
}
