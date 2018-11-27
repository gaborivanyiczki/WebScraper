using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CompariAPI.Models;
using CompariAPI.Repositories;

namespace CompariAPI.Controllers
{
    public class ProductController : ApiController
    {
        public IEnumerable<Offer> Get()
        {

            return OfferRepository.GetOffers();

        }
    }
}
