using System;

namespace ConsoleAppAnimals.Models.Animal
{
    //Ex2b) creer classe Griffin
    public class Griffin : Animal
    {
        public Griffin(string name, string type, int id, int age) : base(name, type, id)
        {
            this.Age = age;
        }

        public int Age { get; set; }

        public override void Move()
        {
            Console.WriteLine("Griffin flies in the air with his bro Harry");
        }

        public new void Sleep()
        {
            Console.WriteLine("ZZzzz...");
        }
    }
}
