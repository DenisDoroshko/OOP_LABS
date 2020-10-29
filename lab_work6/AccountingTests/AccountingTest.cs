using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TicketAccounting;
using UserInterface;

namespace AccountingTests
{
    [TestClass]
    public class AccountingTest
    {
        [TestMethod]
        public void AddTicketOneTicketOnNotEmpyDay()
        {
            //Arange
            int expected = 1;
            List<DayInformation> days = new List<DayInformation>() {new DayInformation(new DateTime(2020, 10, 20),new List<DayInformation.Ticket>() { new DayInformation.Ticket()}) };
            DayInformation.Ticket ticket = new DayInformation.Ticket(TicketTypes.Parterre, new DateTime(2020,10,20));
            //Act
            DayInformation.AddTicket(days, ticket);
            int result = days.Count;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddTicketTwoTicketsOnEmptyDay()
        {
            //Arange
            int expected = 2;
            List<DayInformation> days = new List<DayInformation>() { new DayInformation(new DateTime(2020, 10, 20),
                new List<DayInformation.Ticket>() { new DayInformation.Ticket() }) };
            DayInformation.Ticket fristTicket = new DayInformation.Ticket(TicketTypes.Parterre,
                new DateTime(2020, 10, 22));
            DayInformation.Ticket secondTicket = new DayInformation.Ticket(TicketTypes.Parterre,
                new DateTime(2020, 10, 22));
            //Act
            DayInformation.AddTicket(days, fristTicket);
            DayInformation.AddTicket(days, secondTicket);
            int result = days.Count;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddTicketThreeTicketsOnOneDiffrentDays()
        {
            //Arange
            int expected = 4;
            List<DayInformation> days = new List<DayInformation>() { new DayInformation(new DateTime(2020, 10, 20),
                new List<DayInformation.Ticket>() { new DayInformation.Ticket() }) };
            DayInformation.Ticket firstTicket = new DayInformation.Ticket(TicketTypes.Parterre,
                new DateTime(2020, 10, 21));
            DayInformation.Ticket secondTicket = new DayInformation.Ticket(TicketTypes.Parterre,
                new DateTime(2020, 10, 22));
            DayInformation.Ticket thirdTicket = new DayInformation.Ticket(TicketTypes.Parterre,
                new DateTime(2020, 10, 23));
            //Act
            DayInformation.AddTicket(days, firstTicket);
            DayInformation.AddTicket(days, secondTicket);
            DayInformation.AddTicket(days, thirdTicket);
            int result = days.Count;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetNumberInParterre()
        {
            //Arange
            int expected = 2;
            List<DayInformation> day = new List<DayInformation>();
            DayInformation.Ticket firstTicket = new DayInformation.Ticket(TicketTypes.Parterre,
                new DateTime(2020, 10, 25));
            DayInformation.Ticket secondTicket = new DayInformation.Ticket(TicketTypes.Balcony,
                new DateTime(2020, 10, 25));
            DayInformation.Ticket thirdTicket = new DayInformation.Ticket(TicketTypes.Parterre,
                new DateTime(2020, 10, 25));
            DayInformation.AddTicket(day, firstTicket);
            DayInformation.AddTicket(day, secondTicket);
            DayInformation.AddTicket(day, thirdTicket);
            //Act
            int result = day[0].ParterreNumber;
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetNumberInLoggia()
        {
            //Arange
            int expected = 4;
            List<DayInformation> day = new List<DayInformation>();
            DayInformation.Ticket firstTicket = new DayInformation.Ticket(TicketTypes.Loggia,
                new DateTime(2020, 10, 25));
            DayInformation.Ticket secondTicket = new DayInformation.Ticket(TicketTypes.Loggia,
                new DateTime(2020, 10, 25));
            DayInformation.Ticket thirdTicket = new DayInformation.Ticket(TicketTypes.Balcony,
                new DateTime(2020, 10, 25));
            DayInformation.Ticket fourthTicket = new DayInformation.Ticket(TicketTypes.Loggia,
                new DateTime(2020, 10, 25));
            DayInformation.Ticket fifthTicket = new DayInformation.Ticket(TicketTypes.Loggia,
                new DateTime(2020, 10, 25));
            DayInformation.AddTicket(day, firstTicket);
            DayInformation.AddTicket(day, secondTicket);
            DayInformation.AddTicket(day, thirdTicket);
            DayInformation.AddTicket(day, fourthTicket);
            DayInformation.AddTicket(day, fifthTicket);
            //Act
            int result = day[0].LoggiaNumber;
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetNumberInBalcony()
        {
            //Arange
            int expected = 3;
            List<DayInformation> day = new List<DayInformation>();
            DayInformation.Ticket firstTicket = new DayInformation.Ticket(TicketTypes.Balcony,
                new DateTime(2020, 10, 25));
            DayInformation.Ticket secondTicket = new DayInformation.Ticket(TicketTypes.Balcony,
                new DateTime(2020, 10, 25));
            DayInformation.Ticket thirdTicket = new DayInformation.Ticket(TicketTypes.Balcony,
                new DateTime(2020, 10, 25));
            DayInformation.AddTicket(day, firstTicket);
            DayInformation.AddTicket(day, secondTicket);
            DayInformation.AddTicket(day, thirdTicket);
            //Act
            int result = day[0].BalconyNumber;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetAverageInParterre()
        {
            //Arange
            double expected = 0.667;
            List<DayInformation> days = new List<DayInformation>();
            DayInformation.Ticket firstTicket = new DayInformation.Ticket(TicketTypes.Parterre,
                new DateTime(2020, 10, 24));
            DayInformation.Ticket secondTicket = new DayInformation.Ticket(TicketTypes.Parterre,
                new DateTime(2020, 10, 25));
            DayInformation.Ticket thirdTicket = new DayInformation.Ticket(TicketTypes.Balcony,
                new DateTime(2020, 10, 26));
            DayInformation.AddTicket(days, firstTicket);
            DayInformation.AddTicket(days, secondTicket);
            DayInformation.AddTicket(days, thirdTicket);
            //Act
            double result = Math.Round(DayInformation.GetAverage(days, TicketTypes.Parterre),3);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetAverageInLoggia()
        {
            //Arange
            double expected = 4;
            List<DayInformation> days = new List<DayInformation>();
            DayInformation.Ticket firstTicket = new DayInformation.Ticket(TicketTypes.Loggia,
                new DateTime(2020, 10, 24));
            DayInformation.Ticket secondTicket = new DayInformation.Ticket(TicketTypes.Loggia,
                new DateTime(2020, 10, 24));
            DayInformation.Ticket thirdTicket = new DayInformation.Ticket(TicketTypes.Loggia,
                new DateTime(2020, 10, 24));
            DayInformation.Ticket fourthTicket = new DayInformation.Ticket(TicketTypes.Loggia,
                new DateTime(2020, 10, 24));
            DayInformation.AddTicket(days, firstTicket);
            DayInformation.AddTicket(days, secondTicket);
            DayInformation.AddTicket(days, thirdTicket);
            DayInformation.AddTicket(days, fourthTicket);
            //Act
            double result = DayInformation.GetAverage(days, TicketTypes.Loggia);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetAverageInBalcony()
        {
            //Arange
            double expected = 2;
            List<DayInformation> days = new List<DayInformation>();
            DayInformation.Ticket firstTicket = new DayInformation.Ticket(TicketTypes.Balcony,
                new DateTime(2020, 04, 11));
            DayInformation.Ticket secondTicket = new DayInformation.Ticket(TicketTypes.Balcony,
                new DateTime(2020, 04, 11));
            DayInformation.Ticket thirdTicket = new DayInformation.Ticket(TicketTypes.Balcony,
                new DateTime(2020, 04, 12));
            DayInformation.Ticket fourthTicket = new DayInformation.Ticket(TicketTypes.Balcony,
                new DateTime(2020, 04, 12));
            DayInformation.AddTicket(days, firstTicket);
            DayInformation.AddTicket(days, secondTicket);
            DayInformation.AddTicket(days, thirdTicket);
            DayInformation.AddTicket(days, fourthTicket);
            //Act
            double result = DayInformation.GetAverage(days, TicketTypes.Balcony);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
