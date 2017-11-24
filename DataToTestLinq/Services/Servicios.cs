using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataToTestLinq;
using Services.Models;

namespace Services
{
    public class Servicios
    {
        public static IEnumerable<PersonModel> TodasLasPersonas()
        {
            return DataContext.People.Select(person => new PersonModel
            {
                Name = person.Name,
                Country = person.Country,
                Age = DateTime.Today.Year - person.DateOfBorn.Year
            }).Union(DataContext.People
                .Where(person => person.Children.Count() != 0)
                .SelectMany(person => person.Children)
                .Select(child => new PersonModel
                {
                    Name = child.Name,
                    Country = child.Country,
                    Age = DateTime.Today.Year - child.DateOfBorn.Year
                }));
        }
        public static IEnumerable<PersonName> Mujeres()
        {
            return DataContext.People
                .Where(person => person.Gender == Gender.Feminine)
                .Select(person => new PersonName
                {
                    Name = person.Name,
                }).Union(DataContext.People
                .Where(person => person.Children.Count() != 0)
                .SelectMany(person => person.Children)
                .Where(child => child.Gender == Gender.Feminine)
                .Select(child => new PersonName
                {
                    Name = child.Name,
                }));
        }
        public static IEnumerable<PersonWeight> Pesos()
        {
            return DataContext.People
                .Where(person => person.Weight > 70)
                .Select(person => new PersonWeight
                {
                    Name = person.Name,
                    Weight = person.Weight
                }).Union(DataContext.People
        .Where(person => person.Children.Count() != 0)
        .SelectMany(person => person.Children)
        .Where(child => child.Weight > 70)
        .Select(child => new PersonWeight
        {
            Name = child.Name,
            Weight = child.Weight
        }));
        }
        public static double Promedio()
        {
            var x = DataContext.People
                .Select(person => DateTime.Now.Year - person.DateOfBorn.Year)
                .Average();
            return x;
        }
        public static IEnumerable<CountryModel> PromedioPaises()
        {
            var x = DataContext.People
                .GroupBy(person => person.Country)
                .Select(y => new CountryModel
                {
                    Name = y.Key,
                    Avg = y.Select(z => DateTime.Now.Year - z.DateOfBorn.Year).Average()
                }
                    );
            return x;
        }
        public static IEnumerable<WeightModel> PesosPorGenero(){

            var x = DataContext.People
                .GroupBy(p => p.Gender)
                .Select(p => new WeightModel {
                    Avg = p.Select(z => DateTime.Now.Year - z.DateOfBorn.Year).Average(),
                    Gender = p.Key.ToString()
                });
            return x;
        }

        public static PersonWeight LaMasPesada()
        {
            return DataContext.People
                .OrderByDescending(p => p.Weight)
                .Select(p => new PersonWeight
                {
                    Name = p.Name,
                    Weight = p.Weight
                })
                .FirstOrDefault();
        }
        public static PersonWeight LaMenosPesada()
        {
            return DataContext.People
                .OrderBy(p => p.Weight)
                .Select(p => new PersonWeight
                {
                    Name = p.Name,
                    Weight = p.Weight
                })
                .FirstOrDefault();
        }

    }
}
