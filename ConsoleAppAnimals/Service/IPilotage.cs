using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimals.Service
{
    internal interface IPilotage
    {
        public interface IPilotage
        {
            void Moov();
        }

        public class Vehicule : IPilotage
        {
            public void Moov()
            {
                Console.WriteLine("Le véhicule se déplace.");
            }

            // autres propriétés et méthodes de la classe Vehicule
        }
    }
}
