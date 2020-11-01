using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats
{
    public class ThreeRoomFlat : Flat
    {
        public ThreeRoomFlat(int numberOfRooms, Room[] rooms, int floor, bool washerAvailability,
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
            result = result * 2.3 + Math.Pow(Floor, -1) * 100;
            return result;
        }
        public override string ToString()
        {
            string washer;
            if (WasherAvailability == true)
                washer = "Yes";
            else
                washer = "No";
            return $"Three-room flat; Rent:{Math.Round(FlatRent, 1)}; Floor:{Floor}; Washer:{washer}; Stove type:{StoveType}";
        }
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
