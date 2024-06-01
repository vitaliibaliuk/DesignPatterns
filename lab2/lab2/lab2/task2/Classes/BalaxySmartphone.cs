using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.task2.Interfaces;
namespace lab2.task2.Classes
{
    public class BalaxySmartphone : ISmartphone
    {
        public string Model { get; set; }
        public string Description { get; set; }
        public BalaxySmartphone(string model, string description)
        {
            Model = model;
            Description = description;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"BalaxySmartphone\nModel: {Model}, Description: {Description}");
        }
    }
}
