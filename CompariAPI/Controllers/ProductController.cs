using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CompariAPI.Models;
using CompariAPI.Repositories;

namespace CompariAPI.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        public IEnumerable<Offer> Get(string productName)
        {

            return OfferRepository.GetOffers(productName);

        }
    }
}
