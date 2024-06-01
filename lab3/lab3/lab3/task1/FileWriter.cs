using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab3.task1;
namespace lab3.task1
{
    public class FileWriter
    {
        public void Write(string sth)
        {
            Console.Write("Write something without new line:");
            Console.Write(sth);
        }
        public void WriteLine(string sth)
        {
            Console.WriteLine("\nWrite something with new line:");
            Console.WriteLine(sth);
        }
    }
}
