﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.task3
{
    public class Raster : ITypeDrawing
    {
        public void DrawCircle()
        {
            Console.WriteLine("Drawing Circle as pixels");
        }

        public void DrawSquare()
        {
            Console.WriteLine("Drawing Square as pixels");
        }

        public void DrawTriangle()
        {
            Console.WriteLine("Drawing Triangle as pixels");
        }
    }
}
