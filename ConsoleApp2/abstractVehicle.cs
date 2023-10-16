using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class abstractVehicle
    {
        public abstract void vehicleWheels();
        public void vehicleFuel()
        {
            Console.WriteLine("Vehicle needs fuel.");
        }
    }
    class Truck : abstractVehicle
    {
        public override void vehicleWheels()
        {
            Console.WriteLine("Truck has up to 18 wheels.");
        }
    } 
}
