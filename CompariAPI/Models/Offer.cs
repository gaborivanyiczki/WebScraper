using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompariAPI.Models
{
    public class Offer
    {
        //public int OfferID { get; set; }
        public string ProductName { get; set; }
        public string OldPrice { get; set; }
        public string DiscountPrice { get; set; }
        public string Availability { get; set; }
        public string Link { get; set; }
        public string Reviews { get; set; }

    }
}