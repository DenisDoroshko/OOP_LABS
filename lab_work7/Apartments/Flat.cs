using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats
{
    /// <summary>
    /// The enumeration representing stove types
    /// </summary>
    public enum StoveTypes
    {
        Gas,
        Electric
    }
    /// <summary>
    /// The abstract class representing a flat
    /// </summary>
    
    public abstract class Flat
    {
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="numberOfRooms">Number of rooms</param>
        /// <param name="rooms">Rooms of the flat</param>
        /// <param name="floor">Floor</param>
        /// <param name="washerAvailability">Washer availability</param>
        /// <param name="stoveType">Type of stove</param>
        
        public Flat(int numberOfRooms,Room[] rooms,int floor,bool washerAvailability,StoveTypes stoveType)
        {
            NumberOfRooms = numberOfRooms;
            Rooms = rooms;
            Floor = floor;
            WasherAvailability = washerAvailability;
            StoveType = stoveType;
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        
        public Flat()
        {

        }

        /// <summary>
        /// Type of a flat
        /// </summary>
        
        public abstract string FlatType { get;}

        /// <summary>
        /// Number of rooms
        /// </summary>
        
        public int NumberOfRooms { get; set; }

        /// <summary>
        /// Floor of the flat
        /// </summary>

        public int Floor { get; set; }

        /// <summary>
        /// The rent of flat
        /// </summary>

        public double FlatRent { get { return GetRent(); } }

        /// <summary>
        /// Rooms of the flat
        /// </summary>
        public Room[] Rooms { get;}

        /// <summary>
        /// Washer availability
        /// </summary>
        
        public bool WasherAvailability { get; set; }

        /// <summary>
        /// Type of stove
        /// </summary>
        
        public StoveTypes StoveType { get; set; }

        /// <summary>
        /// Square of the flat
        /// </summary>
        
        public double Square { get { return GetSquare(); } }

        /// <summary>
        /// Gets rent of the flat
        /// </summary>
        /// <returns>Rent of the flat</returns>
        
        protected abstract double GetRent();

        /// <summary>
        /// Gets square of the flat
        /// </summary>
        /// <returns>Flat square</returns>
        
        protected double GetSquare()
        {
            double square = 0;
            foreach (var room in Rooms)
            {
                square += room.Square;
            }
            return square;
        }
    }
}
