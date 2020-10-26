using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketAccounting
{

    public enum TicketTypes
    {
        Parterre,
        Loggia,
        Balcony
    }
   
    public class Ticket
    {
        public Ticket(TicketTypes TicketType,DateTime Date)
        {
            this.TicketType = TicketType;
            this.Date = Date;
        }
        public Ticket()
        {

        }

        public TicketTypes TicketType;
        public DateTime Date;

    }
}
