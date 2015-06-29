using FamintusApi.Models;
using System;

namespace FamintusApi.Repositorios.Loja
{
    public interface ILojaRepositorio
    {
        LojaModel ObterPeloId(Int32 id);
    }
}