using System.Collections.Generic;

namespace Day4
{
    public static class BaseDeDatos
    {
        public static List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>
        {
            new Estudiante
            {
                Apellido = "Revoledo",
                Legajo = "40608",
                Nombre = "David",
                Dni = "3000000",
                Ingreso = "2017"
            },
            new Estudiante
            {
                Apellido = "Araujo",
                Legajo = "23331",
                Nombre = "Cesar",
                Dni = "2000000",
                Ingreso = "2017"
            }
        };

        public static List<Profesor> Profesores { get; set; } = new List<Profesor>
        {
            new Profesor
            {
                Apellido = "Revoledo",
                Materia = ".Net",
                Nombre = "David",
                Dni = "35444444",
                Experiencia = "20"
            }
        };

        public static List<Ayudante> Ayudantes { get; set; } = new List<Ayudante>
        {
            new Ayudante
            {
                Apellido = "Serki",
                Nombre = "Miguel",
                Dni = "36765467",
                Experiencia = "1",
                Legajo = "3652",
                Ingreso = "2017"
            }
        };
    }
}