using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_proj
{
    public class Passenger
    {
        public string Name { get; set; }
        //public int Age { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public int FlightNumber { get; set; }
        public string Seat { get; set; }
        public string TravelDate { get; set; }
        public void GetName(string name)
        {
            this.Name = name;
        }
        public void GetOrigin(string origin)
        {
            this.Origin = origin;
        }
        public void GetDestination(string destination)
        {
            this.Destination = destination;
        }
        public void GetFlightNumber(int flightNumber)
        {
            Console.WriteLine("Please enter Flight Number:");
            this.FlightNumber = flightNumber;
        }
        public Passenger(string fullName, string travelDate, string seatNumber, string destination, string origin)
        {
            this.Name = fullName;
            this.Destination = destination;
            this.Seat = seatNumber;
            this.TravelDate = travelDate;
            this.Origin = origin;


        }
    }
}
