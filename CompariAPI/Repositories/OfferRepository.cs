using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using CompariAPI.App_Start;
using CompariAPI.DAL;
using CompariAPI.Handlers;
using CompariAPI.Helpers;
using CompariAPI.Models;
using CompariAPI.Repositories.Interfaces;
using HtmlAgilityPack;

namespace CompariAPI.Repositories
{
    public class OfferRepository
    {
        public static IEnumerable<Offer> GetOffers(string search)
        {
            ShopRepository shopRepository = new ShopRepository(new DBContext());

            List<Offer> OffersList = new List<Offer>();

            var ShopsList = shopRepository.GetShops();

            foreach (var shop in ShopsList)
            {
                OffersHelper.PopulateOffer(ref OffersList,shop,search);   
            }

            return OffersList;

        }  


        
    }
}