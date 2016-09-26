using FamintusApi.Models;
using FamintusApi.Repositorios;
using FamintusApi.Repositorios.Loja;
using FamintusApi.Repositorios.Produto;
using FamintusApi.Servicos.Produto;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;

namespace FamintusApi.App_Start
{
    public static class SimpleInjectorConfig
    {
        public static void Initialize(HttpConfiguration config)
        {
            // Did you know the container can diagnose your configuration? 
            // Go to: https://simpleinjector.org/diagnostics
            var container = new Container();

            RegisterComponents(container);

            container.RegisterWebApiControllers(config);

            container.Verify();

            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }

        public static void RegisterComponents(Container container)
        {
            container.Register<IFamintusDataContext>(() => new FamintusMemoryContext(PopuladorDados.ObterDados()), Lifestyle.Singleton);

            container.RegisterWebApiRequest<ILojaRepositorio, LojaRepositorio>();
            container.RegisterWebApiRequest<IProdutoRepositorio, ProdutoRepositorio>();

            container.RegisterWebApiRequest<IProdutoServico, ProdutoServico>();
        }
    }
}