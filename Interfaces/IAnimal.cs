using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces_and_abstract_classes.Interfaces
{
    internal interface IAnimal
    {

        //might change this, as it doesn't work great with encapsulation
        string Name { get; }
        string Colour { get; }
        double Height { get; }
        int Age { get; }

        abstract void Eat();

        abstract string Cry();
    }
}
