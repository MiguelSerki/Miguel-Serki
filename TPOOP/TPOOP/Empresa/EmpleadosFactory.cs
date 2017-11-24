using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPOOP.Empleados;

namespace TPOOP.Empresa
{
    public class EmpleadosFactory
    {
        public static IEmpleados GetEmpleado <T>( string tipo) where T :IEmpleados
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