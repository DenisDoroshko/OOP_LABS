using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    /// <summary>
    /// The class representing a bus
    /// </summary>
    
    public class Train: GroundVehicle
    {
        /// <summary>
        /// Creates an instance of the Train class
        /// </summary>
        /// <param name="transportType">Type of transport</param>
        /// <param name="tripNumber">Number of trip</param>
        /// <param name="departure">Departure</param>
        /// <param name="destination">Destination</param>
        /// <param name="prices">Prices of tickets</param>

        public Train(string transportType, int tripNumber, string departure, string destination, int[] prices) : base(transportType, tripNumber, departure, destination, prices)
        {

        }

        /// <summary>
        /// Numbers of free seats of carriages
        /// </summary>
        
        public int[] numbersOfFree= { 20,20,20};


        /// <summary>
        /// Number of free seats
        /// </summary>

        public override int NumberOfFree { get { return GetSum(); }set {} }

        /// <summary>
        /// Indexer that returns the price of a ticket of a given type
        /// </summary>
        /// <param name="ticketType">Type of a ticket</param>
        /// <returns>Price of a ticket</returns>

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

        /// <summary>
        /// Returns information about trip
        /// </summary>
        /// <returns>Trip information</returns>

        public override string GetInfo()
        {
            return $"Type:{TransportType} Trip number:{tripNumber} Departure:{Departure} Destination:{Destination} " +
                $"Prices:{prices[0]} {prices[1]} {prices[2]} {prices[3]} Free seats:{NumberOfFree}";

        }

        /// <summary>
        /// Returns the sum of free seats
        /// </summary>
        /// <returns>The sum of free seats</returns>

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
