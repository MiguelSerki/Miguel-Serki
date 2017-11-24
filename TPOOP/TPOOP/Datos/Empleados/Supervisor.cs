using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPOOP.Datos
{
    public class Supervisor : Empleados, ISupervisor
    {
        public string Categoria { get; set; }

        public override decimal CalcularAntiguedad()
        {
            if ((DateTime.Today.Year - this.Ingreso) > 10)
            {
                return (this.CalcularHorasTrabajadas() * 10m) / 100;
            }
            else if ((DateTime.Today.Year - this.Ingreso) > 5)
            {
                return (this.CalcularHorasTrabajadas() * 5m) / 100;
            }
            else
            {
                return 0;
            }
        }

        public decimal CalcularComision()
        {
          switch (this.Categoria.ToLower())
            {
                case "a":
                    return (this.CalcularHorasTrabajadas() * 10m) / 100;
                case "b":
                    return (this.CalcularHorasTrabajadas() * 5m) / 100;
                case "c":
                    return (this.CalcularHorasTrabajadas() * 2m) / 100;
                default:
                    Console.WriteLine("Algo horrible ha pasado! Cierre el sistema y queme a su programador");
                    return 0;
            }
        }

        public override decimal CalcularSueldo()
        {
            decimal Total = this.SueldoBase + this.CalcularAntiguedad()+ this.CalcularHorasTrabajadas() + this.CalcularComision();
            return Total;
        }
    }
}
