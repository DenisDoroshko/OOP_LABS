using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    /// <summary>
    /// Contains transport types
    /// </summary>
    
    public enum TransportTypes 
    {
        Plane=1,      
        Bus=2, 
        Train=3
    }

    /// <summary>
    /// Interface for implementing transport classes
    /// </summary>
    
    public interface ITransport
    {
        /// <summary>
        /// Number of free seats
        /// </summary>
        
        int NumberOfFree { get; set; }

        /// <summary>
        /// Number of trip
        /// </summary>
        
        int TripNumber { get; set; }

        /// <summary>
        /// Prices of tickets
        /// </summary>
        
        int[] Prices { get; set; }

        /// <summary>
        /// Point of departure
        /// </summary>
        
        string Departure { get; set; }
        /// <summary>
        /// Point of destination
        /// </summary>
        
        string Destination { get; set; }

        /// <summary>
        /// Type of a transport
        /// </summary>

        TransportTypes TransportType {get;set;}

        /// <summary>
        /// Returns information about trip
        /// </summary>
        /// <returns>Trip information</returns>

        string GetInfo();

        /// <summary>
        /// Indexer that returns the price of a ticket of a given type
        /// </summary>
        /// <param name="ticketType">Type of a ticket</param>
        /// <returns>Price of a ticket</returns>

        int this[string ticketType]
        {
            get; set;
        }
        
    }
}
