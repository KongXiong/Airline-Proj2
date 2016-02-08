using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace Airline_proj
{
    [Serializable]
    public class FileWriter
    {
        public void Jwriter(string fullName, string travelDate, string seatNumber, string destination, string origin)
        {
            List<Passenger> psngrData = new List<Passenger>();
            Passenger passenger = new Passenger(fullName, travelDate, seatNumber, destination, origin);
            psngrData.Add(passenger);

            string readFile = File.ReadAllText("Passengers.json");
            List<Passenger> fileReadList = JsonConvert.DeserializeObject<List<Passenger>>(readFile);
            psngrData.AddRange(fileReadList);

            string json = JsonConvert.SerializeObject(psngrData, Formatting.Indented);
            File.WriteAllText("Passengers.json", json);

        }
        public void PsgInfo()
        {
            List<Passenger> passengerData = new List<Passenger>();

            FileReadPsngrJSON FR = new FileReadPsngrJSON();
            List<Passenger> fileReadList = FR.LoadJson();
            passengerData.AddRange(fileReadList);

            string json = JsonConvert.SerializeObject(passengerData, Formatting.Indented);
            File.WriteAllText("Output.json", json);
        }

    }
}