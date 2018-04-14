using DemoApp.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.DataBase.RepositoryContract
{
    public interface IProductRepoManager : IDataRepository<Product, int>
    {
    }
}