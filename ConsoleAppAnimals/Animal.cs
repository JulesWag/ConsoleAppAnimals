using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimals
{
    public class Animal
    {
        private string Name;

        public Animal()
        {
            // Constructeur par défaut
            Name = "Unnamed Animal";
        }

        public Animal(string name)
        {
            // Constructeur avec le nom en paramètre
            Name = name;
        }

        public void Move()
        {
            Console.WriteLine("Move");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }
    }

  


}

