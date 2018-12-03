using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompariAPI.App_Start;
using CompariAPI.Handlers;
using CompariAPI.Models;

namespace CompariAPI.Helpers
{
    public class OffersHelper
    {
        public static void PopulateOffer(ref List<Offer> OffersList, Shop shop, string search)
        {

            switch (shop.ShopName)
            {
                 case Constants.Altex :
                     OffersList.Add(AltexScraper.GetOffer(shop,search));
                     break;

                 case Constants.Emag :
                     OffersList.Add(EmagScraper.GetOffer(shop,search));
                     break;

                 case Constants.MediaGalaxy :
                     OffersList.Add(MediaGalaxyScraper.GetOffer(shop,search));
                     break;
            }
        }

        public static string BuildLink(Shop shop, string search)
        {
            return shop.ShopSearchLink + Uri.EscapeUriString(search);
        }    
     
    }
}