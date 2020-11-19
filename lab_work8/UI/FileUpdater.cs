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
        public static List<ITransport> GetTrips(string path)
        {
            List<ITransport> trips = new List<ITransport>();
            int addedNumber = 0;
            List<string> data = GetData(path);
            foreach (var stringTrip in data)
            {
                string[] tripValues = stringTrip.Split();
                string type = tripValues[0];
                int tripNumber;
                int.TryParse(tripValues[1], out tripNumber);
                string departure = tripValues[2];
                string destination = tripValues[3];
                List<string> stringPrices = new List<string>();
                for (var i = 4; i < tripValues.Length; i++)
                {
                    stringPrices.Add(tripValues[i]);
                }
                int[] prices = ParsePrices(stringPrices);
                ITransport trip = TripsCreator.CreateTrip(type, tripNumber, departure, destination, prices);
                if (trip != null)
                {
                    trips.Add(trip);
                    addedNumber++;
                }
            }
            return trips;
        }
        /// <summary>
        /// Gets data
        /// </summary>
        /// <returns>Data</returns>

        private static List<string> GetData(string path)
        {
            List<string> data = new List<string>();
            using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    data.Add(sr.ReadLine());
                }
            }
            return data;
        }

        /// <summary>
        /// Gets prices of tickets
        /// </summary>
        /// <param name="values"></param>
        /// <returns>Prices of tickets</returns>

        static int[] ParsePrices(List<string> values)
        {
            List<int> pricesList = new List<int>();
            int numberOfPrices = 0;
            foreach (string value in values)
            {
                int price;
                if (int.TryParse(value, out price))
                {
                    pricesList.Add(price);
                    numberOfPrices++;
                }
            }
            int[] points = new int[numberOfPrices];
            pricesList.CopyTo(points);
            return points;
        }

        public static void UpdateFile(List<ITransport> trips,string path)
        {
            using (var sw = new StreamWriter(path))
            {
                foreach (var trip in trips)
                {
                    sw.WriteLine(trip.GetInfo());
                }
                
            }
        }
    }
}
