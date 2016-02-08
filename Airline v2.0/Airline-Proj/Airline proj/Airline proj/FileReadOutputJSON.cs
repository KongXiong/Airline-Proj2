using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft;
//using Airline_proj;

namespace Airline_proj
{
    public class FileReadOutputJSON
    {
        List<Passenger> passengers = new List<Passenger>();
        public List<Passenger> readFile()
        {
            string json = File.ReadAllText(@"Output.json");
            passengers = JsonConvert.DeserializeObject<List<Passenger>>(json);
            return passengers;
        }
    }
}
