using FamintusApi.Models;
using FamintusApi.Repositorios.Loja;
using FamintusApi.Repositorios.Produto;
using System;
using System.Web.Http;

namespace FamintusApi.Controllers
{
    [RoutePrefix("api/loja/{id:int:min(1)}")]
    public class LojaController : ApiController
    {
        private readonly ILojaRepositorio lojaRepo;
        private readonly IProdutoRepositorio produtoRepo;

        public LojaController(ILojaRepositorio lojaRepo, IProdutoRepositorio produtoRepo)
        {
            if (lojaRepo == null)
                throw new ArgumentNullException("lojaRepo");
            if (produtoRepo == null)
                throw new ArgumentNullException("produtoRepo");

            this.lojaRepo = lojaRepo;
            this.produtoRepo = produtoRepo;
        }

        [Route("")]
        public LojaModel GetInfo(Int32 id)
        {
            return this.lojaRepo.ObterPeloId(id);
        }

        [Route("menu")]
        public ProdutoModel[] GetMenu(Int32 id)
        {
            return this.produtoRepo.ObterDaLoja(id);
        }
    }
}