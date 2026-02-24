using SeguradoraUno.Domain.Interfaces.Repository;
using SeguradoraUno.Domain.Interfaces.UoW;
using SeguradoraUno.Repo.Data.Repository;
using SeguradoraUno.Repo.Data.UoW;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using Unity.Mvc5;

namespace SeguradoraUno.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // Registrando os componentes com o Unity.
            UnityConfig.RegisterComponents();
        }
    }
}
