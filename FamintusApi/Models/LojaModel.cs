using System;

namespace FamintusApi.Models
{
    public class LojaModel : IModel
    {
        public Int32 Id { get; set; }
        
        public String Nome { get; set; }

        public String Endereco { get; set; }

        public String Foto { get; set; }
    }
}