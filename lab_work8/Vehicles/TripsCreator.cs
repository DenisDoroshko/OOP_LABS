using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    /// <summary>
    /// The class for creating trips
    /// </summary>
    
    public class TripsCreator
    {
        /// <summary>
        /// Creates a trip
        /// </summary>
        /// <param name="transportType">Type of transport</param>
        /// <param name="tripNumber">Number of trip</param>
        /// <param name="departure">Departure</param>
        /// <param name="destination">Destination</param>
        /// <param name="prices">Prices of tickets</param>
        /// <returns>Created trip</returns>

        public static ITransport CreateTrip(string transportType, int tripNumber, string departure, string destination, int[] prices)
        {
            ITransport trip = null;
            Dictionary<string, int> transportTypes = new Dictionary<string, int>
            {
                ["plane"] = 1,
                ["bus"] = 2,
                ["train"] = 3,
 
            };
            int key;
            transportType = transportType.Trim().ToLower();
            transportTypes.TryGetValue(transportType, out key);
            switch (key) 
            {
                case 1:
                    trip = new Plane(transportType, tripNumber, departure, destination, prices);
                    break;
                case 2:
                    trip = new Bus(transportType, tripNumber, departure, destination, prices);
                    break;
                case 3:
                    trip = new Train(transportType, tripNumber, departure, destination, prices);
                    break;
            }
            return trip;
        }
    }
}
