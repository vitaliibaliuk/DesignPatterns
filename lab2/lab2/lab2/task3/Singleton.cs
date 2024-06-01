using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.task3
{

    public class Authenticator
    {
        private static Authenticator? _instance;
        private static object _lock = new object();

        private Authenticator()
        {
            Console.WriteLine("Initializing Authenticator");
        }

        public static Authenticator GetInstance()
        {
            if (Authenticator._instance == null)
            {
                lock (Authenticator._lock)
                {
                    if (Authenticator._instance == null)
                    {
                        Authenticator._instance = new Authenticator();
                    }
                }
            }
            return Authenticator._instance;
        }
    }
}