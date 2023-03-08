using ConsoleAppAnimals.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAnimals.Models
{
    internal class Vehicle : IPilotage
    {


        public void Move()
        {
            Console.WriteLine("is flying");
        }
    }
}
