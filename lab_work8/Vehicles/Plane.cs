using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    /// <summary>
    /// The class representing a plane
    /// </summary>
    public class Plane:ITransport
    {
        /// <summary>
        /// Creates an instance of the Plane class
        /// </summary>
        /// <param name="transportType">Type of transport</param>
        /// <param name="tripNumber">Number of trip</param>
        /// <param name="departure">Departure</param>
        /// <param name="destination">Destination</param>
        /// <param name="prices">Prices of tickets</param>
        
        public Plane(string transportType,int tripNumber, string departure,string destination,int[] prices)
        {
            TransportType = transportType;
            this.tripNumber = tripNumber;
            Departure = departure;
            Destination = destination;
            this.prices = prices;
        }

        /// <summary>
        /// Number of a trip
        /// </summary>
        
        protected int tripNumber;

        /// <summary>
        /// Number of a trip
        /// </summary>
        
        public int TripNumber { get { return tripNumber; } set { tripNumber = value; } }

        /// <summary>
        /// Prices of tickets
        /// </summary>
        
        public int[] prices;

        /// <summary>
        /// Prices of tickets
        /// </summary>

        public int[] Prices { get { return prices; } set { prices = value; } }

        /// <summary>
        /// Indexer that returns the price of a ticket of a given type
        /// </summary>
        /// <param name="ticketType">Type of a ticket</param>
        /// <returns>Price of a ticket</returns>
        
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

        /// <summary>
        /// Number of free seats
        /// </summary>

        public int NumberOfFree { get; set; } = 100;

        /// <summary>
        /// Point of depatrure
        /// </summary>

        public string Departure { get; set; }

        /// <summary>
        /// Point of destination
        /// </summary>

        public string Destination { get; set; }

        /// <summary>
        /// Type of a transport
        /// </summary>

        public string TransportType { get; set; }

        /// <summary>
        /// Returns information about trip
        /// </summary>
        /// <returns>Trip information</returns>

        public string GetInfo() 
        {
            return $"Type:{TransportType} Trip number:{tripNumber} Departure:{Departure} Destination:{Destination} " +
                $"Prices:{prices[0]} {prices[1]} {prices[2]} Free seats:{NumberOfFree}"; 
        }
    }
}
