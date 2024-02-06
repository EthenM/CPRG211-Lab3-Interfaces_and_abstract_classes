using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Interfaces_and_abstract_classes
{
    public enum Pets { Cat, Dog }

    internal class Program
    {
        //don't declare the namespace, that way the program and the developer will know which part of the project is with which type
        public static void Main(string[] args)
        {
            //send it off, so I can use non static methods
            ProgramEntry entry = new();
            entry.Run();
        }
    }

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
        ///         <description>Creates an <see cref="Abstract_classes.Dog"/> object</description>
        ///     </item>
        ///     <item>
        ///         <description>Lists its properties</description>
        ///     </item>
        ///     <item>
        ///         <description>Repeats the above steps for an <see cref="Abstract_classes.Cat"/> object</description>
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

        private string GetUserInput()
        {
            string? userInput = Console.ReadLine();
            userInput ??= "";
            
            return userInput;
        }

        private double GetUserInput(bool isDouble)
        {
            string? userInputString = Console.ReadLine();
            userInputString ??= "";
            _ = double.TryParse(userInputString, out double parseOutput);

            return parseOutput;
        }

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
