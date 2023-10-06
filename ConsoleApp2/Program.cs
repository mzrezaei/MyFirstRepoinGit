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
            Car myCar = new Car();  
            Van myVan = new Van();
            Bus myBus = new Bus();

            myCar.PassangerNUm();
            myVan.PassangerNUm();
            myBus.PassangerNUm();
            Console.ReadKey();
        }

        
    }

}
