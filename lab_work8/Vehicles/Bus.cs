using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    /// <summary>
    /// The class representing a bus
    /// </summary>
    
    public class Bus:GroundVehicle
    {
        /// <summary>
        /// Creates an instance of the Bus class
        /// </summary>
        /// <param name="transportType">Type of transport</param>
        /// <param name="tripNumber">Number of trip</param>
        /// <param name="departure">Departure</param>
        /// <param name="destination">Destination</param>
        /// <param name="prices">Prices of tickets</param>
        
        public Bus(string transportType, int tripNumber, string departure, string destination, int[] prices):base(transportType,tripNumber, departure, destination, prices)
        {
        }

        /// <summary>
        /// Number of free seats
        /// </summary>
        
        private int numberOfFree=30;

        /// <summary>
        /// Number of free seats
        /// </summary>
        
        public override int NumberOfFree { get { return numberOfFree; } set { numberOfFree = value; } }

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

        /// <summary>
        /// Returns information about trip
        /// </summary>
        /// <returns>Trip information</returns>
        
        public override string GetInfo()
        {
            return $"{TransportType} {tripNumber} {Departure} {Destination} " +
                $"{prices[0]} {prices[1]}";
        }
    }
}
