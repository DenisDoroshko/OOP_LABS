using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats
{
    /// <summary>
    /// The class representing a four-room flat 
    /// </summary>

    public class FourRoomFlat : Flat
    {
        /// <summary>
        /// Creates an instance of the FourRoomFlat class
        /// </summary>
        /// <param name="numberOfRooms">Number of rooms</param>
        /// <param name="rooms">Rooms of the flat</param>
        /// <param name="floor">Floor</param>
        /// <param name="washerAvailability">Washer availability</param>
        /// <param name="stoveType">Type of stove</param>

        public FourRoomFlat(int numberOfRooms, Room[] rooms, int floor, bool washerAvailability,
            StoveTypes stoveType) : base(numberOfRooms, rooms, floor, washerAvailability, stoveType)
        {

        }

        /// <summary>
        /// Gets rent of the flat
        /// </summary>
        /// <returns>Rent of the flat</returns>

        protected override double GetRent()
        {
            double result = 0;
            foreach (var room in Rooms)
            {
                result += room.Volume;
            }
            result = result * 2.4 + Math.Pow(Floor, -1) * 100;
            return result;
        }

        /// <summary>
        /// Converts class to string
        /// </summary>
        /// <returns>String representation of a class</returns>

        public override string ToString()
        {
            string washer;
            if (WasherAvailability == true)
                washer = "Yes";
            else
                washer = "No";
            return $"Four-room flat; Rent:{Math.Round(FlatRent, 1)}; Floor:{Floor}; Washer:{washer}; Stove type:{StoveType}";
        }
    }
}
