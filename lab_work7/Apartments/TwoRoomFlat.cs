using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats
{
    class TwoRoomFlat : Flat
    {
        public TwoRoomFlat(int numberOfRooms, Room[] rooms, int floor) : base(numberOfRooms, rooms, floor)
        {

        }
        protected override double GetRent()
        {
            double result = 0;
            foreach (var room in Rooms)
            {
                result += room.RoomRent;
            }
            result = result * 2.2 + Math.Pow(Floor, -1) * 100;
            return result;
        }
    }
}
