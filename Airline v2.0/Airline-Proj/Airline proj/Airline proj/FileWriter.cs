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
            //FileReader FR = new FileReader();
            //Passenger.Add(fullName);
            //Passenger.Add(travelDate);
            //Passenger.Add(seatNumber);
            //Passenger.Add(destination);
            //string json = JsonConvert.SerializeObject(Passenger.ToArray(), Formatting.Indented);
            //File.AppendAllText("Passengers.json", json);
            //passengerData.Add(pss);

            string readFile = File.ReadAllText("Passengers.json");
            List<Passenger> fileReadList = JsonConvert.DeserializeObject<List<Passenger>>(readFile);
            psngrData.AddRange(fileReadList);

            string json = JsonConvert.SerializeObject(psngrData, Formatting.Indented);
            File.WriteAllText("Passengers.json", json);

        }
        public void PsgInfo()
        {
            //Passenger pss = new Passenger();

            //Console.WriteLine("Please enter your Name:");
            //pss.GetName(Console.ReadLine());

            //Console.WriteLine("Please enter your Age:");
            //pss.GetAge(Convert.ToInt32(Console.ReadLine()));

            //Console.WriteLine("Please enter Origin:");
            //pss.GetOrigin(Console.ReadLine());

            //Console.WriteLine("Please enter your Destination:");
            //pss.GetDestination(Console.ReadLine());

            List<Passenger> passengerData = new List<Passenger>();
            //passengerData.Add(pss);

            FileReader FR = new FileReader();
            List<Passenger> fileReadList = FR.LoadJson();
            passengerData.AddRange(fileReadList);

            string json = JsonConvert.SerializeObject(passengerData, Formatting.Indented);
            File.WriteAllText("Output.json", json);
        }

    }
}