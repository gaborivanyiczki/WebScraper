using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompariAPI.Models;

namespace CompariAPI.Repositories.Interfaces
{
    public interface IOfferRepository
    {
        IEnumerable<Offer> GetOffers();
    }
}