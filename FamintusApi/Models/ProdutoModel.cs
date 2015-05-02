using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamintusApi.Models
{
    public class ProdutoModel
    {
        public Int32 Id { get; set; }

        public String Nome { get; set; }

        public String Imagem { get; set; }

        public String Descricao { get; set; }
    }
}