using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CreativeCollab_UberDealership3.Models
{
    public class Driver
    {
        [Key]
        public int DriverID { get; set; }
        public string DriverFirstName { get; set; }
        public string DriverLastName { get; set; }

        [ForeignKey("Cars")]
        public int CarID { get; set; }
        public virtual Car Cars { get; set; }

    }

    public class DriverDto
    {
        public int DriverID { get; set; }
        public string DriverFirstName { get; set; }
        public string DriverLastName { get; set; }

        public int Year { get; set; }
        public int Mileage { get; set; }
        public int Price { get; set; }


        public string CarModelName { get; set; }

        public string CarMakeName { get; set; }
        public string DealerName { get; set; }
    }
}