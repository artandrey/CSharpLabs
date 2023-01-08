using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice11._2.Extension;

namespace Practice11._2
{
    internal class Program
    {
        private static void LogStudent(Student student)
        {
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Andrii", "Artemenko", 19),
                new Student("Oleg", "Polyak", 18),
                new Student("Yakiv", "Shapenyuk", 20),
                new Student("Victor", "Triangle", 19),
                new Student("Taras", "Normas", 19),
                new Student("John", "Cena", 18),
                new Student("Nabur", "Andrii", 21),
                new Student("Fred", "Cacke", 18),
                new Student("Ivan", "Cache", 19),
                new Student("Luke", "Skyswimmer", 18),
                new Student("Aaron", "Bjec", 20),
                new Student("Anton", "Who", 17),
            };

            Console.WriteLine("\n\nAge filter\n\n");
            students.FindStudent(Student.ValidateAgeIsMature).ForEach(student => Console.WriteLine(student));
            Console.WriteLine("\n\nFirst name First letter filter\n\n");
            students.FindStudent(Student.ValidateFirstNameStartsWithA).ForEach(student => Console.WriteLine(student));
            Console.WriteLine("\n\nLast name Length filter\n\n");
            students.FindStudent(Student.ValidateLastNameLonger3).ForEach(student => Console.WriteLine(student));

            Console.ReadLine();
        }
    }
}
