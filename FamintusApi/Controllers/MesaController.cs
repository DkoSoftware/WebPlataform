using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FamintusApi.Controllers
{
    [RoutePrefix("api/mesa/{id:int:min(1)}")]
    public class MesaController : ApiController
    {
        [Route("")]
        public HttpResponseMessage PostAbrir(Int32 id)
        {
            //TODO: Criar comanda virtual e retornar o id.

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}