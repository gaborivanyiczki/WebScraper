using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using CompariAPI.App_Start;
using CompariAPI.Handlers;
using CompariAPI.Helpers;
using CompariAPI.Models;
using CompariAPI.Repositories.Interfaces;
using HtmlAgilityPack;

namespace CompariAPI.Repositories
{
    public class OfferRepository
    {
        public static IEnumerable<Offer> GetOffers()
        {
            List<Offer> OffersList = new List<Offer>();
            List<string> ShopsList = Constants.GetShops();

            foreach (var shop in ShopsList)
            {
                OffersHelper.PopulateOffer(ref OffersList,shop);   
            }

            return OffersList;

        }  


        
    }
}