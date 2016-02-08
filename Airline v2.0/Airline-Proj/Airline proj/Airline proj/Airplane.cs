using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_proj
{
    public class Airplane
    {
        public List<Seat> Seats = new List<Seat>();
        //int range;
        public void seating()
        {
            foreach (Columns column in Enum.GetValues(typeof(Columns)))
            {
                foreach (Rows row in Enum.GetValues(typeof(Rows)))
                {
                    Seat seat = new Seat((int)row, column);
                    Seats.Add(seat);
                    //Console.WriteLine("{1} {0}", (int)row, column);
                }
            }
        }
        //seats available vs seats sold(sold must seatsavail--
        //matainence counter for each

    }
}
