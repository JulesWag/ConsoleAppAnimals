using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimals.Models.Animal
{
    //Ex2b) creer la classe Dragon
    internal class Dragon : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Dragon breathes fire");
        }

        public new void Sleep()
        {
            Console.WriteLine(" Dont woke up the Dragon !");
        }
    }
}
