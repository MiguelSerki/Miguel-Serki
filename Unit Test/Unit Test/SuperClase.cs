using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test
{
   public  class SuperClase
    {

       public decimal SuperOperacion(decimal salario)
        {
            //
            var liquidador = new LiquidarEmpleado();
            liquidador.Liquidar(500);

            //

            return salario * 0.78m;
        }
    }
}
