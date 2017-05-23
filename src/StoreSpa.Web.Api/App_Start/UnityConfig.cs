using Microsoft.Practices.Unity;
using StoreSpa.Business.Services;
using StoreSpa.DataAccess;
using System.Web.Http;
using Unity.WebApi;

namespace StoreSpa.Web.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        private static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IProductDal, ProductDal>();
        }
    }
}