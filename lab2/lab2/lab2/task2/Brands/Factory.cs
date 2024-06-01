using lab2.task2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab2.task2.Brands
{
    public interface Factory
    {
        public ISmartphone CreateSmartphone();
        public ILaptop CreateLaptop();
        public INetbook CreateNetbook();
    }
}
