using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.task2.Interfaces;
using lab2.task2.Classes;

namespace lab2.task2.Brands
{
    public class Kiaomi : Factory
    {
        public ILaptop CreateLaptop()
        {
            return new KiaomiLaptop("Kiaomi Name Laptop", "Some Laptop Kiaomi");
        }

        public INetbook CreateNetbook()
        {
            return new KiaomiNetbook("Kiaomi Name NetBook", 35, 40);
        }

        public ISmartphone CreateSmartphone()
        {
            return new KiaomiSmartphone("Kiaomi Model", "Some Kiaomi Smartphone description");
        }
    }
}
