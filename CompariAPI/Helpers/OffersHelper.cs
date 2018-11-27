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
        public static void PopulateOffer(ref List<Offer> OffersList, string shop)
        {

            switch (shop)
            {
                 case Constants.Altex :
                     OffersList.Add(AltexScraper.GetOffer());
                     break;

                 case Constants.Emag :
                     OffersList.Add(EmagScraper.GetOffer());
                     break;

                 case Constants.MediaGalaxy :
                     OffersList.Add(MediaGalaxyScraper.GetOffer());
                     break;
            }
        }
    }
}