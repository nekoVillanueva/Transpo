using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation;

namespace Transportation_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Truck ford = new Truck();
            Console.WriteLine(ford.GetMph(65));
            
            Car fordCar = new Car();
            Console.WriteLine(fordCar.GetMpg(55, 11));

            Cycle bmw = new Cycle();
            Console.WriteLine(bmw.GetMph(200));


        }
    }
}
