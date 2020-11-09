using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Bus:GroundVehicle
    {
        public Bus(string transportType, int tripNumber, string departure, string destination, int[] prices):base(transportType,tripNumber, departure, destination, prices)
        {
        }
        private int numberOfFree=30;
        public override int NumberOfFree { get { return numberOfFree; } set { numberOfFree = value; } }
        public override int this[string ticketType]
        {
            get
            {
                switch (ticketType)
                {
                    case "hard": return prices[0];
                    case "soft": return prices[1];
                    default: return 0;
                }
            }
            set
            {
                switch (ticketType)
                {
                    case "hard":
                        prices[0] = value;
                        break;
                    case "soft":
                        prices[1] = value;
                        break;
                }
            }
        }
        public override string GetInfo()
        {
            return $"Type:{TransportType} Trip number:{tripNumber} Departure:{Departure} Destination:{Destination} " +
                $"Prices:{prices[0]} {prices[1]} Free seats:{NumberOfFree}";
        }
    }
}
