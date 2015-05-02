using FamintusApi.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace FamintusApi.Repositorios
{
    public static class PopuladorDados
    {
        public static IDictionary<Type, IList> ObterDados()
        {
            return new Dictionary<Type, IList>() 
            {
                { typeof(LojaModel), ObterLojas() },
                { typeof(ProdutoModel), ObterProdutos() }
            };
        }

        public static List<LojaModel> ObterLojas()
        {
            return new List<LojaModel> 
            {
                new LojaModel
                {
                    Id = 1,
                    Nome = "Petiskeira",
                    Endereco = "Rua das alfazemas",
                    Foto = "http://www.petiskeira.com.br/assets/images/layout/logo.png"
                }
            };
        }

        public static List<ProdutoModel> ObterProdutos()
        {
            //Obs.: Pegar outras imagens de: http://www.petiskeira.com.br/assets/images/content/cardapio/

            return new List<ProdutoModel> 
            {
                new ProdutoModel
                {
                    Id = 5751,
                    IdLoja = 1,
                    Nome = "Massa aos 4 Queijos Crocante",
                    Descricao = "Espaguete ou talharim com nosso delicioso molho de quatro queijos. Acompanha nosso delicioso frango crocante.",
                    Imagem = "http://www.petiskeira.com.br/assets/images/content/cardapio/5751.png"
                },
                new ProdutoModel
                {
                    Id = 5752,
                    IdLoja = 1,
                    Nome = "Talharim à Payard Crocante",
                    Descricao = "Massa talharim com um cremoso molho à base de nata e tirinhas de presunto. Acompanha nosso delicioso frango crocante.",
                    Imagem = "http://www.petiskeira.com.br/assets/images/content/cardapio/5752.png"
                },
                new ProdutoModel
                {
                    Id = 5753,
                    IdLoja = 1,
                    Nome = "Frango Supreme",
                    Descricao = "Massa penne ao molho cremoso e levemente apimentado à base de nata, cogumelos frescos, pimentões e especiarias. Acompanha nosso delicioso frango crocante.",
                    Imagem = "http://www.petiskeira.com.br/assets/images/content/cardapio/5753.png"
                }
            };
        }
    }
}