using System;
using HomeWork9.Models;

namespace HomeWork9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("Nurlan", "hov", 23);
            //Console.WriteLine(person.Surname);
            Student student = new Student(808, "Nurlan", "Hamidov", 21);
            Console.WriteLine(student.Age);
        }
    }
}
