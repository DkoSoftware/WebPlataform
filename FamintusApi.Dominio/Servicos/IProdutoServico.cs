using FamintusApi.Dominio.Entidades;

namespace FamintusApi.Dominio.Servicos
{
    public interface IProdutoServico
    {
        void Adicionar(ProdutoModel produto);

        void Atualizar(ProdutoModel produto);

        void Remover(ProdutoModel produto);
    }
}