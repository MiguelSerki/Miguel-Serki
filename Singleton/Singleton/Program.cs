using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton a = Singleton.Instance();
            Singleton b = Singleton.Instance();

            if (a == b)
            {
                Console.WriteLine("Los objetos son los mismos");
            }

            Console.ReadLine();
        }
    }
}
