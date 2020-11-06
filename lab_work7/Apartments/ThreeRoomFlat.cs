﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats
{
    /// <summary>
    /// The class representing a three-room flat 
    /// </summary>

    public class ThreeRoomFlat : Flat
    {
        /// <summary>
        /// Creates an instance of the ThreeRoomFlat class
        /// </summary>
        /// <param name="numberOfRooms">Number of rooms</param>
        /// <param name="rooms">Rooms of the flat</param>
        /// <param name="floor">Floor</param>
        /// <param name="washerAvailability">Washer availability</param>
        /// <param name="stoveType">Type of stove</param>

        public ThreeRoomFlat(int numberOfRooms, Room[] rooms, int floor, bool washerAvailability,
            StoveTypes stoveType) : base(numberOfRooms, rooms, floor, washerAvailability, stoveType)
        {

        }

        /// <summary>
        /// Type of a flat
        /// </summary>

        public override string FlatType { get { return "Three-room flat"; } }

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
            result = result * 2.3 + Math.Pow(Floor, -1) * 100;
            return Math.Round(result, 1);
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
            return $"Three-room flat; Rent:{Math.Round(FlatRent, 1)}; Floor:{Floor}; Washer:{washer}; Stove type:{StoveType}";
        }
        /// <summary>
        /// Gets average rent for 1 square meter for three-room flats
        /// </summary>
        /// <param name="flats"></param>
        /// <returns>Average rent</returns>
        
        public static double GetAverageRent(List<Flat> flats)
        {
            double sum = 0;
            foreach(var flat in flats)
            {
               
                sum += flat.FlatRent/flat.Square;
            }
            return sum / flats.Count;
        }
    }
}
