using FamintusApi.Crosscutting.Ioc;
using FamintusApi.Filters;
using Newtonsoft.Json.Serialization;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FamintusApi
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            GlobalConfiguration.Configuration.Filters.Add(new ElmahErrorAttribute());

            var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            DependencyResolver.SetResolver(SimpleInjectorConfig.Initialize(GlobalConfiguration.Configuration));
        }
    }
}