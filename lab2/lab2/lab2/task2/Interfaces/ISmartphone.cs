using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.task2.Interfaces
{
    public interface ISmartphone : IDevice
    {
        string Model { get; set; }
        string Description { get; set; }
    }
}