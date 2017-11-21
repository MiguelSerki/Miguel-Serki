using System;
using Day4.Personas;

namespace Day4
{
    public class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            do
            {
                Linea();
                Console.WriteLine("Ingrese la opcion deseada 'p' Profesores - 'e' Estudiantes, - 'a' Ayudantes, - 's' Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "p":
                        EjecutarMenuProfesores();
                        break;

                    case "e":
                        EjecutarMenuEstudiantes();
                        break;

                    case "a":
                        EjecutarMenuAyudantes();
                        break;
                }
            } while (opcion != "s");

            Linea();
            Console.WriteLine("Fin del programa, ingrese una tecla para continuar");
            Console.ReadLine();
        }

        private static void EjecutarMenuAyudantes()
        {
            Linea();
            Console.WriteLine("Listado 'l' Consultar 'c' Agregar 'a' Modificar 'm' Eliminar 'e'");
            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "l":
                    var ayudantes = BaseDeDatos.Ayudantes;
                    Linea();
                    Console.WriteLine("Ayudantes : ");
                    foreach (var p in ayudantes)
                    {
                        MostrarAyudante(p);
                    }

                    break;

                case "c":
                    Linea();
                    Console.WriteLine("Ingrese el dni a buscar");
                    var dniParaBuscar = Console.ReadLine();

                    Ayudante ayudante = null;

                    foreach (var p in BaseDeDatos.Ayudantes)
                    {
                        if (p.Dni == dniParaBuscar)
                        {
                            ayudante = p;
                            break;
                        }
                    }

                    if (ayudante != null)
                    {
                        MostrarAyudante(ayudante);
                    }
                    else
                    {
                        Console.WriteLine("No existe el estudiante ingresado");
                    }

                    break;

                case "a":
                    Linea();
                    string nuevoAyudanteNombre = null;
                    do
                    {
                        Console.WriteLine("Ingrese nombre");
                        nuevoAyudanteNombre = Console.ReadLine();
                    } while (nuevoAyudanteNombre.Length > 50);
                    string nuevoAyudanteApellido = null;
                    do
                    {
                        Console.WriteLine("Ingrese apellido");
                        nuevoAyudanteApellido = Console.ReadLine();
                    } while (nuevoAyudanteApellido.Length > 50);

                    Console.WriteLine("Ingrese dni");
                    var nuevoAyudanteDni = Console.ReadLine();

                    Console.WriteLine("Ingrese legajo");
                    var nuevoAyudanteLegajo = Console.ReadLine();
                    string nuevoAyudanteIngreso = null;
                    var a = 0;
                    do
                    {
                        Console.WriteLine("Ingrese año de ingreso");
                        nuevoAyudanteIngreso = Console.ReadLine();
                    } while (int.TryParse(nuevoAyudanteIngreso, out a) && (a >= 2018));

                    Console.WriteLine("Ingrese años de experiencia");
                    var nuevoAyudanteExperiencia = Console.ReadLine();
                         
                    var nuevoAyudante = new Ayudante
                    {
                        Apellido = nuevoAyudanteApellido,
                        Dni = nuevoAyudanteDni,
                        Nombre = nuevoAyudanteNombre,
                        Legajo = nuevoAyudanteLegajo,
                        Ingreso = nuevoAyudanteIngreso,
                        Experiencia = nuevoAyudanteExperiencia,
                    };
                    nuevoAyudante.Sueldo = nuevoAyudante.CalcularSueldos();

                    BaseDeDatos.Ayudantes.Add(nuevoAyudante);
                    Linea();
                    Console.WriteLine("Ayudante agregado correctamente");
                    break;

                case "m":
                    Linea();
                    Console.WriteLine("Ingrese el dni a buscar");
                    var dniParaEditar = Console.ReadLine();

                    Ayudante ayudanteParaEditar = null;

                    foreach (var p in BaseDeDatos.Ayudantes)
                    {
                        if (p.Dni == dniParaEditar)
                        {
                            ayudanteParaEditar = p;
                            break;
                        }
                    }

                    if (ayudanteParaEditar != null)
                    {
                        Linea();
                        Console.WriteLine("Ingrese nuevo nombre");
                        do
                        {
                            Console.WriteLine("Ingrese nuevo nombre");
                            ayudanteParaEditar.Nombre = Console.ReadLine();
                        } while (ayudanteParaEditar.Nombre.Length > 50);
                        do
                        {
                            Console.WriteLine("Ingrese nuevo apellido");
                            ayudanteParaEditar.Apellido = Console.ReadLine();
                        } while (ayudanteParaEditar.Apellido.Length > 50);
                        Console.WriteLine("Ingrese nuevo dni");
                        ayudanteParaEditar.Dni = Console.ReadLine();

                        Console.WriteLine("Ingrese nuevo numero de legajo");
                        ayudanteParaEditar.Legajo = Console.ReadLine();

                        do
                        {
                            Console.WriteLine("Ingrese nuevo año de ingreso");
                            ayudanteParaEditar.Ingreso = Console.ReadLine();
                        } while (int.TryParse(ayudanteParaEditar.Ingreso, out a) && (a >= 2018));

                        ayudanteParaEditar.Sueldo = ayudanteParaEditar.CalcularSueldos();

                        Linea();
                        Console.WriteLine("Ayudante editado correctamente");
                    }
                    else
                    {
                        Console.WriteLine("No existe el ayudante ingresado");
                    }
                    break;

                case "e":
                    Linea();
                    Console.WriteLine("Ingrese el dni a buscar");
                    var dniParaRemover = Console.ReadLine();

                    Ayudante ayudanteParaRemover = null;

                    foreach (var p in BaseDeDatos.Ayudantes)
                    {
                        if (p.Dni == dniParaRemover)
                        {
                            ayudanteParaRemover = p;
                            break;
                        }
                    }

                    if (ayudanteParaRemover != null)
                    {
                        BaseDeDatos.Ayudantes.Remove(ayudanteParaRemover);

                        Linea();
                        Console.WriteLine("Ayudante eliminado correctamente");
                    }
                    else
                    {
                        Console.WriteLine("No existe el ayudante ingresado");
                    }

                    break;
            }

            opcion = Console.ReadLine();
        }

        private static void EjecutarMenuEstudiantes()
        {
            Linea();
            Console.WriteLine("Listado 'l' Consultar 'c' Agregar 'a' Modificar 'm' Eliminar 'e'");
            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "l":
                    var estudiantes = BaseDeDatos.Estudiantes;
                    Linea();
                    Console.WriteLine("Estudiantes : ");
                    foreach (var p in estudiantes)
                    {
                        MostrarEstudiante(p);
                    }

                    break;

                case "c":
                    Linea();
                    Console.WriteLine("Ingrese el dni a buscar");
                    var dniParaBuscar = Console.ReadLine();

                    Estudiante estudiante = null;

                    foreach (var p in BaseDeDatos.Estudiantes)
                    {
                        if (p.Dni == dniParaBuscar)
                        {
                            estudiante = p;
                            break;
                        }
                    }

                    if (estudiante != null)
                    {
                        MostrarEstudiante(estudiante);
                    }
                    else
                    {
                        Console.WriteLine("No existe el estudiante ingresado");
                    }

                    break;

                case "a":
                    Linea();
                    string nuevoEstudianteNombre = null;
                    do
                    {
                        Console.WriteLine("Ingrese nombre");
                        nuevoEstudianteNombre = Console.ReadLine();
                    } while (nuevoEstudianteNombre.Length > 50);
                    string nuevoEstudianteApellido = null;
                    do
                    {
                        Console.WriteLine("Ingrese apellido");
                        nuevoEstudianteApellido = Console.ReadLine();
                    } while (nuevoEstudianteApellido.Length > 50);

                    Console.WriteLine("Ingrese dni");
                    var nuevoEstudianteDni = Console.ReadLine();

                    Console.WriteLine("Ingrese legajo");
                    var nuevoEstudianteLegajo = Console.ReadLine();
                    string nuevoEstudianteIngreso = null;
                    var a = 0;
                    do
                    {
                        Console.WriteLine("Ingrese año de ingreso");
                        nuevoEstudianteIngreso = Console.ReadLine();
                    } while (int.TryParse(nuevoEstudianteIngreso, out a) && (a >= 2018));

                    var nuevoEstudiante = new Estudiante
                    {
                        Apellido = nuevoEstudianteApellido,
                        Dni = nuevoEstudianteDni,
                        Nombre = nuevoEstudianteNombre,
                        Legajo = nuevoEstudianteLegajo,
                        Ingreso = nuevoEstudianteIngreso
                    };

                    BaseDeDatos.Estudiantes.Add(nuevoEstudiante);
                    Linea();
                    Console.WriteLine("Estudiante agregado correctamente");
                    break;

                case "m":
                    Linea();
                    Console.WriteLine("Ingrese el dni a buscar");
                    var dniParaEditar = Console.ReadLine();

                    Estudiante estudianteParaEditar = null;

                    foreach (var p in BaseDeDatos.Estudiantes)
                    {
                        if (p.Dni == dniParaEditar)
                        {
                            estudianteParaEditar = p;
                            break;
                        }
                    }

                    if (estudianteParaEditar != null)
                    {
                        Linea();
                        Console.WriteLine("Ingrese nuevo nombre");
                        var editarEstudianteNombre = Console.ReadLine();

                        Console.WriteLine("Ingrese nuevo apellido");
                        var editarEstudianteApellido = Console.ReadLine();

                        Console.WriteLine("Ingrese nuevo dni");
                        var editarEstudianteDni = Console.ReadLine();

                        Console.WriteLine("Ingrese nuevo numero de legajo");
                        var editarEstudianteLegajo= Console.ReadLine();

                        Console.WriteLine("Ingrese nuevo año de ingreso");
                        var editarEstudianteIngreso = Console.ReadLine();

                        estudianteParaEditar.Nombre = editarEstudianteNombre;
                        estudianteParaEditar.Apellido = editarEstudianteApellido;
                        estudianteParaEditar.Dni = editarEstudianteDni;
                        estudianteParaEditar.Legajo = editarEstudianteLegajo;
                        estudianteParaEditar.Ingreso = editarEstudianteIngreso;

                        Linea();
                        Console.WriteLine("Estudiante editado correctamente");
                    }
                    else
                    {
                        Console.WriteLine("No existe el estudiante ingresado");
                    }
                    break;

                case "e":
                    Linea();
                    Console.WriteLine("Ingrese el dni a buscar");
                    var dniParaRemover = Console.ReadLine();

                    Estudiante estudianteParaRemover = null;

                    foreach (var p in BaseDeDatos.Estudiantes)
                    {
                        if (p.Dni == dniParaRemover)
                        {
                            estudianteParaRemover = p;
                            break;
                        }
                    }

                    if (estudianteParaRemover != null)
                    {
                        BaseDeDatos.Estudiantes.Remove(estudianteParaRemover);

                        Linea();
                        Console.WriteLine("Estudiante eliminado correctamente");
                    }
                    else
                    {
                        Console.WriteLine("No existe el estudiante ingresado");
                    }

                    break;
            }

            opcion = Console.ReadLine();
        }

        private static void EjecutarMenuProfesores()
        {
            Linea();
            Console.WriteLine("Listado 'l' Consultar 'c' Agregar 'a' Modificar 'm' Eliminar 'e'");
            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "l":
                    var profesores = BaseDeDatos.Profesores;
                    Linea();
                    Console.WriteLine("Profesores : ");
                    foreach (var p in profesores)
                    {
                        MostrarProfesor(p);
                    }

                    break;

                case "c":
                    Linea();
                    Console.WriteLine("Ingrese el dni a buscar");
                    var dniParaBuscar = Console.ReadLine();

                    Profesor profesor = null;

                    foreach (var p in BaseDeDatos.Profesores)
                    {
                        if (p.Dni == dniParaBuscar)
                        {
                            profesor = p;
                            break;
                        }
                    }

                    if (profesor != null)
                    {
                        MostrarProfesor(profesor);
                    }
                    else
                    {
                        Console.WriteLine("No existe el profesor ingresado");
                    }

                    break;

                case "a":
                    Linea();
                    string nuevoProfesorNombre = null;
                    do
                    {
                        Console.WriteLine("Ingrese nombre");
                        nuevoProfesorNombre = Console.ReadLine();
                    } while (nuevoProfesorNombre.Length > 50);
                    string nuevoProfesorApellido = null;
                    do
                    {
                        Console.WriteLine("Ingrese apellido");
                        nuevoProfesorApellido = Console.ReadLine();
                    } while (nuevoProfesorApellido.Length > 50);

                    Console.WriteLine("Ingrese dni");
                    var nuevoProfesorDni = Console.ReadLine();

                    Console.WriteLine("Ingrese materia");
                    var nuevoProfesorMateria = Console.ReadLine();

                    Console.WriteLine("Ingrese años de experiencia");
                    var nuevoProfesorExperiencia = Console.ReadLine();

                    var nuevoProfesor = new Profesor
                    {
                        Apellido = nuevoProfesorApellido,
                        Dni = nuevoProfesorDni,
                        Nombre = nuevoProfesorNombre,
                        Materia = nuevoProfesorMateria,
                        Experiencia = nuevoProfesorExperiencia,
                    };
                    nuevoProfesor.Sueldo = nuevoProfesor.CalcularSueldos();

                    BaseDeDatos.Profesores.Add(nuevoProfesor);
                    Linea();
                    Console.WriteLine("Profesor agregado correctamente");
                    break;

                case "m":
                    Linea();
                    Console.WriteLine("Ingrese el dni a buscar");
                    var dniParaEditar = Console.ReadLine();

                    Profesor profesorParaEditar = null;

                    foreach (var p in BaseDeDatos.Profesores)
                    {
                        if (p.Dni == dniParaEditar)
                        {
                            profesorParaEditar = p;
                            break;
                        }
                    }

                    if (profesorParaEditar != null)
                    {
                        Linea();
                        do
                        {
                            Console.WriteLine("Ingrese nuevo nombre");
                            profesorParaEditar.Nombre = Console.ReadLine();
                        } while (profesorParaEditar.Nombre.Length > 50);

                        do
                        {
                            Console.WriteLine("Ingrese nuevo apellido");
                            profesorParaEditar.Apellido = Console.ReadLine();
                        } while (profesorParaEditar.Apellido.Length > 50);

                        Console.WriteLine("Ingrese nuevo dni");
                        profesorParaEditar.Dni = Console.ReadLine();

                        Console.WriteLine("Ingrese nueva materia");
                        profesorParaEditar.Materia = Console.ReadLine();

                        Console.WriteLine("Ingrese años de experiencia");
                        profesorParaEditar.Experiencia = Console.ReadLine();

                        profesorParaEditar.Sueldo = profesorParaEditar.CalcularSueldos();

                        Linea();
                        Console.WriteLine("Profesor editado correctamente");
                    }
                    else
                    {
                        Console.WriteLine("No existe el profesor ingresado");
                    }
                    break;

                case "e":
                    Linea();
                    Console.WriteLine("Ingrese el dni a buscar");
                    var dniParaRemover = Console.ReadLine();

                    Profesor profesorParaRemover = null;

                    foreach (var p in BaseDeDatos.Profesores)
                    {
                        if (p.Dni == dniParaRemover)
                        {
                            profesorParaRemover = p;
                            break;
                        }
                    }

                    if (profesorParaRemover != null)
                    {
                        BaseDeDatos.Profesores.Remove(profesorParaRemover);

                        Linea();
                        Console.WriteLine("Profesor eliminado correctamente");
                    }
                    else
                    {
                        Console.WriteLine("No existe el profesor ingresado");
                    }

                    break;
            }

            opcion = Console.ReadLine();
        }

        private static void MostrarProfesor(Profesor p)
        {
            Console.WriteLine($" Nombre : {p.Nombre}, Apellido : {p.Apellido}, Materia : {p.Materia}, Dni: {p.Dni}, Años de experiencia : {p.Experiencia}, Sueldo : {p.CalcularSueldos()}");
        }

        private static void MostrarEstudiante(Estudiante p)
        {
            Console.WriteLine($" Nombre : {p.Nombre}, Apellido : {p.Apellido}, Legajo : {p.Legajo}, Dni : {p.Dni}, Ingreso : {p.Ingreso}");
        }

        private static void MostrarAyudante(Ayudante p)
        {
            Console.WriteLine($" Nombre : {p.Nombre}, Apellido : {p.Apellido}, Legajo : {p.Legajo}, Dni : {p.Dni}, Ingreso : {p.Ingreso}, Sueldo : {p.CalcularSueldos()}, Experiencia : {p.Experiencia}");
        }

        private static void Linea()
        {
            Console.WriteLine("======================");
        }
    }
}