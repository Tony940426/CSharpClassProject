using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClassProject
{
    internal class Car
    {
        public string Model { get; set; }
        //member variable
        private string _model = "";


        public Car(string model)
        {
            _model = model;
            Console.WriteLine($"Hello {model}");
        }
    }
}
