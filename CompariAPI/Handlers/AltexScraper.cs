using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using CompariAPI.Helpers;
using CompariAPI.Models;
using HtmlAgilityPack;

namespace CompariAPI.Handlers
{
    public class AltexScraper
    {
        public static ICollection<Offer> GetOffers(Shop shop, string search)
        {

            return;
        }
        public static Offer GetOffer(Shop shop, string search)
        {
            string Link = OffersHelper.BuildLink(shop, search);
            HtmlWeb website = new HtmlWeb();
            website.AutoDetectEncoding = false;
            website.OverrideEncoding = Encoding.Default;
            HtmlDocument Doc = website.Load(Link);

            Offer offer = new Offer
            {
                ProductName = Doc.DocumentNode.Descendants("title")
                    .First(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("next-head")).InnerText,

                OldPrice = Doc.DocumentNode.Descendants("div")
                    .First(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("Price-old")).InnerText,

                DiscountPrice =  Doc.DocumentNode.Descendants("meta")
                    .First(d => d.Attributes.Contains("itemProp") && d.Attributes["itemProp"].Value.Contains("price")).Attributes.First(e => e.Name.Contains("content")).Value,

                Availability = Doc.DocumentNode.Descendants("div")
                    .First(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("Status")).InnerText,

                Link = Link,

                Reviews = Doc.DocumentNode.Descendants("span")
                    .First(d => d.Attributes.Contains("itemProp") && d.Attributes["itemProp"].Value.Contains("reviewCount")).InnerText,
                
                ReviewsLink = Doc.DocumentNode.Descendants("a").First(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("Rating-reviews")).Attributes.First(e => e.Name.Contains("href")).Value
            };

            return offer;
        }

    }
}