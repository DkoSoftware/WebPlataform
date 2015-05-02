using FamintusApi.Models;
using FamintusApi.Repositorios.Produto;
using FamintusApi.Servicos.Produto;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FamintusApi.Controllers
{
    [RoutePrefix("api/produto")]
    public class ProdutoController : ApiController
    {
        private readonly IProdutoRepositorio produtoRepo;
        private readonly IProdutoServico produtoServ;

        public ProdutoController(IProdutoRepositorio produtoRepo, IProdutoServico produtoServ)
        {
            if (produtoRepo == null)
                throw new ArgumentNullException("produtoRepo");
            if (produtoServ == null)
                throw new ArgumentNullException("produtoServ");

            this.produtoRepo = produtoRepo;
            this.produtoServ = produtoServ;
        }

        [Route("{id:int:min(1)}")]
        public ProdutoModel Get(Int32 id)
        {
            return produtoRepo.ObterPeloId(id);
        }

        [Route("")]
        public HttpResponseMessage Post(ProdutoModel produto)
        {
            produtoServ.Adicionar(produto);

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
            produtoServ.Atualizar(produto);

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
            var produto = new ProdutoModel { Id = id };

            produtoServ.Remover(produto);

            var result = new
            {
                message = "Removido com sucesso",
                erro = false
            };

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}