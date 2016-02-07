using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Airline_proj;


namespace JsonFileWriter
{
   
    public class Writer
    {
        public void Jwriter(string fullName, string travelDate, string seatNumber, string destination )
        {
            List<Passenger> psngrData = new List<Passenger>();
            Passenger passenger = new Passenger(fullName, travelDate, seatNumber, destination);
            psngrData.Add(passenger);
            //FileReader FR = new FileReader();
            //Passenger.Add(fullName);
            //Passenger.Add(travelDate);
            //Passenger.Add(seatNumber);
            //Passenger.Add(destination);
            //string json = JsonConvert.SerializeObject(Passenger.ToArray(), Formatting.Indented);
            //File.AppendAllText("Passengers.json", json);
            //passengerData.Add(pss);

            string name = File.ReadAllText("Passengers.json");
            List<Passenger> fileReadList = JsonConvert.DeserializeObject<List<Passenger>>(name);
            psngrData.AddRange(fileReadList);

            string json = JsonConvert.SerializeObject(psngrData, Formatting.Indented);
            File.WriteAllText("Passengers.json", json);

        }
    }
}
