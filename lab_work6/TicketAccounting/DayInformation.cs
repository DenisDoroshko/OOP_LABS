using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketAccounting
{
    public class DayInformation
    {
        public DayInformation(DateTime Date,List<Ticket> Tickets)
        {
            this.Date = Date;
            this.Tickets = Tickets;
        }
        public DayInformation()
        {

        }
        public DateTime Date;
        public List<Ticket> Tickets;
        public int TicketsNumber { get { return Tickets.Count; } }
        public int ParterreNumber { get { return GetParterreNumber(); } }
        public int LoggiaNumber { get { return GetLoggiaNumber(); } }
        public int BalconyNumber { get { return GetBalconyNumber(); } }

        public static void AddTicket(List<DayInformation> days,Ticket ticket)
        {
            bool dayExistense = false;
            foreach(var day in days)
            {
                int location = DateTime.Compare(day.Date, ticket.Date);
                if (location == 0)
                {
                    day.Tickets.Add(ticket);
                    dayExistense = true;
                }      
            }
            if (!dayExistense)
                days.Add(new DayInformation(ticket.Date, new List<Ticket>() { ticket }));
        }
        int GetParterreNumber()
        {
            int number = 0;
            foreach(var ticket in Tickets)
            {
                if (ticket.TicketType == TicketTypes.Parterre)
                    number++;
            }
            return number;
        }
        int GetLoggiaNumber()
        {
            int number = 0;
            foreach (var ticket in Tickets)
            {
                if (ticket.TicketType == TicketTypes.Loggia)
                    number++;
            }
            return number;
        }
        int GetBalconyNumber()
        {
            int number = 0;
            foreach (var ticket in Tickets)
            {
                if (ticket.TicketType == TicketTypes.Balcony)
                    number++;
            }
            return number;
        }
        public static double GetAverage(List<DayInformation> days,TicketTypes type)
        {
            int typeNumber=0;
            foreach(var day in days)
            {
                foreach(var ticket in day.Tickets)
                {
                    if (ticket.TicketType == type)
                        typeNumber++;
                }
            }
            return typeNumber / days.Count;
        }
        public static void SortByDate(List<DayInformation> days)
        {
            for (int i = 0; i < days.Count; i++)
            {
                for (int j = 0; j < days.Count - 1; j++)
                {
                    int location = DateTime.Compare(days[j].Date, days[j + 1].Date);
                    if (location == 1)
                    {
                        DayInformation tempVariable = days[j];
                        days[j] = days[j + 1];
                        days[j + 1] = tempVariable;
                    }
                }
            }
        }


    }
}
