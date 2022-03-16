using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork9.Models
{
    internal class Student : Person
    {
        private int _point;
        public int Point
        {
            get {return _point; }
            set {
                if (value >= 0 && value <= 100)
                {
                    Console.WriteLine(value);
                    return;
                }
                Console.WriteLine("Deyer min 0 max 100 olmalidir");
                _point = value;
            }
        }
        public Student(int _point, string _name, string _surname, int _age):base(_name, _surname, _age )
        {
            this.Point = _point;
        }


    }
}
