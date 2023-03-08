using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimals.Models.Animal
{
    //EX2a) mettre en abstract
    public abstract class Animal
    {
        public string Name {  get;  private set; }

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
        //EX3a) Overide de la méthode Move et ajout de new pour Sleep
        public abstract void Move();

        public new void Sleep()
        {
            Console.WriteLine("ZZZ..zzz");
        }
    }




}

