using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces_and_abstract_classes.Interfaces
{
    /// <summary>
    /// The structure for building animal classes off of.
    /// </summary>
    internal interface IAnimal
    {

        //might change this, as it doesn't work great with encapsulation
        string Name { get; }
        string Colour { get; }
        double Height { get; }
        int Age { get; }

        /// <summary>
        /// Prints what the animal eats.
        /// </summary>
        void Eat();

        /// <summary>
        /// Gives the cry of the animal.
        /// </summary>
        /// <returns>A string representation of the animal's cry.</returns>
        string Cry();
    }
}
