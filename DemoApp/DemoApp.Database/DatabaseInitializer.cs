using DemoApp.Entities.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DemoApp.DataBase
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<AppDataContext>
    {
        protected override void Seed(AppDataContext context)
        {
            var products = new List<Product>()
            {
                new Product{ ProductName="Product 1", Category=1, Description="Description 1", Price = 100},
                new Product{ ProductName="Product 2", Category=2, Description="Description 2", Price = 200},
                new Product{ ProductName="Product 3", Category=3, Description="Description 3", Price = 300},
                new Product{ ProductName="Product 4", Category=4, Description="Description 4", Price = 400},
                new Product{ ProductName="Product 5", Category=5, Description="Description 5", Price = 500},
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}