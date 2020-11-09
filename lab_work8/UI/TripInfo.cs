using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class TripInfo
    {
        public TripInfo(string transportType, int tripNumber, string departure, string destination, int numberOfFree, int[] prices)
        {
            TransportType = transportType;
            TripNumber = tripNumber;
            Departure = departure;
            Destination = destination;
            NumberOfFree = numberOfFree;
            foreach (var price in prices)
                Prices += price + " ";
        }
        public string TransportType { get; set; }
        public int TripNumber { get; set; }

        public string Departure { get; set; }
        public string Destination { get; set; }
        public string Prices { get; set; }
        public int NumberOfFree { get; set; }
    }
}
