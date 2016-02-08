using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_proj
{
    public class Seat
    {
        public int Row;
        public Columns Column;
        public Seat(int row, Columns column)
        {
            this.Column = column;
            this.Row = row;
        }
    }
}
