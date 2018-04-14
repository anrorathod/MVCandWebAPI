using DemoApp.Business.Contracts;
using DemoApp.DataBase.RepositoryContract;
using DemoApp.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Business.Manager
{
    public class ProductManager : IProductManager
    {
        private IProductRepoManager _iRepo;
        public ProductManager(IProductRepoManager repo)
        {
            _iRepo = repo;
        }

        public long Add(Product model)
        {
            var data = _iRepo.Add(model);
            return data;
        }

        public long Delete(int id)
        {
            var data = _iRepo.Delete(id);
            return data;
        }

        public Product Get(int id)
        {
            Product product = _iRepo.Get(id);

            return product;
        }

        public IEnumerable<Product> GetAll()
        {
            var data = _iRepo.GetAll().ToList();
            return data;
        }

        public long Update(int id, Product model)
        {
            var data = _iRepo.Update(id, model);

            return data;
        }
    }
}
