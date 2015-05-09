using FamintusApi.Dominio.Base;
using FamintusApi.Dominio.Entidades;
using FamintusApi.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FamintusApi.Repositorios
{
    public class FamintusMemoryContext : IFamintusDataContext
    {
        private static readonly Object locker = new Object();
        private readonly IDictionary<Type, IList> dados;

        public FamintusMemoryContext(IDictionary<Type, IList> dados)
        {
            if (dados == null)
                throw new ArgumentNullException("dados");

            this.dados = dados;
        }

        public IQueryable<LojaModel> Lojas
        {
            get { return ObterLista<LojaModel>().AsQueryable(); }
        }

        public IQueryable<ProdutoModel> Produtos
        {
            get { return ObterLista<ProdutoModel>().AsQueryable(); }
        }

        public IQueryable<ComandaModel> Comandas
        {
            get { return ObterLista<ComandaModel>().AsQueryable(); }
        }

        public void Adicionar<T>(T modelo) where T : class, IModel
        {
            var lista = ObterLista<T>();
            lock (locker)
            {
                if (lista.Any(m => m.Id == modelo.Id))
                    lista.RemoveAll(m => m.Id == modelo.Id);
                lista.Add(modelo);
            }
        }

        public void Remover<T>(T modelo) where T : class, IModel
        {
            var lista = ObterLista<T>();
            lock (locker)
            {
                lista.RemoveAll(m => m.Id == modelo.Id);
            }
        }

        public void AplicarAlteracoes() { }

        private List<T> ObterLista<T>()
        {
            var tipo = typeof(T);
            if (!this.dados.ContainsKey(tipo))
            {
                this.dados.Add(tipo, new List<T>());
            }

            return (List<T>)this.dados[tipo];
        }
    }
}