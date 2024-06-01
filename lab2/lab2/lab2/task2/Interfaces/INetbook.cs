using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.task2.Interfaces
{
    public interface INetbook : IDevice
    {
        string Name { get; set; }
        int Width { get; set; }
        int Height { get; set; }
    }
}