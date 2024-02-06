using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces_and_abstract_classes.Abstract_classes
{
    internal class Dog : Animal
    {
        public Dog()
        {
            //nothing needs to go here, this is only needed to default inherited properties
        }

        public Dog(string name, string colour, int age) : base(name, colour, age)
        {
            //nothing needs to go here, this is only needed to default inherited properties
        }

        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
    }
}
