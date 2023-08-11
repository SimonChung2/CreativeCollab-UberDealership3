using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreativeCollab_UberDealership3.Models.ViewModels
{
    public class CreateCar
    {
        public IEnumerable<CarModel> CarModelOptions { get; set; }

        public IEnumerable<Dealer> DealerOptions { get; set; }
    }
}