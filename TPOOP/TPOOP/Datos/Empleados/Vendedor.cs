using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPOOP.Datos
{
    public class Vendedor : Empleados
    {
        public override decimal CalcularAntiguedad()
        {

            if ((DateTime.Today.Year - this.Ingreso) > 10)
            {
                return (this.CalcularHorasTrabajadas() * 5m) / 100;
            }
            else if ((DateTime.Today.Year - this.Ingreso) > 5)
            {
                return (this.CalcularHorasTrabajadas() * 2.5m) / 100;
            }
            else
            {
                return 0;
            }

        }

        public override decimal CalcularSueldo()
        {
            decimal Total = this.SueldoBase + this.CalcularAntiguedad()+ this.CalcularHorasTrabajadas();
            return Total;
        }
    }
}
