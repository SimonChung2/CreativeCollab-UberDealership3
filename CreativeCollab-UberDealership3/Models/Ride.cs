using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CreativeCollab_UberDealership3.Models
{
    public class Ride
    {
        [Key]
        public int RideId { get; set; }
        public string RideName { get; set; }

        public string StartLocation { get; set; }
        public string EndLocation { get; set; }

        //[ForeignKey("Cars")]
        public int CarID { get; set; }
        //public virtual Car Cars { get; set; }


        public int DriverID { get; set; }
        //public virtual Driver Drivers { get; set; }




        //a car can be driven by many drivers
        //public ICollection<Driver> Drivers { get; set; }
    }

    public class RideDto
    {
        public int RideId { get; set; }
        public string RideName { get; set; }

        public string StartLocation { get; set; }
        public string EndLocation { get; set; }

        public int CarID { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public int Price { get; set; }

        public string CarModelName { get; set; }

        public string CarMakeName { get; set; }
        public string DealerName { get; set; }

        public string DriverFirstName { get; set; }
        public string DriverLastName { get; set; }
    }
}