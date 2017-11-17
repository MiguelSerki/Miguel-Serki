using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {

       
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("Juan", 1500);
            cuenta.Ingresar();
            cuenta.Ingresar();
            cuenta.Retirar();
            Console.ReadLine();
        }
    }
}
