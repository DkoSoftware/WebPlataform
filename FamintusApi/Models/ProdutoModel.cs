using System;

namespace FamintusApi.Models
{
    public class ProdutoModel : IModel
    {
        public Int32 Id { get; set; }

        public String Nome { get; set; }

        public String Imagem { get; set; }

        public String Descricao { get; set; }

        public Int32 IdLoja { get; set; }
    }
}