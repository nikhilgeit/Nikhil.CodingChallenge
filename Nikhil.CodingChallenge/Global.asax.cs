using CodingChallenge.BusinessLayer.Services;
using Nikhil.CodingChallenge.Contracts;
using Nikhil.CodingChallenge.Services;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using Unity.AspNet.Mvc;

namespace Nikhil.CodingChallenge
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RegisterComponents();
        }

        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<IDeductionService, DeductionService>();
            container.RegisterType<IDiscountService, DiscountService>(); 
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
