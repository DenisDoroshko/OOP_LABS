using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    /// <summary>
    /// The abstract class representing a ground vehicle
    /// </summary>
    
    public abstract class GroundVehicle : ITransport
    {
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="transportType">Type of transport</param>
        /// <param name="tripNumber">Number of trip</param>
        /// <param name="departure">Departure</param>
        /// <param name="destination">Destination</param>
        /// <param name="prices">Prices of tickets</param>
        
        public GroundVehicle(TransportTypes transportType, int tripNumber, string departure, string destination, int[] prices)
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
        
        public abstract int this[string ticketType]
        {
            get; set;
        }

        /// <summary>
        /// Number of free seats
        /// </summary>
        
        abstract public int NumberOfFree { get; set; }

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
        
        public TransportTypes TransportType { get; set; }

        /// <summary>
        /// Returns information about trip
        /// </summary>
        /// <returns>Trip information</returns>

        public abstract string GetInfo();


    }
}
