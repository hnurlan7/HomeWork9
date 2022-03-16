using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork9.Models
{
    internal class Person
    {
        private string _name;
        private string _surname;
        private int _age;

        public string Name
        {
            get { return _name; }
            set
            {
                if (IsUpperMethod(value) == true && MinMax(3, 30, value))
                {
                    Console.WriteLine(value);
                    return;
                }
                Console.WriteLine("Deyer oyuk herfle baslamalidir ve length 3 den boyuk 30den kicik olmalidir");
                _name = value;
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (IsUpperMethod(value) == true && MinMax(3, 35, value) == true)
                {
                    Console.WriteLine(value);
                    return;
                }
                Console.WriteLine("Deyer oyuk herfle baslamalidir ve length 3 den boyuk 35den kicik olmalidir");
                _surname = value;
            }
        }
        public int Age { get; set; }

        public Person(string _name,string _surname, int _age)
        {
            this.Name = _name;
            this.Age = _age;
        }

        private bool IsUpperMethod(string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (Char.IsUpper(value[0]))
                {
                    return true;
                }
            }
            return false;
        }
        private bool MinMax(int min, int max, string value)
        {
            if (value.Length <= min && value.Length >= max)
            {
                return false;
            }
            return true;
        }

    }
}
