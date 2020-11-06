﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats
{
    /// <summary>
    /// The class for creating flats
    /// </summary>
    
    public class FlatCreator
    {
        /// <summary>
        /// Creates and adds a flat to list
        /// </summary>
        /// <param name="flats">Flats</param>
        /// <param name="numberOfRooms">Number of rooms</param>
        /// <param name="rooms">Rooms of a flat</param>
        /// <param name="floor">Floor</param>
        /// <param name="washer">Washer availability</param>
        /// <param name="stove">Type of stove</param>
        /// <returns>List of flats</returns>
        
        public static Flat CreateFlat(int numberOfRooms,Room[] rooms,int floor,bool washer,StoveTypes stove)
        {
            Flat flat = null;
            switch (numberOfRooms) 
            {
                case 1:
                    flat =new OneRoomFlat(numberOfRooms, rooms, floor,washer,stove);
                    break;
                case 2:
                    flat = new TwoRoomFlat(numberOfRooms, rooms, floor, washer, stove);
                    break;
                case 3:
                    flat = new ThreeRoomFlat(numberOfRooms, rooms, floor, washer, stove);
                    break;
                case 4:
                    flat = new FourRoomFlat(numberOfRooms, rooms, floor, washer, stove);
                    break;
                case 5:
                    flat = new FiveRoomFlat(numberOfRooms, rooms, floor, washer, stove);
                    break;
                default:
                    break;
            }
            return flat ;
        }
    }
}
