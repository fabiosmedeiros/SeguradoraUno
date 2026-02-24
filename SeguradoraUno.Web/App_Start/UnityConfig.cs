using SeguradoraUno.Domain.Interfaces.Repository;
using SeguradoraUno.Domain.Interfaces.UoW;
using SeguradoraUno.Repo.Data.Repository;
using SeguradoraUno.Repo.Data.UoW;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace SeguradoraUno.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

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