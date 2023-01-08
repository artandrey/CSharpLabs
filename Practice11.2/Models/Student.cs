using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11._2
{
    delegate bool StudentPredicateDelegate(Student student);
    
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public static bool ValidateAgeIsMature(Student student) => student.Age >= 18;
        public static bool ValidateFirstNameStartsWithA(Student student) => student.FirstName.StartsWith("A");
        public static bool ValidateLastNameLonger3(Student student) => student.LastName.Length > 3;

        public override string ToString()
        {
            return $"First name: {FirstName}\t Last name: {LastName}\t Age: {Age}";
        }
    }
}
