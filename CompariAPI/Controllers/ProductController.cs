using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CompariAPI.Handlers;
using CompariAPI.Helpers;
using CompariAPI.Models;

namespace CompariAPI.Controllers
{
    public class ProductController : ApiController
    {
        public List<Offer> Get()
        {
            List<Offer> ItemList;

            ItemList = ScraperHelper.Scrape();      

            return ItemList.ToList();

        }
    }
}
