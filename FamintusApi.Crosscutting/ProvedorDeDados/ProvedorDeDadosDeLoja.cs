using System;
using System.Collections.Generic;
using FamintusApi.Dominio.Entidades;

namespace FamintusApi.Crosscutting.ProvedorDeDados
{
    public class ProvedorDeDadosDeLoja
    {
        public static List<LojaModel> ObterLojas(int quantidade)
        {
            var lojas = new List<LojaModel>();
            for (int i = 0; i < quantidade; i++)
            {
                lojas.Add(new LojaModel
                {
                    Id = new Guid(),
                    Nome = "Petiskseira",
                    Endereco = "Rua das alfazemas",
                    Foto = "http://www.petiskeira.com.br/assets/images/layout/logo.png"
                }); 
            }
            
            return lojas;
        } 
    }
}