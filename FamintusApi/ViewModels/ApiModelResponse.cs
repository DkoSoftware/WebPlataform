using System;

namespace FamintusApi.ViewModels
{
    /// <summary>
    /// Especifica um modelo comum de resposta às operações da api web.
    /// </summary>
    public class ApiModelResponse
    {
        public Int32 Id { get; set; }

        public String Mensagem { get; set; }

        public Boolean Erro { get; set; }
    }
}