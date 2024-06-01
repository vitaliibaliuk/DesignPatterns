using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.task2.Interfaces;
using lab2.task2.Classes;

namespace lab2.task2.Brands
{
    public class IProne : Factory
    {
        public ILaptop CreateLaptop()
        {
            return new IProneLaptop("IProne Name Laptop", "Some IProne Laptop");
        }

        public INetbook CreateNetbook()
        {
            return new IProneNetbook("IProne Name NetBook", 35, 40);
        }

        public ISmartphone CreateSmartphone()
        {
            return new IProneSmartphone("IProne Model", "Some IProne Smartphone description");
        }
    }
}
