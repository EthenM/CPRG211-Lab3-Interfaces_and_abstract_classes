using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces_and_abstract_classes.Abstract_classes
{
    /// <summary>
    /// A class to build a Cat object from the <see cref="Animal"/> abstract class.
    /// </summary>
    internal class Cat : Animal
    {
        public Cat()
        {
            //nothing needs to go here, this is only needed to default inherited properties
        }

        public Cat(string name, string colour, int age) : base(name, colour, age)
        {
            //nothing needs to go here, this is only needed to default inherited properties
        }

        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }

    }
}
