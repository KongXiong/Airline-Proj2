using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;

namespace Airline_proj
{
    class Program
    {
        static void Main()
        {
            FileWriter FW = new FileWriter();
            FW.PsgInfo();


            //FR.LoadJson();
            //Airplane Plane1 = new Airplane();
            //Plane1.seating();


            //Flight flight = new Flight("LAX");
            //Console.WriteLine(flight.TravelDist); 


            //Sales sale = new Sales();
            //Console.WriteLine(sale.UniqueID); 

            //GoogleCalendar GC = new GoogleCalendar();
            //GC.AddEvent();
            Console.ReadKey();
            ////JavaScriptSerializer ser = new JavaScriptSerializer();
            //FileWriter FW = new FileWriter();
            //FW.PsgInfo();
            ////string outputJSON = ser.Serialize(FW.PsgInfo());
            //filereader fr = new filereader();
            //fr.loadjson();
            //console.readkey();
            //EmailReceipt er = new EmailReceipt();
            //er.Email();
        }
    }
}
