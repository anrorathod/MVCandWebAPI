namespace DemoApp.DataBase.Migrations
{
    using DemoApp.Entities.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DemoApp.DataBase.AppDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DemoApp.DataBase.AppDataContext context)
        {
            var p1 = new Product { ProductName = "Product 1", Category = 1, Description = "Description 1", Price = 100 };
            var p2 = new Product { ProductName = "Product 2", Category = 2, Description = "Description 2", Price = 200 };
            var p3 = new Product { ProductName = "Product 3", Category = 3, Description = "Description 3", Price = 300 };
            var p4 = new Product { ProductName = "Product 4", Category = 4, Description = "Description 4", Price = 400 };
            var p5 = new Product { ProductName = "Product 5", Category = 5, Description = "Description 5", Price = 500 };
            var p6 = new Product { ProductName = "Product 6", Category = 1, Description = "Description 1", Price = 100 };
            var p7 = new Product { ProductName = "Product 7", Category = 1, Description = "Description 1", Price = 100 };

            context.Products.AddOrUpdate(p => p.ProductName, p1, p2, p3, p4, p5, p6, p7);


            //context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
