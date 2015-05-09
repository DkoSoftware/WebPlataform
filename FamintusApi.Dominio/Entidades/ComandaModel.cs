using System;
using FamintusApi.Dominio.Base;

namespace FamintusApi.Dominio.Entidades
{
    public class ComandaModel : IRaizDeAgregacao
    {
        public Guid Id { get; set; }

        public Int32 IdLoja { get; set; }

        public Int32 IdMesa { get; set; }

        public Int32 IdUsuario { get; set; }

        public DateTime Criacao { get; set; }

        public DateTime Encerramento { get; set; }
    }
}