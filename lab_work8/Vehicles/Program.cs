using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            ITransport t = TripsCreator.CreateTrip("plane", 123, "Moscow", "Minsk", new int[3] { 123, 140, 150 });
            Console.WriteLine(t.GetInfo());
            Console.ReadLine();
        }
    }
}
