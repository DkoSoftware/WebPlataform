using FamintusApi.Models;
using System;

namespace FamintusApi.Repositorios.Produto
{
    public interface IProdutoRepositorio
    {
        ProdutoModel ObterPeloId(Int32 id);

        ProdutoModel[] ObterDaLoja(Int32 idLoja);
    }
}