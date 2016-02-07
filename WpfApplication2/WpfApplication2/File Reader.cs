using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft;

namespace WpfApplication2
{
    public class File_Reader
    {
        List<Passengers> passengers = new List<WpfApplication2.Passengers>();
        public List<Passengers> readFile()
        {
            string json = File.ReadAllText(@"Output.json");
            passengers = JsonConvert.DeserializeObject<List<Passengers>>(json);
            return passengers;
        }
        //public string fileToString()
        //{
        //    foreach(Passengers name in passengers)
        //    {

        //    }
        //}
    }
}
