using System;
using System.Linq;
using System.Linq.Expressions;
using FamintusApi.Infraestrutura;

namespace Infraestrutura.Base
{
    public abstract class ConsultaBase<T> where T : class
    {
        private readonly Contexto _contexto;
        protected IQueryable<T> Queryable;

        protected ConsultaBase(Contexto contexto)
        {
            _contexto = contexto;
            InicializarConsulta();
        }

        protected void InicializarConsulta()
        {
            Queryable = _contexto.Set<T>();
        }

        public ConsultaBase<T> AdicionarRestricao(Expression<Func<T, bool>> restricao)
        {
            Queryable = Queryable.Where(restricao);
            return this;
        }
    }
}
