using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.task2.Interfaces;

namespace lab2.task2.Classes
{
    public class IProneNetbook : INetbook
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public IProneNetbook(string name, int width, int height)
        {
            Name = name;
            Width = width;
            Height = height;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"IProneNetbook\nName: {Name}, Width: {Width}, Height: {Height}");
        }
    }
}
