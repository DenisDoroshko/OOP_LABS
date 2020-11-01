using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats
{
    public enum StoveTypes
    {
        Gas,
        Electric
    }
    public abstract class Flat
    {
        public Flat(int numberOfRooms,Room[] rooms,int floor,bool washerAvailability,StoveTypes stoveType)
        {
            NumberOfRooms = numberOfRooms;
            Rooms = rooms;
            Floor = floor;
            WasherAvailability = washerAvailability;
            StoveType = stoveType;

        }
        public Flat()
        {

        }
        public int NumberOfRooms { get; set; }
       
        public int Floor { get; set; }
        public double FlatRent { get { return GetRent(); } }
        public Room[] Rooms { get;}
        public bool WasherAvailability { get; set; }
        public StoveTypes StoveType { get; set; }
        public double Square { get { return GetSquare(); } }
        protected abstract double GetRent();
        protected double GetSquare()
        {
            double square=0;
            foreach(var room in Rooms)
            {
                square += room.Square;
            }
            return square;
        }
    }
}
