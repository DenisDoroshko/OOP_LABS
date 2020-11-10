using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicles;

namespace TripsTests
{
    [TestClass]
    public class TripTest
    {
        [TestMethod]
        public void PlaneGetPriceByTicketType()
        {
            //Arange
            int expected = 101;
            Plane plane = new Plane("plane", 123, "Minsk", "Moscow", new int[3] { 101, 120, 150 });
            //Act
            int result = plane["economy"];
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void BusGetPriceByTicketType()
        {
            //Arange
            int expected = 18;
            Bus bus = new Bus("bus", 123, "Minsk", "Brest", new int[2] { 15, 18});
            //Act
            int result = bus["soft"];
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TrainGetPriceByTicketType()
        {
            //Arange
            int expected = 64;
            Train train = new Train("train", 123, "Minsk", "Gomel", new int[4] { 25, 30,40,64 });
            //Act
            int result = train["luxury"];
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void PlaneGetInfo()
        {
            //Arange
            string expected = "Type:plane Trip number:123 Departure:Minsk Destination:Berlin Prices:50 84 100 Free seats:100";
            Plane plane = new Plane("plane", 123, "Minsk", "Berlin", new int[3] { 50, 84, 100 });
            //Act
            string result = plane.GetInfo();
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TrainGetNumberOfFree()
        {
            //Arange
            int expected = 65;
            Train train = new Train("train", 123, "Minsk", "Gomel", new int[4] { 25, 30, 40, 64 });
            train.numbersOfFree = new int[4] { 17, 13, 15, 20 };
            //Act
            int result = train.NumberOfFree;
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
