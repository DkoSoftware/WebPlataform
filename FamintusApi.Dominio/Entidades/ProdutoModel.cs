using System;
using FamintusApi.Dominio.Base;

namespace FamintusApi.Dominio.Entidades
{
    public class ProdutoModel : IRaizDeAgregacao
    {
        public Guid Id { get; set; }

        public String Nome { get; set; }

        public String Imagem { get; set; }

        public String Descricao { get; set; }

        public Int32 IdLoja { get; set; }
        
    }
}