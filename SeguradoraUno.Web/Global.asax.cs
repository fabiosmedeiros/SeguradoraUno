using SeguradoraUno.Domain.Interfaces.Repository;
using SeguradoraUno.Domain.Interfaces.UoW;
using SeguradoraUno.Repo.Data.Repository;
using SeguradoraUno.Repo.Data.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

            // Configurando o container Unity.
            IUnityContainer container = new UnityContainer();
            // Registrando os componentes para a injeção de dependência.
            // Interface -> Classe Concreta
            container.RegisterType<IPessoaRepository, PessoaRepository>();
            container.RegisterType<IPessoaEnderecoRepository, PessoaEnderecoRepository>();
            container.RegisterType<IPessoaContatoRepository, PessoaContatoRepository>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            // Definindo o Unity como o Dependency Resolver.
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
