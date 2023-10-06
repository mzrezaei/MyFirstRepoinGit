using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface IMyVehicle
    {
        void PassangerNUm();
    }
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Car : IMyVehicle
    {
        public void PassangerNUm()
        {
            Console.WriteLine("Car contanins up to 4 passangers");
        }
    }

    class Van : IMyVehicle
    {
        public void PassangerNUm()
        {
            Console.WriteLine("Van contanins up to 10 passangers");
        }
    }
    class Bus : IMyVehicle
    {
        public void PassangerNUm()
        {
            Console.WriteLine("Bus contanins up to 20 passangers");
        }
    }

    
}
