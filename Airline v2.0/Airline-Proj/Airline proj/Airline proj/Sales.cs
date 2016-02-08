using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_proj
{
    class Sales : Passenger
    {
        //double price;
        public string UniqueID
        {

            get { return Guid.NewGuid().ToString("N"); }
            set { }
        }
        public void Getdate()
        {
            //DateTime dt = new DateTime();
            //dt.
        }
        //a date
        //transaction date time 
        //flight#, date time using schedule

    }
}
