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
        //member variable
        private string _model = "";
        public string Model { get => _model; set => _model = value; } 
        public string Color { get; set; } = "Black";
        public string MyClass { get; }


        public Car(string model, string series = "5 Series", string year = "2024")
        {
            _model = model;
            Console.WriteLine($"Hello {model}");
        }
        public Car()
        {
            
        }
    }
}
