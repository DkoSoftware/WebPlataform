using System;

namespace FamintusApi.Models
{
    public class ComandaModel : IModel
    {
        public Int32 Id { get; set; }

        public Int32 IdLoja { get; set; }

        public Int32 IdMesa { get; set; }

        public Int32 IdUsuario { get; set; }

        public DateTime Criacao { get; set; }

        public DateTime Encerramento { get; set; }
    }
}