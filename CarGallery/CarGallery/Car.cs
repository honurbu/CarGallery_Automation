namespace CarGallery
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Car
    {
        public int CarID { get; set; }

        public string CarBrand { get; set; }

        public string CarModel { get; set; }

        public string CarYear { get; set; }

        public string CarColor { get; set; }

        public int CarPurchasePrice { get; set; }

        public int CarProfit { get; set; }

        public int CarSellPrice { get; set; }

        public string CarPlate { get; set; }

        public string CarProfitStatus { get; set; }
    }
}
