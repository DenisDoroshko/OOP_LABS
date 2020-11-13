using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;
using System.IO;

namespace UI
{
    public class FileUpdater
    {
        public static void UpdateFile(List<ITransport> trips)
        {
            using (var sw = new StreamWriter("trips.txt"))
            {
                foreach (var trip in trips)
                {
                    sw.WriteLine(trip.GetInfo());
                }
                
            }
        }
    }
}
