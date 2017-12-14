using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Person
            {
                Name = "Miguel",
                Surname = "Serki"
            };

            var method = typeof(Person).GetType().GetMethod("Caminar");
            method.Invoke(persona, null);




        }

        public static void Brujeria()
        {
            Console.WriteLine("ingrese el tipo que quiere crear: Person/Student");
            var algo = Console.ReadLine();
            var dynamicType = typeof(Program).Assembly.GetTypes().First(c => c.Name == algo);
            // var dynamicType2 = Assembly.GetExecutingAssembly().GetTypes().First(c => c.Name == algo);
            var person = Activator.CreateInstance(dynamicType);


            //properties
            Console.WriteLine("Ingrese el nombre de la propiedad para editar: ");
            var ingreso = Console.ReadLine();

            var type = person.GetType(); //typeof(Person)
            //var value = type.GetProperty(ingreso).GetValue(person);

            Console.WriteLine("Ingrese el valor que desea: ");
            var value = Console.ReadLine();

            type.GetProperty(ingreso).SetValue(person, value);

            Console.WriteLine(type.GetProperty(ingreso).GetValue(person));
            Console.ReadLine();
        }

        public static void Mapper()
        {
            var student = new Student();
            var persona = new Person
            {
                Name = "Miguel",
                Surname = "Serki"
            };

            var studentType = student.GetType();
            var pType = persona.GetType();

            foreach (var item in pType.GetProperties())
            {
                var getProperty = pType.GetProperty(item.Name);
                studentType.GetProperty(item.Name).SetValue(student, getProperty.GetValue(persona));
            }
        }
    }
}
