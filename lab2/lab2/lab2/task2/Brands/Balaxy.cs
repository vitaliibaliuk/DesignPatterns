using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.task2.Interfaces;
using lab2.task2.Classes;

namespace lab2.task2.Brands
{
    public class Balaxy : Factory
    {
        public ILaptop CreateLaptop()
        {
            return new BalaxyLaptop("Balaxy Name Laptop", "Some Laptop");
        }

        public INetbook CreateNetbook()
        {
            return new BalaxyNetbook("Balaxy Name NetBook", 20, 30);
        }

        public ISmartphone CreateSmartphone()
        {
            return new BalaxySmartphone("Balaxy Model", "Some Balaxy Smartphone description");
        }
    }
}
