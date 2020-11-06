using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Flats;
using System.Collections.Generic;

namespace FlatTests
{
    [TestClass]
    public class FlatTest
    {
        [TestMethod]
        public void GetRent_OneRoomFlat()
        {
            //Arange
            double expected = 541;
            Room[] rooms = new Room[1] { new Room(70,3,4,true)};
            var flat = new OneRoomFlat(1, rooms, 1, true, StoveTypes.Electric);
            //Act
            double result = flat.FlatRent;
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetRent_TwoRoomFlat()
        {
            //Arange
            double expected = 3261;
            Room[] rooms = new Room[2] { new Room(150, 4, 4, true), new Room(220, 4, 4, true) };
            var flat = new TwoRoomFlat(2, rooms, 20, true, StoveTypes.Electric);
            //Act
            double result = Math.Round(flat.FlatRent);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetRent_ThreeRoomFlat()
        {
            //Arange
            double expected = 611.5;
            Room[] rooms = new Room[3] { new Room(20, 3, 4, true), new Room(30, 3, 4, true) , new Room(35, 3, 4, true) };
            var flat = new ThreeRoomFlat(3, rooms, 4, true, StoveTypes.Electric);
            //Act
            double result = flat.FlatRent;
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SquareOfFourRoomFlat()
        {
            //Arange
            double expected = 146.5;
            Room[] rooms = new Room[4] { new Room(40.5, 3, 4, true), new Room(30.5, 3, 4, true), new Room(25.5, 3, 4, true), new Room(50, 3, 4, true) };
            var flat = new FourRoomFlat(4, rooms, 15, true, StoveTypes.Electric);
            //Act
            double result = flat.Square;
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SquareOfFiveRoomFlat()
        {
            //Arange
            double expected = 131;
            Room[] rooms = new Room[5] { new Room(15.6, 3, 4, false), new Room(23.3, 3, 4, false),
                new Room(30, 3, 4, true), new Room(20.4, 3, 4, true), new Room(41.7, 3, 4, true)};
            var flat = new FiveRoomFlat(5, rooms, 15, true, StoveTypes.Electric);
            //Act
            double result = flat.Square;
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetAverageRent_ThreeRoomFlats()
        {
            //Arange
            double expected = 8.1;
            Room[] firstRooms = new Room[3] { new Room(20, 3, 4, true), new Room(10, 3, 4, true), new Room(15, 3, 4, true)};
            Room[] secondRooms = new Room[3] { new Room(45, 3, 4, true), new Room(35, 3, 4, true), new Room(25, 3, 4, true) };
            List<Flat> threeRoomFlats = new List<Flat>();
            threeRoomFlats.Add(new ThreeRoomFlat(3, firstRooms, 1, true, StoveTypes.Electric));
            threeRoomFlats.Add(new ThreeRoomFlat(3, secondRooms, 5, true, StoveTypes.Electric));
            //Act
            double result = Math.Round(ThreeRoomFlat.GetAverageRent(threeRoomFlats),1);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
