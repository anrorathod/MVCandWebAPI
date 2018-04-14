using System.Web.Mvc;
using DemoApp.Business;
using DemoApp.Business.Contracts;
using DemoApp.Business.Manager;
using DemoApp.Controllers;
using DemoApp.DataBase.Repository;
using DemoApp.DataBase.RepositoryContract;
using Microsoft.Practices.Unity;
using Unity.Mvc3;

namespace DemoApp
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IProductManager, ProductManager>();
            container.RegisterType<IProductRepoManager, ProductRepoManager>();

            return container;
        }
    }
}