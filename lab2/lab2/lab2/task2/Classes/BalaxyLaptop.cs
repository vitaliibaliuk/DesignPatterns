using lab2.task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.task2.Classes
{
    public class BalaxyLaptop : ILaptop
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public BalaxyLaptop(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"BalaxyLaptop\nName: {Name}, Description: {Description}");
        }
    }
}