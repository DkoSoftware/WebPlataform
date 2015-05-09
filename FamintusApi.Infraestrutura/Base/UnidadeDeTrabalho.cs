using System;
using System.Collections.Generic;
using FamintusApi.Dominio.Base;

namespace FamintusApi.Infraestrutura.Base
{
    public class UnidadeDeTrabalho : IUnidadeDeTrabalho
    {
        private readonly Contexto _contexto;

        public UnidadeDeTrabalho(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Persistir()
        {
            try
            {
                _contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}