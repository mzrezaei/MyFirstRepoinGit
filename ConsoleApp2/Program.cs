using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp2.Program;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car objCar = new Car();
            Van objVan = new Van();
            Bus objBus = new Bus();
            Truck objTruck= new Truck();

            objCar.PassangerNUm();
            objVan.PassangerNUm();
            objBus.PassangerNUm();
            objTruck.vehicleFuel();
            objTruck.vehicleWheels();
            Console.ReadKey();
        }
         
    }
    
    
}
