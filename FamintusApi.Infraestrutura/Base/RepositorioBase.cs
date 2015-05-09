using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using FamintusApi.Dominio.Base;
using FamintusApi.Infraestrutura;

namespace Infraestrutura.Base
{
    public abstract class RepositorioBase<T> : IRepositorioBase<T> where T : class, IRaizDeAgregacao
    {
        protected readonly DbSet<T> Lista;

        private IQueryable<T> _queryable;

        protected Contexto Contexto;

        protected RepositorioBase(Contexto contexto)
        {
            Contexto = contexto;
            Lista = contexto.Set<T>();
            _queryable = Lista;

        }

        protected IQueryable<T> Queryable
        {
            get { return _queryable; }
            set { _queryable = value; }
        }

        public virtual T ObterPorId(Guid id)
        {
            return Lista.Find(id);
        }

        public virtual T ObterPorId(int id)
        {
            return Lista.Find(id);
        }

        public void Adicionar(T entidade)
        {
            Lista.Add(entidade);
        }

        public virtual void Editar(T entidade)
        {
        }

        public void Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void ExcluirLista(int[] ids)
        {
            //TODO
        }

        public void Excluir(T entidade)
        {
            Lista.Remove(entidade);
        }

        public void ExcluirTodos()
        {
            foreach (var item in Lista)
                Lista.Remove(item);
        }

        public RepositorioBase<T> Incluir(Expression<Func<T, object>> propriedade)
        {
            _queryable = _queryable.Include(propriedade);
            return this;
        }

        public RepositorioBase<T> Incluir(string propriedade)
        {
            _queryable = _queryable.Include(propriedade);
            return this;
        }

        public RepositorioBase<T> AdicionarRestricao(Expression<Func<T, bool>> restricao)
        {
            _queryable = _queryable.Where(restricao);
            return this;
        }

        public int Count()
        {
            return _queryable.Count();
        }

        public IRepositorioBase<T> Skip(int tamanho)
        {
            _queryable = _queryable.Skip(tamanho);
            return this;
        }

        public IRepositorioBase<T> Take(int tamanho)
        {
            _queryable = _queryable.Take(tamanho);
            return this;
        }

        public T Single()
        {
            T entidade = _queryable.Single();
            _queryable = Contexto.Set<T>();
            return entidade;
        }

        public T SingleOrDefault()
        {
            T entidade = _queryable.SingleOrDefault();
            _queryable = Contexto.Set<T>();
            return entidade;
        }

        public T First()
        {
            T entidade = _queryable.First();
            _queryable = Contexto.Set<T>();
            return entidade;
        }

        public T FirstOrDefault()
        {
            T entidade = _queryable.FirstOrDefault();
            _queryable = Contexto.Set<T>();
            return entidade;
        }

        public IList<T> ToList()
        {
            List<T> entidades = _queryable.ToList();
            _queryable = Contexto.Set<T>();
            return entidades;
        }
    }
}
