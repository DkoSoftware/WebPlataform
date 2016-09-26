using FamintusApi.Models;

namespace FamintusApi.Servicos.Produto
{
    public interface IProdutoServico
    {
        void Adicionar(ProdutoModel produto);

        void Atualizar(ProdutoModel produto);

        void Remover(ProdutoModel produto);
    }
}