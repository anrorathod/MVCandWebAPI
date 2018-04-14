using DemoApp.DataBase.RepositoryContract;
using DemoApp.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoApp.DataBase.Repository
{
    public class ProductRepoManager : IProductRepoManager
    {
        private readonly AppDataContext db;
        public ProductRepoManager(AppDataContext context)
        {
            db = context;
        }

        public long Add(Product model)
        {
            db.Products.Add(model);
            int inserted = db.SaveChanges();

            return inserted;
        }

        public long Delete(int id)
        {
            int deleted = 0;
            var product = db.Products.FirstOrDefault(b => b.ProductId == id);
            if (product != null)
            {
                db.Products.Remove(product);
                deleted = db.SaveChanges();
            }
            return deleted;
        }

        public Product Get(int id)
        {
            return db.Products.FirstOrDefault(b => b.ProductId == id);
        }

        public IEnumerable<Product> GetAll()
        {
            // Remove below line once actual development starts
            //For testing purpose, we set 5 seconds to assume that query takes 5 seconds to load data from database.
            //System.Threading.Thread.Sleep(5000);
            return db.Products.ToList();
        }

        public long Update(int id, Product model)
        {
            long updated = 0;
            var product = db.Products.Find(id);
            if (product != null)
            {
                product.ProductName = model.ProductName;
                product.Description = model.Description;
                product.Category = model.Category;
                product.Price = model.Price;
                updated = db.SaveChanges();
            }
            return updated;
        }


    }
}