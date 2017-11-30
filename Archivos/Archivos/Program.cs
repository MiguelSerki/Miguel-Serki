using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"\\fsitsv17\MOS-alumnos\alumno\Miguel Serki\NetLab\Sample.txt";

            CreateAndText(path);
            Console.ReadLine();

        }

        public static void CreateFile(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("El archivo ya existe");
            }
            else
            {
                using (File.Create(path))
                {
                    Console.WriteLine("Archivo creado exitosamente");
                } 
            }
        }
        public static void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("Archivo borrado exitosamente");
            }
            else
            {
                Console.WriteLine("El archivo no existe");
            }
        }
        public static void CreateIfExists(string path)
        {
            if (File.Exists(path))
            {
                DeleteFile(path);
                CreateFile(path);
            }
            else
            {
                Console.WriteLine("El archivo no existe");
            }
        }
        public static void CreateAndText(string path)
        {
            CreateFile(path);

            using (StreamWriter str = File.CreateText(path))
            {
                str.WriteLine("No lo mojes");
                str.WriteLine("Ni le des de comer");
            }


        }

    }
}
