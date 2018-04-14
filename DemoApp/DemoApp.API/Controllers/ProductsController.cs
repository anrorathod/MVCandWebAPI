using DemoApp.Business.Contracts;
using DemoApp.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoApp.API.Controllers
{
    public class ProductsController : ApiController
    {
        private IProductManager product;
        public ProductsController(IProductManager product)
        {
            this.product = product;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return product.GetAll();
        }


        [HttpGet]
        public Product Get(int id)
        {
            return product.Get(id);
        }
    }
}
