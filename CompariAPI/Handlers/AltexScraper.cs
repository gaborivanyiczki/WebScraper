using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompariAPI.Models;
using IronWebScraper;

namespace CompariAPI.Handlers
{
   public class AltexScraper : WebScraper
   {
       public List<Offer> ItemList;
       public string link;

        public AltexScraper(ref List<Offer> offerList)
        {
            ItemList = offerList;
        }
     
        public override void Init()
        {
            link = "https://altex.ro/telefon-huawei-mate-10-pro-dual-sim-128-gb-grey/cpd/SMTMATE10PROGR/";
            LoggingLevel = WebScraper.LogLevel.All;
            Request(link, Parse);
        }


        public override void Parse(Response response)
        {
            // set working directory for the project
            WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // Loop on all Links
            //foreach (var title_link in response.Css("title.next-head"))
            if(response.CssExists("title.next-head"))
            {
                Offer offer = new Offer
                {
                    ProductName =  response.Css("title.next-head")[0].TextContentClean,
                    OldPrice = response.Css("div.Price-old")[0].TextContentClean,
                    DiscountPrice = response.Css("div.Price-current > span")[0].TextContentClean,
                    Availability = response.Css("div.Status")[0].TextContentClean,
                    Reviews = response.Css("a.Rating-reviews > span")[0].TextContentClean,
                    Link = link
                };

               ItemList.Add(offer);
            }        

        }
      
    }
}