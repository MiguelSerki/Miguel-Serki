using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPOOP.Empleados
{
    public interface IEmpleados
    {

        string Nombre { get; set; }
        string Apellido { get; set; }
        int Ingreso { get; set; }
        int Dni { get; set; }
        decimal PrecioHora { get; set; }
        int HorasTrabajadas { get; set; }
        decimal SueldoBase { get; set; }

        decimal CalcularAntiguedad();
        decimal CalcularHorasTrabajadas();
        decimal CalcularSueldo();
    }
}
