using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class GroundVehicle : ITransport
    {
        public GroundVehicle(string transportType, int tripNumber, string departure, string destination, int[] prices)
        {
            TransportType = transportType;
            this.tripNumber = tripNumber;
            Departure = departure;
            Destination = destination;
            this.prices = prices;
        }
        protected int tripNumber;
        public int TripNumber { get { return tripNumber; } set { tripNumber = value; } }
        public int[] prices;
        public int[] Prices { get { return prices; } set { prices = value; } }
        public abstract int this[string ticketType]
        {
            get; set;
        }
        abstract public int NumberOfFree { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public string TransportType { get; set; }

        public abstract string GetInfo();


    }
}
