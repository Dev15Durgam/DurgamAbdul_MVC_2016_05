using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durgam_AbdulAmir_Uppgift_1.Models
{
    public class ProductDbContextInitializer : DropCreateDatabaseAlways<ProductDbContext>
    {
        protected override void Seed(ProductDbContext context)
        {


            var products = new List<Product>() {
            new Product() { ProductID = 1, Name = "Product_1", ProductText = "A product With Many One's", ProductNumber = "p-111", Price = 100 , PruductsInStock = 11 },
            new Product() { ProductID=2, Name="Product_2", ProductText="A product With Many two's", ProductNumber="p-222", Price= 200,PruductsInStock=22 },
            new Product() { ProductID=3, Name="Product_3", ProductText="A product With Many three's", ProductNumber="p-333", Price= 300,PruductsInStock=33 },
            new Product() { ProductID=4, Name="Product_4", ProductText="A product With Many four's", ProductNumber="p-444", Price= 400,PruductsInStock=44 }
        };
            foreach (var product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();


            var stors = new List<Store>() {
            new Store() { StoreID = 1, Name="Store 1", Address ="StorTorget 1" /*Products= products.Select(p => p.ProductID == 1 &&( p.ProductID == 2)*/},
            new Store() { StoreID = 2, Name="Store 2", Address = "StoreTorget 2" } 
        

        };
            foreach (var store in stors)
            {
                context.Stores.Add(store);
            }
            context.SaveChanges();
        }
    }
}
