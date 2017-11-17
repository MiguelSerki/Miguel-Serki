using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas__16_
{
    class Program
    {
        static void Main(string[] args)
        {

            var dates = new List<DateTime> {
       new DateTime(2017, 1, 21),
       new DateTime(2014, 2, 17),
       new DateTime(2013, 3, 20),
       new DateTime(2012, 4, 2),
       new DateTime(2010, 10, 7),
       new DateTime(2018, 6, 8),
       new DateTime(2025, 7, 9),
       new DateTime(2022, 8, 11),
       new DateTime(1980, 9, 12),
       new DateTime(1970, 10, 13),
       new DateTime(2099, 11, 18),
       new DateTime(1945, 12, 15),
   };

            MayoresHoy(dates);
            Octubre(dates);
            Dosmil(dates);
            Console.ReadLine();
        }

        public static void MayoresHoy(List<DateTime> lista)
        {
            Console.WriteLine("Fechas mayoress a hoy");
            var hoy = DateTime.Now;
            foreach (DateTime n in lista)
            {
                if (hoy > n)
                    continue;
                Console.WriteLine(n.ToShortDateString());
            }
        }

        public static void Octubre(List<DateTime> lista)
        {
            Console.WriteLine("Fechas de Octubre");
            foreach (DateTime n in lista)
            {
                if (n.Month != 10)
                    continue;
                Console.WriteLine(n.ToShortDateString());
            }
        }

        public static void Dosmil(List<DateTime> lista)
        {
            Console.WriteLine("Fechas menores al año 2000");
            foreach (DateTime n in lista)
            {
                if (n.Year > 2000)
                    continue;
                Console.WriteLine(n.ToShortDateString());
            }
        }
    }
}
