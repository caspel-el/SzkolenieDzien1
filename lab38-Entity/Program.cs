using lab38_Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab38_Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddBikes();
            RentBike();

        }

        private static void RentBike()
        {
            using (var context = new RentBikeContext())
            {
                var bike = context
                    .Bikes
                    .Where(t => t.BikeType == BikeType.Town)
                    .FirstOrDefault();
                var rent = new Rent
                {
                    RentDate = DateTime.Now,
                    Bike = bike
                };
                context.Rents.Add(rent);
                context.SaveChanges();
            }
        }

        private static void AddBikes()
        {
            var bikes = new List<Bike>
            {
                new Bike { Number = "001", BikeType=BikeType.Town},
                new Bike { Number = "002", BikeType=BikeType.Mountain},
                new Bike { Number = "003", BikeType=BikeType.Town},
                new Bike { Number = "004", BikeType=BikeType.Mountain},
                new Bike { Number = "005", BikeType=BikeType.Road},
                new Bike { Number = "006", BikeType=BikeType.Road},
                new Bike { Number = "007", BikeType=BikeType.Mountain}

            };

            using (var context = new RentBikeContext())
            {
                context.Bikes.AddRange(bikes);
                context.SaveChanges();
            }
        }
    }
}
