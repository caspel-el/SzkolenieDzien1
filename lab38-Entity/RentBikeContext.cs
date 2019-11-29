using lab38_Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab38_Entity
{
    public class RentBikeContext:DbContext
    {
        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public RentBikeContext() : base("RentBike")
        {

        }

    }
}
