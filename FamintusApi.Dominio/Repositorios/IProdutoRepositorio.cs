using System;
using FamintusApi.Dominio.Entidades;

namespace FamintusApi.Dominio.Repositorios
{
    public interface IProdutoRepositorio
    {
        ProdutoModel ObterPeloId(Int32 id);

        ProdutoModel[] ObterDaLoja(Int32 idLoja);
    }
}