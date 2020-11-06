using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats
{
    /// <summary>
    /// The class representing a room 
    /// </summary>
    
    public class Room
    {
        /// <summary>
        /// Creates an instance of the Room class
        /// </summary>
        /// <param name="square">Square of the Room</param>
        /// <param name="ceilingHeight">Ceiling height</param>
        /// <param name="numberOfWindows">Number of windows</param>
        /// <param name="furnitureAvailability">Furniture availability</param>

        public Room(double square, double ceilingHeight, int numberOfWindows, bool furnitureAvailability)
        {
            Square = square;
            CeilingHeight = ceilingHeight;
            NumberOfWindows = numberOfWindows;
            FurnitureAvailability = furnitureAvailability;
        }

        /// <summary>
        /// Creates an instance of the Room class
        /// </summary>
        
        public Room()
        {

        }

        /// <summary>
        /// Room square
        /// </summary>
        
        public double Square { get; }

        /// <summary>
        /// Ceiling height
        /// </summary>
        
        public double CeilingHeight { get; }

        /// <summary>
        /// Room volume
        /// </summary>
        
        public double Volume { get { return GetVolume(); } }

        /// <summary>
        /// Number of windows
        /// </summary>
        
        public int NumberOfWindows { get; set; }

        /// <summary>
        /// Furniture availability
        /// </summary>
        
        public bool FurnitureAvailability { get; set; }

        /// <summary>
        /// Gets volume of the room
        /// </summary>
        /// <returns>Volume of the room</returns>
        
        protected double GetVolume()
        {
            return Square * CeilingHeight;
        }

        /// <summary>
        /// Converts class to string
        /// </summary>
        /// <returns>String representation of a class</returns>
        
        public override string ToString()
        {
            string furniture;
            if (FurnitureAvailability == true)
                furniture = "Yes";
            else
                furniture = "No";
            return $"Square:{Square}; Height:{CeilingHeight}; Volume:{Volume} Windows number:{NumberOfWindows}" +
                $" Furniture:{furniture}";
        }

    }
}
