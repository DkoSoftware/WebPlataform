using System;
using System.Linq;
using FamintusApi.Dominio.Entidades;
using FamintusApi.Dominio.Repositorios;
using Infraestrutura.Base;

namespace FamintusApi.Infraestrutura.Repositorios
{
    public class ProdutoRepositorio : RepositorioBase<ProdutoModel>, IProdutoRepositorio
    {
        #region [ britz ]

        //private readonly IFamintusDataContext contexto;

        //public ProdutoRepositorio(IFamintusDataContext contexto)
        //{
        //    if (contexto == null)
        //        throw new ArgumentNullException("contexto");

        //    this.contexto = contexto;
        //}

        //public ProdutoModel ObterPeloId(Int32 id)
        //{
        //    return this.contexto.Produtos.SingleOrDefault(p => p.Id == id);
        //}

        //public ProdutoModel[] ObterDaLoja(Int32 idLoja)
        //{
        //    return Queryable.Where<ProdutoModel>(this.contexto.Produtos, p => p.IdLoja == idLoja)
        //        .OrderBy(p => p.Nome)
        //        .ToArray();
        //}

        #endregion

        public ProdutoRepositorio(Contexto contexto) : base(contexto)
        {
        }

        public ProdutoModel ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public ProdutoModel[] ObterDaLoja(int idLoja)
        {
            throw new NotImplementedException();
        }
    }
}