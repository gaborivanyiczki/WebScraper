using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompariAPI.App_Start
{
    public class Constants
    {
        public const string Altex = "Altex";
        public const string Emag = "Emag";
        public const string MediaGalaxy = "MediaGalaxy";

        static readonly List<string> ShopsList = new List<string>
        {
            "Altex",
            "Emag",
            "MediaGalaxy"
        };

        public static List<string> GetShops()
        {
            return ShopsList;
        }
    }
}