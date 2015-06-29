using FamintusApi.Models;
using System;

namespace FamintusApi.Servicos.Produto
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IFamintusDataContext contexto;

        public ProdutoServico(IFamintusDataContext contexto)
        {
            if (contexto == null)
                throw new ArgumentNullException("contexto");

            this.contexto = contexto;
        }

        public void Adicionar(ProdutoModel produto)
        {
            //TODO: Validar e cadastrar produto
            produto.Id = (new Random()).Next(1, 100000);

            contexto.Adicionar(produto);
            contexto.AplicarAlteracoes();
        }

        public void Atualizar(ProdutoModel produto)
        {
            //TODO: Validar e atualizar produto

            contexto.Adicionar(produto);
            contexto.AplicarAlteracoes();
        }

        public void Remover(ProdutoModel produto)
        {
            //TODO: Validar

            contexto.Remover(produto);
            contexto.AplicarAlteracoes();
        }
    }
}