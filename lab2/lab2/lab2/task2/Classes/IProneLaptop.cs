using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.task2.Interfaces;

namespace lab2.task2.Classes
{
    public class IProneLaptop : ILaptop
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IProneLaptop(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"IProneLaptop\nName: {Name}, Description: {Description}");
        }
    }
}
