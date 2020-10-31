using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats
{
    public class FlatCreator
    {
        public static bool CreateFlat(List<Flat> flats,int numberOfRooms,Room[] rooms,int floor)
        {
            bool isCorrect = true;
            switch (numberOfRooms) 
            {
                case 1:
                    flats.Add(new OneRoomFlat(numberOfRooms, rooms, floor));
                    break;
                case 2:
                    flats.Add(new TwoRoomFlat(numberOfRooms, rooms, floor));
                    break;
                case 3:
                    flats.Add(new ThreeRoomFlat(numberOfRooms, rooms, floor));
                    break;
                case 4:
                    flats.Add(new FourRoomFlat(numberOfRooms, rooms, floor));
                    break;
                case 5:
                    flats.Add(new FiveRoomFlat(numberOfRooms, rooms, floor));
                    break;
                default:
                    isCorrect = false;
                    break;
            }
            return isCorrect;
        }
    }
}
