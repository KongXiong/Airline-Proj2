using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public class Flight_Dictionary
    {
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
        List<string> portList = new List<string>();
        public List<string> originList =new List<string> { "MKE" };
        public List<string> seatClass = new List<string> { "First Class", "Coach", "Economy" };

        public List<string> giveList()
        {
            foreach(KeyValuePair<string, int> port in dictionary)
            {
                portList.Add(port.Key);
            }
            return portList;
        }
       
    }
}
