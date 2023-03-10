using ConsoleAppAnimals.Models.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>
            {
                new Dog("Snow"),
                new Dog("Tic"),
                new Dog("Tac"),
                new Dog("Jessie"),
                new Dog("James"),
            };

            Dog dog = new Dog("Loup", "Epic", 10, 99);
            Dragon enderDragon = new Dragon("Ender Dragon", "Legendary", 99, 10);
            Griffin griffin = new Griffin("GriffonDort", "Rare", 5, 10);
            Dragon ptera = new Dragon("Ptera", "Commun", 1, 25);
            Dog wolf = new Dog("Wolf", "Commun", 2, 685);
            Dog ben = new Dog("Ben", "Commun", 20, 65);

            List<Animal> liste = new List<Animal> { dog, enderDragon, griffin, ptera, wolf, ben };
            var result = liste.OrderBy(a => a.Type).ThenByDescending(a => a.Age);

            Console.WriteLine("List of all animals from the rarest to the least rare with their age:");
            foreach (var animal in result)
            {
                Console.WriteLine($"Type: {animal.Type}, Name: {animal.Name}, Age: {animal.Age}");
            }

            Console.ReadLine();
        }
    }
}
