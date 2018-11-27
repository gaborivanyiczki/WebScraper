using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using CompariAPI.Models;
using HtmlAgilityPack;

namespace CompariAPI.Handlers
{
    public class EmagScraper
    {
        public static Offer GetOffer()
        {
            string Link = "https://www.emag.ro/telefon-mobil-huawei-mate-10-pro-dual-sim-128gb-4g-titanium-grey-mate-10-pro-ds-grey/pd/DG1R30BBM/";         
            HtmlWeb website = new HtmlWeb();
            website.AutoDetectEncoding = false;
            website.OverrideEncoding = Encoding.Default;
            HtmlDocument Doc = website.Load(Link);

            Offer offer = new Offer
            {
                ProductName = Doc.DocumentNode.Descendants("h1")
                    .First(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("page-title")).InnerText,

                OldPrice = Doc.DocumentNode.Descendants("p")
                    .First(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("product-old-price")).Element("s").InnerText,

                DiscountPrice =  Doc.DocumentNode.Descendants("p")
                    .First(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("product-new-price")).InnerText,

                Availability = Doc.DocumentNode.Descendants("span")
                    .First(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("label label-in_stock")).InnerText,

                Link = Link,

                Reviews = Doc.DocumentNode.Descendants("a")
                    .First(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("gtm_rp160118")).InnerText,
                
                ReviewsLink = Link
            };

            return offer;
        }

    }
}