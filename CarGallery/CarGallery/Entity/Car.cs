using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarGallery.Entity;

namespace CarGallery.Entity
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }

        public string CarBrand { get; set; }

        public string CarModel { get; set; }

        public string CarYear { get; set; }

        public string CarColor { get; set; }

        public int CarPurchasePrice { get; set; }

        public int CarSellPrice { get; set; }

        public string CarPlate { get; set; }

        public int CarProfit { get; set; }

        public string CarProfitStatus { get; set; }
    }
}
