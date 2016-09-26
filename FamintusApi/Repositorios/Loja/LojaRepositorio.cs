using FamintusApi.Models;
using System;
using System.Linq;

namespace FamintusApi.Repositorios.Loja
{
    public class LojaRepositorio : ILojaRepositorio
    {
        private readonly IFamintusDataContext contexto;

        public LojaRepositorio(IFamintusDataContext contexto)
        {
            if (contexto == null)
                throw new ArgumentNullException("contexto");

            this.contexto = contexto;
        }

        public LojaModel ObterPeloId(Int32 id)
        {
            return this.contexto.Lojas.SingleOrDefault(l => l.Id == id);
        }
    }
}