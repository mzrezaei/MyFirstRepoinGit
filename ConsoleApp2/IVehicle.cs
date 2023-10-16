using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface IVehicle
    {
        void PassangerNUm();
    }
    
    class Car : IVehicle
    {
        public void PassangerNUm()
        {
            Console.WriteLine("Car contanins up to 4 passangers");
        }
    }

    class Van : IVehicle
    {
        public void PassangerNUm()
        {
            Console.WriteLine("Van contanins up to 10 passangers");
        }
    }
    class Bus : IVehicle
    {
        public void PassangerNUm()
        {
            Console.WriteLine("Bus contanins up to 20 passangers");
        }
    }

    
}
