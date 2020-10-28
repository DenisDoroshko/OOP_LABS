using System;
using System.Collections.Generic;

namespace TicketAccounting
{
    /// <summary>
    /// Class storing day information
    /// </summary>
    
    public class DayInformation
    {
        /// <summary>
        /// Creates an instance of the DayInformation class
        /// </summary>
        /// <param name="Date">Date</param>
        /// <param name="Tickets">List of tickets</param>

        public DayInformation(DateTime Date,List<Ticket> Tickets)
        {
            this.Date = Date;
            this.Tickets = Tickets;
        }

        /// <summary>
        /// Creates an instance of the DayInformation class
        /// </summary>
        
        public DayInformation()
        {

        }

        /// <summary>
        /// Date
        /// </summary>
        /// 
        public DateTime Date;

        /// <summary>
        /// List of tickets
        /// </summary>
        
        public List<Ticket> Tickets;

        /// <summary>
        /// Number of tickets sold on that day
        /// </summary>
        
        public int TicketsNumber { get { return Tickets.Count; } }

        /// <summary>
        /// Number of tickets sold on that day to the parterre
        /// </summary>
        
        public int ParterreNumber { get { return GetNumber(TicketTypes.Parterre); } }

        /// <summary>
        /// Number of tickets sold on that day to the loggia
        /// </summary>
        
        public int LoggiaNumber { get { return GetNumber(TicketTypes.Loggia); } }

        /// <summary>
        /// Number of tickets sold on that day to the balcony
        /// </summary>
        
        public int BalconyNumber { get { return GetNumber(TicketTypes.Balcony); } }

        /// <summary>
        /// Adds the ticket to the list of days
        /// </summary>
        /// <param name="days">List of days</param>
        /// <param name="ticket">Ticket</param>

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
        /// <summary>
        /// Gets the number of tickets of the given type
        /// </summary>
        /// <param name="type">Ticket type</param>
        /// <returns>The number of tickets of the given type</returns>
        
        int GetNumber(TicketTypes type)
        {
            int number = 0;
            foreach(var ticket in Tickets)
            {
                if (ticket.TicketType == type)
                    number++;
            }
            return number;
        }

        /// <summary>
        /// Gets the average number of tickets of the given type
        /// </summary>
        /// <param name="days">Days</param>
        /// <param name="type">Ticket type</param>
        /// <returns>The average number of tickets of the given type</returns>
        
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
    }
}
