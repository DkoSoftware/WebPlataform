using System;
using FamintusApi.Dominio.Entidades;

namespace FamintusApi.Dominio.Repositorios
{
    public interface ILojaRepositorio
    {
        LojaModel ObterPeloId(Int32 id);
    }
}