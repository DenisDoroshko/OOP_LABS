using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats
{
    public class OneRoomFlat : Flat
    {
        public OneRoomFlat(int numberOfRooms, Room[] rooms, int floor, bool washerAvailability,
            StoveTypes stoveType) : base(numberOfRooms, rooms, floor, washerAvailability, stoveType)
        {

        }
        protected override double GetRent()
        {
            double result = 0;
            foreach (var room in Rooms)
            {
                result += room.RoomRent;
            }
            result = result * 2.1 + Math.Pow(Floor, -1)*100;
            return result;
        }
        public override string ToString()
        {
            string washer;
            if (WasherAvailability == true)
                washer = "Yes";
            else
                washer = "No";
            return $"One-room flat; Rent:{Math.Round(FlatRent, 1)}; Floor:{Floor}; Washer:{washer}; Stove type:{StoveType}";
        }
    }
}
