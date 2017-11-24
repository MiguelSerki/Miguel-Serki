using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPOOP.Datos;

namespace TPOOP.Negocios
{
    public class EmpleadosFactory
    {
        public static IEmpleados GetEmpleado( string tipo)
        {
            switch (tipo.ToLower())
            {
                case "v":
                    return new Vendedor();
                case "s":
                    return new Supervisor();
                default:
                    Console.WriteLine("Algo horrible ha pasado mientras construiamos tu empleado!");
                    return default;
                
            }
        }
    }
}