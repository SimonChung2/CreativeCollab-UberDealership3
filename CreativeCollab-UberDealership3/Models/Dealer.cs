using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CreativeCollab_UberDealership3.Models
{
    public class Dealer
    {
        [Key]
        public int DealerID { get; set; }
        public string DealerName { get; set; }
    }
}