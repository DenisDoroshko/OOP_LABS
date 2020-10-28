using System;

namespace TicketAccounting
{
    /// <summary>
    /// The enumeration representing ticket types
    /// </summary>
    
    public enum TicketTypes
    {
        Parterre,
        Loggia,
        Balcony
    }
   
    /// <summary>
    /// Class storing ticket data
    /// </summary>
    
    public class Ticket
    {
        /// <summary>
        /// Creates an instance of the Ticket class
        /// </summary>
        /// <param name="TicketType">Ticket type</param>
        /// <param name="Date">Ticket date</param>
        public Ticket(TicketTypes TicketType,DateTime Date)
        {
            this.TicketType = TicketType;
            this.Date = Date;
        }

        /// <summary>
        /// Creates an instance of the Ticket class
        /// </summary>
        
        public Ticket()
        {

        }

        /// <summary>
        /// Ticket type
        /// </summary>
        /// 
        public TicketTypes TicketType;

        /// <summary>
        /// Ticket date
        /// </summary>
        
        public DateTime Date;

    }
}
