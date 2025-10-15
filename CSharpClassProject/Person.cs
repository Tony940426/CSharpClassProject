using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClassProject
{
    internal class Person
    {
        public string name {
            get { return _name; }
            set { _name = value; }
        }

        public int age
        {
            get { return _age; }
            set 
            { _age = value; }
        }

        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            _age = age;
            _name = name;
        }

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {_name} and I am {_age} years old.");
        }

    }

}
