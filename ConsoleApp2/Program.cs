using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp2.Program;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Passengers();
            Console.ReadKey();
        }
        static void Passengers()
        {
            Console.WriteLine("Please type one of these Itmes: Car, Van, Bus");
            string CarType = Console.ReadLine().ToLower();
             if (CarType == "car")
                Console.WriteLine("Passangers number is 4");
            else if (CarType == "van" )
                Console.WriteLine("Passangers number is 10");
            else if (CarType == "bus")
                Console.WriteLine("Passangers number is 20");
            else
                Console.WriteLine("Please type correct car name");
            
        }
        
                
    }

}
