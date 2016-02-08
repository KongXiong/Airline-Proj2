using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_proj
{
    class Flight
    {

        //aircraft assigned to flight
        //int flightNum;
        //string origin = "MKE";
        public string Destination;
        Dictionary<string, int> dictionary = new Dictionary<string, int>()
            {
                {"ATL", 670},
                {"ORD", 67},
                {"LAX", 1750},
                {"DFW", 853},
                {"DEN", 893},
                {"JFK", 743},
                {"SFO", 1840},
                {"CLT", 651},
                {"LAS", 1520},
                {"PHX", 1460},
                {"IAH", 985},
                {"MIA", 1260},
                {"MCO", 1070},
                {"EWR", 722},
                {"SEA", 1690},
                {"MSP", 296},
                {"DTW", 237},
                {"PHL", 688},
                {"BOS", 857},
                {"LGA", 736}
            };
        public int TravelDist
        {
            get
            {
                int value = 0;
                dictionary.TryGetValue(Destination, out value);
                return value;
            }
            set { }
        }

        public Flight(string destination)
        {
            this.Destination = destination;
        }
        //public void flightRange()
        //{
        //    dictionary = new Dictionary<string, int>()
        //    {
        //        {"ATL", 670},
        //        {"ORD", 67},
        //        {"LAX", 1750},
        //        {"DFW", 853},
        //        {"DEN", 893},
        //        {"JFK", 743},
        //        {"SFO", 1840},
        //        {"CLT", 651},
        //        {"LAS", 1520},
        //        {"PHX", 1460},
        //        {"IAH", 985},
        //        {"MIA", 1260},
        //        {"MCO", 1070},
        //        {"EWR", 722},
        //        {"SEA", 1690},
        //        {"MSP", 296},
        //        {"DTW", 237},
        //        {"PHL", 688},
        //        {"BOS", 857},
        //        {"LGA", 736}
        //    };
        //    foreach (KeyValuePair<string, int> port in dictionary)
        //    {
        //        Console.WriteLine("{0} - {1}", port.Key, port.Value);
        //    }
        //}
        //passenger manifest
    }
}
