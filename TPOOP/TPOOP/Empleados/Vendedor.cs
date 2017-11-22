using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPOOP.Empleados
{
    public class Vendedor : Empleados
    {
        public override decimal CalcularAntiguedad()
        {

            if ((this.Ingreso - DateTime.Today.Year) > 5)
            {
                return (this.CalcularHorasTrabajadas() * 2.5m) / 100;
            }
            else if ((this.Ingreso - DateTime.Today.Year) > 10)
            {
                return (this.CalcularHorasTrabajadas() * 5m) / 100;
            }
            else
            {
                return 0;
            }

        }

        public override decimal CalcularSueldo()
        {
            throw new NotImplementedException();
        }
    }
}
