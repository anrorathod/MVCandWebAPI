using DemoApp.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Business.Contracts
{
    public interface IProductManager : IBaseManager<Product, int>
    {

    }
}