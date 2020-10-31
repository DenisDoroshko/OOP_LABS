using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats
{
    class FourRoomFlat : Flat
    {
        public FourRoomFlat(int numberOfRooms, Room[] rooms, int floor) : base(numberOfRooms, rooms, floor)
        {

        }
        protected override double GetRent()
        {
            double result = 0;
            foreach (var room in Rooms)
            {
                result += room.RoomRent;
            }
            result = result * 2.4 + Math.Pow(Floor, -1) * 100;
            return result;
        }
    }
}
