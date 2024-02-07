using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces_and_abstract_classes
{
    //Documentation xml tags found here: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments

    /// <summary>
    /// Defines the various classes that can be created. Currently there are only <c>Cat</c> and <c>Dog</c> classes needed.
    /// </summary>
    public enum Pets { Cat, Dog }

    internal class Program
    {
        /* I am not declaring the namespaces for the other classes, to ensure that
         * they are kept separate, and the program can tell which namespace I am
         * pulling the class from throughout the program
         */
        public static void Main(string[] args)
        {
            //send it off, so I can use non static methods
            ProgramEntry entry = new();
            entry.Run();
        }
    }

    /// <summary>
    /// Provides a class to run the program without the use of static methods.
    /// <para>This allows the program to be separated between different methods,
    /// while keeping proper encapsulation.</para>
    /// </summary>
    public class ProgramEntry
    {
        /// <summary>
        /// Main control of the program
        /// </summary>
        public void Run()
        {
            //********** PART ONE **********\\

            //start by running the abstract classes
            Console.WriteLine("********** ABSTRACT CLASSES **********\n");
            RunAbstract();

            //********** PART TWO **********\\

            Console.WriteLine("\n\n********** INTERFACES **********\n");
            RunInterface();

            Console.WriteLine("\n\n********** LIST **********\n");
            PrintNamesInList();
        }

        /// <summary>
        /// Main controller for the abstract part of the program
        /// 
        /// <para>TASKS:</para>
        /// <list type="number">
        ///     <item>
        ///         <description>Creates an <see cref="Abstract_classes.Dog"/> object.</description>
        ///     </item>
        ///     <item>
        ///         <description>Lists the object's properties.</description>
        ///     </item>
        ///     <item>
        ///         <description>Calls the object's <c>Eat()</c> method.</description>
        ///     </item>
        ///     <item>
        ///         <description>Repeats the above steps for an <see cref="Abstract_classes.Cat"/> object.</description>
        ///     </item>
        /// </list>
        /// </summary>
        private void RunAbstract()
        {
            Console.WriteLine("\n---------- DOG RUN ----------\n");

            //ensure that the reference is not null after the value returns
            Abstract_classes.Animal? dog = GetAnimalAbstract(Pets.Dog);
            dog ??= new Abstract_classes.Dog();

            //next to display the properties
            Console.WriteLine($"Name: {dog.Name}\nColour: {dog.Colour}\nAge: {dog.Age}");

            //lastly, call the eat method.
            dog.Eat();


            Console.WriteLine("\n---------- CAT RUN ----------\n");

            //ensure that the reference is not null after the value returns
            Abstract_classes.Animal? cat = GetAnimalAbstract(Pets.Cat);
            cat ??= new Abstract_classes.Cat();

            //next to display the properties
            Console.WriteLine($"Name: {cat.Name}\nColour: {cat.Colour}\nAge: {cat.Age}");

            //lastly, call the eat method.
            cat.Eat();
        }

        /// <summary>
        /// instantiates either a new <see cref="Abstract_classes.Cat"/> or <see cref="Abstract_classes.Dog"/> object
        /// Depending on the pet provided.
        /// 
        /// <para>TASKS:</para>
        /// <list type="number">
        ///     <item>
        ///         <description>Asks for the name of the pet.</description>
        ///     </item>
        ///     <item>
        ///         <description>Instantiates a new object based on the <paramref name="pet"/> type provided.</description>
        ///     </item>
        /// </list>
        /// </summary>
        /// <param name="pet">The type of pet to instantiate.</param>
        /// <returns>An <see cref="Abstract_classes.Animal"/> reference to the object of the created pet.</returns>
        private Abstract_classes.Animal? GetAnimalAbstract(Pets pet)
        {
            //first thing to do is request a name from the user
            Console.Write($"Please enter a {pet} name: ");
            string? name = GetUserInput();

            //default a new animal
            Abstract_classes.Animal? animal = null;

            //create the specific animal requested
            switch (pet)
            {
                case Pets.Cat:
                    animal = new Abstract_classes.Cat(name, "orange", 2);
                    break;
                case Pets.Dog:
                    animal = new Abstract_classes.Dog(name, "brown", 4);
                    break;
            }

            return animal;
        }

        /// <summary>
        /// Main controller for the interface part of the program
        /// 
        /// <para>TASKS:</para>
        /// <list type="number">
        ///     <item>
        ///         <description>Creates an <see cref="Interfaces.Dog"/> object.</description>
        ///     </item>
        ///     <item>
        ///         <description>Lists the object's properties.</description>
        ///     </item>
        ///     <item>
        ///         <description>Calls the object's <c>Eat()</c> method.</description>
        ///     </item>
        ///     <item>
        ///         <description>Calls the object's <c>Cry()</c> method.</description>
        ///     </item>
        ///     <item>
        ///         <description>Repeats the above steps for an <see cref="Interfaces.Cat"/> object.</description>
        ///     </item>
        /// </list>
        /// </summary>
        private void RunInterface()
        {
            Console.WriteLine("\n---------- DOG RUN ----------\n");

            //ensure that the reference is not null after the value returns
            Interfaces.IAnimal? dog = GetAnimalInterface(Pets.Dog);
            dog ??= new Interfaces.Dog();

            //next to display the properties
            Console.WriteLine($"Name: {dog.Name}\nColour: {dog.Colour}\nHeight: {dog.Height}\nAge: {dog.Age}");

            //lastly, call the eat method.
            dog.Eat();
            dog.Cry();


            Console.WriteLine("\n---------- CAT RUN ----------\n");

            //ensure that the reference is not null after the value returns
            Interfaces.IAnimal? cat = GetAnimalInterface(Pets.Cat);
            cat ??= new Interfaces.Cat();

            //next to display the properties
            Console.WriteLine($"Name: {cat.Name}\nColour: {cat.Colour}\nHeight: {cat.Height}\nAge: {cat.Age}");

            //lastly, call the eat method.
            cat.Eat();
            cat.Cry();
        }

        /// <summary>
        /// instantiates either a new <see cref="Interfaces.Cat"/> or <see cref="Interfaces.Dog"/> object
        /// Depending on the pet provided.
        /// 
        /// <para>TASKS:</para>
        /// <list type="number">
        ///     <item>
        ///         <description>Asks for the name, colour, height and age of the pet.</description>
        ///     </item>
        ///     <item>
        ///         <description>Instantiates a new object based on the <paramref name="pet"/> type provided.</description>
        ///     </item>
        /// </list>
        /// </summary>
        /// <param name="pet">The type of pet to instantiate.</param>
        /// <returns>An <see cref="Interfaces.Animal"/> reference to the object of the created pet.</returns>
        private Interfaces.IAnimal? GetAnimalInterface(Pets pet)
        {
            Console.Write($"Please enter a {pet} name: ");
            string? name = GetUserInput();

            Console.Write($"Please enter the {pet}'s colour: ");
            string? colour = GetUserInput();

            Console.Write($"Please enter the {pet}'s height: ");
            double height = GetUserInput(true);

            Console.Write($"Please enter the {pet}'s age: ");
            int age = (int)GetUserInput(true);


            Interfaces.IAnimal? animal = null;

            switch (pet)
            {
                case Pets.Cat:
                    animal = new Interfaces.Cat(name, colour, height, age);
                    break;
                case Pets.Dog:
                    animal = new Interfaces.Dog(name, colour, height, age);
                    break;
            }

            return animal;
        }

        /// <summary>
        /// Gets the user input, and ensures that the value is not null.
        /// </summary>
        /// <returns>The user inputted string. This will not be null.</returns>
        private string GetUserInput()
        {
            string? userInput = Console.ReadLine();
            userInput ??= "";
            
            return userInput;
        }

        /// <summary>
        /// Gets the user input
        /// </summary>
        /// <param name="isDouble">Determines if the method will return a double or a string.
        /// Defaults to string.</param>
        /// <returns>The user input in the form of a double, or 0, if input was invalid.</returns>
        private double GetUserInput(bool isDouble)
        {
            string? userInputString = Console.ReadLine();
            userInputString ??= "";
            _ = double.TryParse(userInputString, out double parseOutput);

            return parseOutput;
        }

        /// <summary>
        /// Adds a number of <see cref="Interfaces.IAnimal"/> references to a list and prints out
        /// the names and class type of each.
        /// 
        /// <para>TASKS:</para>
        /// <list type="number">
        ///     <item>
        ///         <description>
        ///             Creates a new list, and adds a number of <see cref="Interfaces.IAnimal"/> references,
        ///             Which could either be <see cref="Interfaces.Cat"/> or <see cref="Interfaces.Dog"/> objects
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <description>Loops through the list and prints out the name and type of each object.</description>
        ///     </item>
        /// </list>
        /// </summary>
        private void PrintNamesInList()
        {
            //Filling a new list with some data
            List<Interfaces.IAnimal> animals = new() {
                new Interfaces.Cat("Bob", "Orange", 5.6, 6),
                new Interfaces.Dog("Fox", "grey", 5.2, 4),
                new Interfaces.Cat("Ted", "black", 4.4, 2),
                new Interfaces.Dog("Yogi", "yellow", 6.8, 7)
            };

            //take the list and print out all of the names
            foreach (Interfaces.IAnimal animal in animals)
            {
                //GetType() found from https://stackoverflow.com/questions/11634079/how-can-i-get-the-data-type-of-a-variable-in-c
                Console.WriteLine($"{animal.Name} is a {animal.GetType().Name}");
            }
        }
    }
}
