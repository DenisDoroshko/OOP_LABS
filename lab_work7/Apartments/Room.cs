using System;
using System.Collections.Generic;
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
    public class Room
    {
        public Room(double square, double ceilingHeight, int numberOfWindows, bool furnitureAvailability, bool washerAvailability, StoveTypes stoveType)
        {
            Square = square;
            CeilingHeight = ceilingHeight;
            NumberOfWindows = numberOfWindows;
            FurnitureAvailability = furnitureAvailability;
            WasherAvailability = washerAvailability;
            StoveType = stoveType;
        }
        public Room()
        {

        }
        public double Square { get; }
        public double CeilingHeight { get; }
        public double Volume { get { return GetVolume(); } }
        public int NumberOfWindows { get; set; }
        public bool FurnitureAvailability { get; set; }
        public bool WasherAvailability { get; set; }
        public StoveTypes StoveType { get; set; }
        public double RoomRent { get { return GetRent(); } }
        protected double GetVolume()
        {
            return Square * CeilingHeight;
        }
        protected double GetRent()
        {
            return Volume;
        }

    }
}
