using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Personas
{
    public abstract class Catedra : Persona
    {
        public string Experiencia { get; set; }
        public int Sueldo { get; set; }
        public abstract int BaseSueldo { get;}

        public int CalcularSueldos()
        {
            
            return int.Parse(this.Experiencia) * this.BaseSueldo;
        }
    }
}
