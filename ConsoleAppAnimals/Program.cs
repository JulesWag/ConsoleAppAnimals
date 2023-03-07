using System;

namespace ConsoleAppAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal("Lion");

            myAnimal.Move(); // Affiche "Move"
            myAnimal.Sleep(); // Affiche "Sleep"

            Console.ReadLine();
        }
    }
}
