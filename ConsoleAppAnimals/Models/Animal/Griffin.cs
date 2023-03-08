using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimals.Models.Animal
{
    //Ex2b) creer classa Griffin
    public class Griffin : Animal
    {

        public override void Move()
        {
            Console.WriteLine("Griffin flies in the air with his bro Harry");
        }

        public new void Sleep()
        {
            Console.WriteLine(" ZZzzz ... ");
        }
    }

}


