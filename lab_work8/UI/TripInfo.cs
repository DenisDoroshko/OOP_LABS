using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    /// <summary>
    /// The class representing a information about trip
    /// </summary>
    public class TripInfo
    {
        /// <summary>
        /// Creates an instance of the TripInfo class
        /// </summary>
        /// <param name="transportType">Type of a transport</param>
        /// <param name="tripNumber">Number of a trip</param>
        /// <param name="departure">Departure</param>
        /// <param name="destination">Destination</param>
        /// <param name="numberOfFree">Number of free seats</param>
        /// <param name="prices">Prices</param>
        
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

        /// <summary>
        /// Type of a transport
        /// </summary>
        
        public string TransportType { get; set; }

        /// <summary>
        /// Number of a trip
        /// </summary>
        
        public int TripNumber { get; set; }

        /// <summary>
        /// Departure
        /// </summary>
        
        public string Departure { get; set; }

        /// <summary>
        /// Destination
        /// </summary>
        
        public string Destination { get; set; }

        /// <summary>
        /// Prices
        /// </summary>
        
        public string Prices { get; set; }

        /// <summary>
        /// Number of free seats
        /// </summary>
        
        public int NumberOfFree { get; set; }
    }
}
