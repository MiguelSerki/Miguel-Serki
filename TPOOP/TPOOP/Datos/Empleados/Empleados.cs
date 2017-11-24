using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPOOP.Datos
{
    public abstract class Empleados : IEmpleados
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Ingreso { get; set; }
        public string Dni { get; set; }
        public decimal PrecioHora { get; set; }
        public int HorasTrabajadas { get; set; }
        public decimal SueldoBase { get; set; }

        public decimal CalcularHorasTrabajadas()
        {
            return this.PrecioHora * this.HorasTrabajadas;
        }
        public abstract decimal CalcularAntiguedad();
        public abstract decimal CalcularSueldo ();

    }
}
