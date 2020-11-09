using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public interface ITransport
    {
        int NumberOfFree { get; set; }
        int TripNumber { get; set; }
        int[] Prices { get; set; }
        string Departure { get; set; }
        string Destination { get; set; }
        string TransportType {get;set;}
        string GetInfo();
        int this[string ticketType]
        {
            get; set;
        }
        
    }
}
