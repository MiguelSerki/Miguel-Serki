using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPOOP.Empleados
{
    public abstract class Personal
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Ingreso { get; set; }
        public int Dni { get; set; }
        public int PrecioHora { get; set; }
        public int HorasTrabajadas { get; set; }
        public int SueldoBase { get; set; }

        public void TasaAntiguedad()
        {

        }

    }
}
