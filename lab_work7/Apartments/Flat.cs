using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats
{

    public abstract class Flat
    {
        public Flat(int numberOfRooms,Room[] rooms,int floor)
        {
            NumberOfRooms = numberOfRooms;
            Rooms = rooms;
            Floor = floor;
        }
        public Flat()
        {

        }
        public int NumberOfRooms { get; set; }
       
        public int Floor { get; set; }
        public double FlatRent { get { return GetRent(); } }
        public Room[] Rooms { get;}
        protected abstract double GetRent();
    }
}
