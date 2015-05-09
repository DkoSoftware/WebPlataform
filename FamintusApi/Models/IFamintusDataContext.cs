using System.Linq;
using FamintusApi.Dominio.Base;
using FamintusApi.Dominio.Entidades;

namespace FamintusApi.Models
{
    /// <summary>
    /// Define os contexto de dados dos modelos a serem trabalhados.
    /// </summary>
    public interface IFamintusDataContext
    {
        IQueryable<LojaModel> Lojas { get; }

        IQueryable<ProdutoModel> Produtos { get; }

        IQueryable<ComandaModel> Comandas { get; }

        void Adicionar<T>(T modelo) where T : class, IModel;

        void Remover<T>(T modelo) where T : class, IModel;

        void AplicarAlteracoes();
    }
}