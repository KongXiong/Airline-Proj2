using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;

namespace Airline_proj
{
    [Serializable]
    public class FileReadPsngrJSON
    {
        public List<Passenger> LoadJson()
        {
            string json = File.ReadAllText("Passengers.json");
            List <Passenger> psgInfo = JsonConvert.DeserializeObject<List<Passenger>>(json);
            if (psgInfo == null)
            {
                psgInfo = new List<Passenger>();
            }
            return psgInfo;
        }

    }
}
