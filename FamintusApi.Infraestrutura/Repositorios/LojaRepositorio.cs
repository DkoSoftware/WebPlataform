using System;
using System.Linq;
using FamintusApi.Dominio.Entidades;
using FamintusApi.Dominio.Repositorios;
using Infraestrutura.Base;

namespace FamintusApi.Infraestrutura.Repositorios
{
    public class LojaRepositorio : RepositorioBase<LojaModel>, ILojaRepositorio
    {
        //private readonly IFamintusDataContext contexto;

        //public LojaRepositorio(IFamintusDataContext contexto)
        //{
        //    if (contexto == null)
        //        throw new ArgumentNullException("contexto");

        //    this.contexto = contexto;
        //}

        //public LojaModel ObterPeloId(Int32 id)
        //{
        //    return Queryable.SingleOrDefault<LojaModel>(this.contexto.Lojas, l => l.Id == id);
        //}
        public LojaRepositorio(Contexto contexto) : base(contexto)
        {
        }

        public LojaModel ObterPeloId(int id)
        {
            throw new NotImplementedException();
        }
    }
}