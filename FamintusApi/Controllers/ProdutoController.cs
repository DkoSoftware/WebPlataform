using FamintusApi.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FamintusApi.Controllers
{
    [RoutePrefix("api/produto")]
    public class ProdutoController : ApiController
    {
        [Route("{id:int:min(1)}")]
        public ProdutoModel Get(Int32 id)
        {
            //Obs.: Pegar outras imagens de: http://www.petiskeira.com.br/assets/images/content/cardapio/

            return new ProdutoModel 
            {
                Id = 1,
                Nome = "Frango Supreme",
                Descricao = "Massa penne ao molho cremoso e levemente apimentado à base de nata, cogumelos frescos, pimentões e especiarias. Acompanha nosso delicioso frango crocante.",
                Imagem = "http://www.petiskeira.com.br/assets/images/content/cardapio/5753.png"
            };
        }

        [Route("")]
        public HttpResponseMessage Post(ProdutoModel produto)
        {
            //TODO: Validar e cadastrar produto.
            produto.Id = (new Random()).Next(1, 100000);

            var result = new 
            {
                id = produto.Id,
                message = "Criado com sucesso",
                erro = false
            };

            var response = Request.CreateResponse(HttpStatusCode.Created, result);
            return response;
        }

        [Route("")]
        public HttpResponseMessage Put(ProdutoModel produto)
        {
            //TODO: Validar e atualizar produto.

            var result = new
            {
                id = produto.Id,
                message = "Atualizado com sucesso",
                erro = false
            };

            return Request.CreateResponse(HttpStatusCode.Created, result);
        }

        [Route("{id:int:min(1)}")]
        public HttpResponseMessage Delete(Int32 id)
        {
            //TODO: Validar e deletar produto.

            var result = new
            {
                message = "Removido com sucesso",
                erro = false
            };

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}