using FamintusApi.Models;
using System;
using System.Web.Http;

namespace FamintusApi.Controllers
{
    [RoutePrefix("api/loja/{id:int:min(1)}")]
    public class LojaController : ApiController
    {
        [Route("")]
        public LojaModel GetInfo(Int32 id)
        {
            return new LojaModel
            {
                Id = 1,
                Nome = "Petiskeira",
                Endereco = "Rua das alfazemas",
                Foto = "http://www.petiskeira.com.br/assets/images/layout/logo.png"
            };
        }

        [Route("menu")]
        public ProdutoModel[] GetMenu(Int32 id)
        {
            return new[]
            {
                new ProdutoModel
                {
                    Id = 5751,
                    Nome = "Massa aos 4 Queijos Crocante",
                    Descricao = "Espaguete ou talharim com nosso delicioso molho de quatro queijos. Acompanha nosso delicioso frango crocante.",
                    Imagem = "http://www.petiskeira.com.br/assets/images/content/cardapio/5751.png"
                },
                new ProdutoModel
                {
                    Id = 5752,
                    Nome = "Talharim à Payard Crocante",
                    Descricao = "Massa talharim com um cremoso molho à base de nata e tirinhas de presunto. Acompanha nosso delicioso frango crocante.",
                    Imagem = "http://www.petiskeira.com.br/assets/images/content/cardapio/5752.png"
                },
                new ProdutoModel
                {
                    Id = 5753,
                    Nome = "Frango Supreme",
                    Descricao = "Massa penne ao molho cremoso e levemente apimentado à base de nata, cogumelos frescos, pimentões e especiarias. Acompanha nosso delicioso frango crocante.",
                    Imagem = "http://www.petiskeira.com.br/assets/images/content/cardapio/5753.png"
                }
            };
        }
    }
}