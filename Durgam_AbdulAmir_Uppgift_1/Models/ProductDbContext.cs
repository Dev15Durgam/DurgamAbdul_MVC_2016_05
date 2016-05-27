using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durgam_AbdulAmir_Uppgift_1.Models
{
   public class ProductDbContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
        public ProductDbContext() : base("ProductEntity")
        {
            Database.SetInitializer<ProductDbContext>(new ProductDbContextInitializer());
        }
    }
}
