using System;
using FamintusApi.Dominio.Base;

namespace FamintusApi.Dominio.Entidades
{
    public class LojaModel : IRaizDeAgregacao
    {
        public Guid Id { get; set; }

        public String Nome { get; set; }

        public String Endereco { get; set; }

        public String Foto { get; set; }
    }
}