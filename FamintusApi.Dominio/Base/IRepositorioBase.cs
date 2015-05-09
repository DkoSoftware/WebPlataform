using System;
using System.Collections.Generic;

namespace FamintusApi.Dominio.Base
{
    public interface IRepositorioBase<T> where T: IRaizDeAgregacao
    {
        T ObterPorId(Guid id);

        T ObterPorId(int id);

        void Adicionar(T entidade);

        void Editar(T entidade);

        void Excluir(Guid id);

        void Excluir(int id);

        void ExcluirLista(int[] ids);

        void Excluir(T entidade);

        void ExcluirTodos();

        int Count();

        IRepositorioBase<T> Skip(int tamanho);

        IRepositorioBase<T> Take(int tamanho);

        T Single();

        T SingleOrDefault();

        T First();

        T FirstOrDefault();

        IList<T> ToList();
    }
}
