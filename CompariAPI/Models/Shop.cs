using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompariAPI.Models
{
    public class Shop
    {
        public int ShopID { get; set; }
        public string ShopName { get; set; }
        public string ShopLink { get; set; }
        public string ShopSearchLink { get; set; }
        public string SpaceCode { get; set; }
    }
}