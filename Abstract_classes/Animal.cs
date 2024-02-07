using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces_and_abstract_classes.Abstract_classes
{
    /// <summary>
    /// Provides an abstract class with which to build animal classes off of
    /// </summary>
    internal abstract class Animal
    {
        public string Name { get; private set; }
        public string Colour { get; private set; }
        public int Age { get; private set; }

        public Animal()
        {
            Name = "";
            Colour = "";
            Age = 0;
        }

        public Animal(string name, string colour, int age)
        {
            Name = name;
            Colour = colour;
            Age = age;
        }

        /// <summary>
        /// Prints what the animal eats.
        /// </summary>
        public abstract void Eat();
    }
}
