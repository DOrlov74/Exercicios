using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShop.API.Models;

namespace OnlineShop.API.Data
{
    public class OnlineShopContext : DbContext
    {
        public OnlineShopContext (DbContextOptions<OnlineShopContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineShop.API.Models.Client> Clients { get; set; }

        public DbSet<OnlineShop.API.Models.Cart> Carts { get; set; }

        public DbSet<OnlineShop.API.Models.Product> Products { get; set; }

        public DbSet<OnlineShop.API.Models.CartProduct> CartProducts { get; set; }

        public DbSet<OnlineShop.API.Models.Discount> Discounts { get; set; }

        public DbSet<OnlineShop.API.Models.Transaction> Transactions { get; set; }
    }
}
