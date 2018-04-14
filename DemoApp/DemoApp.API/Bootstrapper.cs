using System.Web.Http;
using System.Web.Mvc;
using DemoApp.API.Controllers;
using DemoApp.Business.Contracts;
using DemoApp.Business.Manager;
using DemoApp.DataBase.Repository;
using DemoApp.DataBase.RepositoryContract;
using Microsoft.Practices.Unity;
using Unity;

namespace DemoApp.API
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var unity = new UnityContainer();

            // Register the Controllers that should be injectable
            unity.RegisterType<IProductManager, ProductManager>();
            unity.RegisterType<IProductRepoManager, ProductRepoManager>();

            unity.RegisterType<ProductsController>();

            // Finally, override the default dependency resolver with Unity
            GlobalConfiguration.Configuration.DependencyResolver = new IoCContainer(unity);
        }


    }
}