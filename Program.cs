using Ex._1_Laborator_16_.Models;
using System;
using System.Linq;

namespace Ex._1_Laborator_16_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercitiul – 1 
            /*
             • Creeati modelul, adaugati EF 3.1,
             Adaugati DB
             • Creeati in clasa “main” o functie
             “Seed” care va popula DB-ul
             */

            SeedTable();

            using StudentDBContext context = new StudentDBContext();

            //Afisati toti studentii din DB in
            //ordine alfabetica

            context.Students.OrderBy(s=>s.Age).ToList().ForEach(s => Console.WriteLine(s));
            Console.WriteLine();

            //Afisati cel mai tanar student de
            //la constructii cu varsta de peste
            //20 de ani

            Console.WriteLine(context.Students.Where(s => s.Major == Student.MajorType.Constructions).FirstOrDefault(s => s.Age > 20));
        }
        static void SeedTable()
        {
            using var ctx = new StudentDBContext();

            if (ctx.Students.Count() != 0)
            {
                return;
            }

            ctx.Students.Add(new Student
            {
                FirstName = "Ionut",
                LastName = "Antonescu",
                Age = 20,
                Major = Student.MajorType.Constructions
            });
            
            ctx.Students.Add(new Student
            {
                FirstName = "Ioana",
                LastName = "Popescu",
                Age = 20,
                Major = Student.MajorType.Languages
            });
            
            ctx.Students.Add(new Student
            {
                FirstName = "Dan",
                LastName = "Bitman",
                Age = 45,
                Major = Student.MajorType.Constructions
            });
            
            ctx.Students.Add(new Student
            {
                FirstName = "Crina",
                LastName = "Manea",
                Age = 30,
                Major = Student.MajorType.Informatics
            });
            
            ctx.Students.Add(new Student
            {
                FirstName = "George",
                LastName = "Trifan",
                Age = 22,
                Major = Student.MajorType.Constructions
            });
            
            ctx.Students.Add(new Student
            {
                FirstName = "Paul",
                LastName = "Dobre",
                Age = 18,
                Major = Student.MajorType.Languages
            });
            
            ctx.Students.Add(new Student
            {
                FirstName = "Diana",
                LastName = "Velescu",
                Age = 25,
                Major = Student.MajorType.Constructions
            });
            
            ctx.Students.Add(new Student
            {
                FirstName = "John",
                LastName = "Carpenter",
                Age = 21,
                Major = Student.MajorType.Languages
            });
            
            ctx.Students.Add(new Student
            {
                FirstName = "Ionut",
                LastName = "Antonescu",
                Age = 22,
                Major = Student.MajorType.Constructions
            });
            
            ctx.Students.Add(new Student
            {
                FirstName = "Lucian",
                LastName = "Coman",
                Age = 31,
                Major = Student.MajorType.Languages
            });
            
            ctx.Students.Add(new Student
            {
                FirstName = "Andreea",
                LastName = "Caliman",
                Age = 35,
                Major = Student.MajorType.Informatics
            });
            
            ctx.Students.Add(new Student
            {
                FirstName = "George",
                LastName = "Antonescu",
                Age = 20,
                Major = Student.MajorType.Constructions
            });
            
            ctx.Students.Add(new Student
            {
                FirstName = "Andreea",
                LastName = "Coman",
                Age = 18,
                Major = Student.MajorType.Languages
            });
            
            ctx.Students.Add(new Student
            {
                FirstName = "Razvan",
                LastName = "Florea",
                Age = 25,
                Major = Student.MajorType.Informatics
            });
            
            ctx.Students.Add(new Student
            {
                FirstName = "Gheorghe",
                LastName = "Gherghel",
                Age = 42,
                Major = Student.MajorType.Constructions
            });
            
            ctx.Students.Add(new Student
            {
                FirstName = "Izabela",
                LastName = "Popa",
                Age = 21,
                Major = Student.MajorType.Languages
            });
            
            ctx.Students.Add(new Student
            {
                FirstName = "Sebi",
                LastName = "Popa",
                Age = 21,
                Major = Student.MajorType.Languages
            });


            ctx.SaveChanges();
        }
    }
}
