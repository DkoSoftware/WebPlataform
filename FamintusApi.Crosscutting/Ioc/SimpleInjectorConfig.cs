using System.Web.Http;
using FamintusApi.Crosscutting.ProvedorDeDados;
using FamintusApi.Dominio.Base;
using FamintusApi.Dominio.Repositorios;
using FamintusApi.Dominio.Servicos;
using FamintusApi.Infraestrutura.Base;
using FamintusApi.Infraestrutura.Repositorios;
using FamintusApi.Servicos;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using Container = SimpleInjector.Container;

namespace FamintusApi.Crosscutting.Ioc
{
    public static class SimpleInjectorConfig
    {
        private static Container _container;

        public static Container Initialize(HttpConfiguration configuration)
        {
            _container = new Container();

            RegisterComponents(_container);

            _container.RegisterWebApiControllers(configuration);

            _container.Verify();

            return _container;
        }

        public static void RegisterComponents(Container container)
        {
            //Verificar pois a camada de Api nao deveria enxergar a infra mas sim o serv de app
            container.RegisterWebApiRequest<IUnidadeDeTrabalho, UnidadeDeTrabalho>(); 
            //container.Register<IFamintusDataContext>(() => new FamintusMemoryContext(PopuladorDados.ObterDados()), Lifestyle.Singleton);
            RegistraRepositorios(container);
            RegistraServicos(container);
        }

        private static void RegistraRepositorios(Container container)
        {
            container.RegisterWebApiRequest<ILojaRepositorio, LojaRepositorio>();
            container.RegisterWebApiRequest<IProdutoRepositorio, ProdutoRepositorio>();
        }

        private static void RegistraServicos(Container container)
        {
            container.RegisterWebApiRequest<IProdutoServico, ProdutoServico>();
        }
    }
}