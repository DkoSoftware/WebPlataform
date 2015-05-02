using FamintusApi.Models;
using System;
using System.Linq;

namespace FamintusApi.Repositorios.Produto
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly IFamintusDataContext contexto;

        public ProdutoRepositorio(IFamintusDataContext contexto)
        {
            if (contexto == null)
                throw new ArgumentNullException("contexto");

            this.contexto = contexto;
        }

        public ProdutoModel ObterPeloId(Int32 id)
        {
            return this.contexto.Produtos.SingleOrDefault(p => p.Id == id);
        }

        public ProdutoModel[] ObterDaLoja(Int32 idLoja)
        {
            return this.contexto.Produtos
                .Where(p => p.IdLoja == idLoja)
                .OrderBy(p => p.Nome)
                .ToArray();
        }
    }
}