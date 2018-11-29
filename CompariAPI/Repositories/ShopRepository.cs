using CompariAPI.DAL;
using CompariAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompariAPI.Repositories
{
    public class ShopRepository
    {
        private DBContext context;

        public ShopRepository(DBContext context)
        {
            this.context = context;
        }

        public ICollection<Shop> GetShops()
        {
            return context.Shops.ToList();
        }
    }
}