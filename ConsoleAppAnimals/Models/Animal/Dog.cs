using ConsoleAppAnimals.Models.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




    namespace ConsoleAppAnimals.Models.Animal
    {
 

        public class Dog : Animal

        {

        public override void Move()
        {
            Console.WriteLine("Dog is walking");
        }

        private List<string> dogs = new List<string>();

            public Dog()
            {
                dogs.Add("Tic");
                dogs.Add("Tac");
                dogs.Add("Jessie");
                dogs.Add("Snow"); // le chien qui se nomme Snow
                dogs.Add("James");
            }

            public void PrintDogs()
            {
                Console.WriteLine("List of dogs:");
                foreach (string dog in dogs)
                {
                    Console.WriteLine(dog);
                }
            }
        }
    }





