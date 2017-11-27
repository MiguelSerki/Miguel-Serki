using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPOOP.Datos;

namespace TPOOP.Negocios
{
    public class SupervisorBuilder <T> : EmpleadoBuilder <T> where T : ISupervisor
    {


        public void SetCategoria(ISupervisor Empleado)
        {
            Console.WriteLine("Categoria:");

            do
            {
                Console.WriteLine("Elija una categoria: A  B  C");
                Empleado.Categoria = Console.ReadLine();
            } while (!(Empleado.Categoria.ToLower() == "a") && !(Empleado.Categoria.ToLower() == "b") && !(Empleado.Categoria.ToLower() == "c"));
            
        }

    }
}
