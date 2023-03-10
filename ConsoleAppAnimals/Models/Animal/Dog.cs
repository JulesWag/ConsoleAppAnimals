using ConsoleAppAnimals.Service;
using System;

namespace ConsoleAppAnimals.Models.Animal
{
    public class Dog : Animal
    {
        public int Age { get; set; }

        public Dog(string name, string type, int id, int age) : base(name, type, id)
        {
            Age = age;
        }

        public Dog(string name) : base(name)
        {
            Age = 0;
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} is running!");
        }
    }
}
