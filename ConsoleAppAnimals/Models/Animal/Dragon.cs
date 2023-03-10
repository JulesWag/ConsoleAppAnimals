using System;
using ConsoleAppAnimals.Service;

namespace ConsoleAppAnimals.Models.Animal
{
    // Ex2b) creer la classe Dragon
    internal class Dragon : Animal, IPilotage
    {
        public Dragon(string name, string type, int id, int age) : base(name, type, id)
        {
            Age = age;
        }

        public int Age { get; set; }

        public override void Move()
        {
            Console.WriteLine($"{Name} is flying and breathing fire!");
        }

        public new void Sleep()
        {
            Console.WriteLine("Don't wake up the dragon!");
        }

        public void Moov()
        {
            Console.WriteLine("The dragon is moving!");
        }
    }
}
