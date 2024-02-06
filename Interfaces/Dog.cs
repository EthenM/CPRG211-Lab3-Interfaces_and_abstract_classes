using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces_and_abstract_classes.Interfaces
{
    internal class Dog : IAnimal
    {
        public string Name { get; private set; }
        public string Colour { get; private set; }
        public double Height { get; private set; }
        public int Age {  get; private set; }

        private readonly string cry = "Woof!";

        public Dog()
        {
            Name = "";
            Colour = "";
            Height = 0;
            Age = 0;
        }

        public Dog(string name, string colour, double height, int age)
        {
            Name = name;
            Colour = colour;
            Height = height;
            Age = age;
        }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }

        public string Cry()
        {
            return cry;
        }
        
    }
}
