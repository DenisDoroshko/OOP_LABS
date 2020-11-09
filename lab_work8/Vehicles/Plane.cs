using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Plane:ITransport
    {
        public Plane(string transportType,int tripNumber, string departure,string destination,int[] prices)
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
        public int this[string ticketType]
        {
            get
            {
                switch (ticketType)
                {
                    case "economy": return prices[0];
                    case "business": return prices[1];
                    case "first": return prices[2];
                    default: return 0;
                }
            }
            set
            {
                switch (ticketType)
                {
                    case "economy":
                        prices[0] = value;
                        break;
                    case "business":
                        prices[1] = value;
                        break;
                    case "first":
                        prices[2] = value;
                        break;
                }
            }
        }
        public int NumberOfFree { get; set; } = 100;
        public string Departure { get; set; }
        public string Destination { get; set; }
        public string TransportType { get; set; }

        public string GetInfo() 
        {
            return $"Type:{TransportType} Trip number:{tripNumber} Departure:{Departure} Destination:{Destination} " +
                $"Prices:{prices[0]} {prices[1]} {prices[2]} Free seats:{NumberOfFree}"; 
        }
    }
}
