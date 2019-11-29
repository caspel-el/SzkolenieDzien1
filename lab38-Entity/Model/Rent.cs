using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab38_Entity.Model
{
    public class Rent
    {
        public int RentId { get; set; }
        public DateTime RentDate { get; set; }
        public Nullable<DateTime> ReturnDate { get; set; }
        public Bike Bike { get; set; }
    }
}
