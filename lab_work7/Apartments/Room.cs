using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats
{
    public class Room
    {
        public Room(double square, double ceilingHeight, int numberOfWindows, bool furnitureAvailability)
        {
            Square = square;
            CeilingHeight = ceilingHeight;
            NumberOfWindows = numberOfWindows;
            FurnitureAvailability = furnitureAvailability;
        }
        public Room()
        {

        }
        public double Square { get; }
        public double CeilingHeight { get; }
        public double Volume { get { return GetVolume(); } }
        public int NumberOfWindows { get; set; }
        public bool FurnitureAvailability { get; set; }
        protected double GetVolume()
        {
            return Square * CeilingHeight;
        }
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
