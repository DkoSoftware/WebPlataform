using FamintusApi.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FamintusApi.Controllers
{
    [RoutePrefix("api/comanda")]
    public class ComandaController : ApiController
    {
        [Route("")]
        public HttpResponseMessage PostAbrir(ComandaModel comanda)
        {
            //TODO: Criar comanda virtual e retornar o token da comanda.

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("")]
        public HttpResponseMessage PutFechar()
        {
            //TODO: Fechar comanda virtual.

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("")]
        public HttpResponseMessage DeleteCancelar()
        {
            //TODO: Cancelar comanda virtual.

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("produto/{produtoId:int:min(1)}")]
        public HttpResponseMessage PostConsumirProduto(Int32 produtoId)
        {
            //TODO: Consumir produto.

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}