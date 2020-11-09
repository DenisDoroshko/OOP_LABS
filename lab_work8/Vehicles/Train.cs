using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Train: GroundVehicle
    {
        public Train(string transportType, int tripNumber, string departure, string destination, int[] prices) : base(transportType, tripNumber, departure, destination, prices)
        {

        }
        public int[] numbersOfFree= { 20,20,20};
        public override int NumberOfFree { get { return GetSum(); }set {} }
        public override int this[string ticketType]
        {
            get
            {
                switch (ticketType)
                {
                    case "common": return prices[0];
                    case "economy": return prices[1];
                    case "compartment": return prices[2];
                    case "luxury": return prices[3];
                    default: return 0;
                }
            }
            set
            {
                switch (ticketType)
                {
                    case "common":
                        prices[0] = value;
                        break;
                    case "economy":
                        prices[1] = value;
                        break;
                    case "compartment":
                        prices[1] = value;
                        break;
                    case "luxury":
                        prices[1] = value;
                        break;
                }
            }
        }
        public override string GetInfo()
        {
            return $"Type:{TransportType} Trip number:{tripNumber} Departure:{Departure} Destination:{Destination} " +
                $"Prices:{prices[0]} {prices[1]} {prices[2]} {prices[3]} Free seats:{NumberOfFree}";

        }
        private int GetSum()
        {
            int sum = 0;
            foreach(var carriage in numbersOfFree)
            {
                sum += carriage;
            }
            return sum;
        }
    }
}
