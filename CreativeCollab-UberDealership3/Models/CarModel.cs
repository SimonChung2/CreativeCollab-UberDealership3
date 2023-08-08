using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CreativeCollab_UberDealership3.Models
{
    public class CarModel
    {
        [Key]
        public int ModelID { get; set; }
        public string ModelName { get; set; }
        public string Make { get; set; }
    }
}