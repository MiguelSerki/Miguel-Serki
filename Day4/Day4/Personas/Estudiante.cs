namespace Day4
{
    public class Estudiante : Persona
    {
        public string Legajo { get; set; }
        public string Dni { get; set; }
        public string Ingreso { get; set; }

        public override string Presentacion()
        {
            return $"Hola soy un estudiante {this.Apellido} {this.Nombre} legajo : {this.Legajo}, Dni : {this.Dni}, Año de ingreso: {this.Ingreso}";
        }
    }

    public class Profesor : Personas.Catedra
    {
        public string Materia { get; set; }
        public string Dni { get; set; }
        public override int BaseSueldo => 2000;

        public override string Presentacion()
        {
            return $"Hola soy el profesor {this.Apellido} {this.Nombre} de la materia {this.Materia}, con {this.Experiencia} años de experiencia y cobro {this.Sueldo}";
        }
    }

    public class Ayudante : Personas.Catedra
    {
        public string Legajo { get; set; }
        public string Dni { get; set; }
        public string Ingreso { get; set; }
        public override int BaseSueldo => 1000;

        public override string Presentacion()
        {
            return $"Hola soy el ayudante {this.Apellido} {this.Nombre} Legajo : {this.Legajo}, con {this.Experiencia} años de experiencia y cobro {this.Sueldo}";

        }
    }
}