using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompariAPI.Handlers;
using CompariAPI.Models;

namespace CompariAPI.Helpers
{
    public class ScraperHelper
    {
        public static List<Offer> Scrape()
        {
            List<Offer> offersList = new List<Offer>();

            try
            {
                AltexScraper scraper = new AltexScraper(ref offersList);

                scraper.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }         
                return offersList;     
        }
    }
}