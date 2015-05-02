using FamintusApi.Models;
using FamintusApi.Repositorios.Produto;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;

namespace FamintusApi.Tests.Repositorios
{
    [TestClass]
    public class ProdutoRepositorioTest
    {
        [TestMethod]
        public void Dado_3_produto_quando_obter_produto_pelo_id_2_deve_retornar_produto()
        {
            var contextoMock = new Mock<IFamintusDataContext>();
            contextoMock.SetupGet(c => c.Produtos)
                .Returns(() => new[]
                {
                    new ProdutoModel { Id = 1 },
                    new ProdutoModel { Id = 2 },
                    new ProdutoModel { Id = 3 }
                }.AsQueryable());

            var repo = new ProdutoRepositorio(contextoMock.Object);
            var produto = repo.ObterPeloId(2);

            produto.Should().NotBeNull();
            produto.Id.Should().Be(2);
        }

        [TestMethod]
        public void Dado_produtos_de_lojas_distintas_quando_buscar_produtos_pela_loja_2_deve_retornar_dois_produtos()
        {
            var contextoMock = new Mock<IFamintusDataContext>();
            contextoMock.SetupGet(c => c.Produtos)
                .Returns(() => new[]
                {
                    new ProdutoModel { Id = 1, IdLoja = 1 },
                    new ProdutoModel { Id = 2, IdLoja = 2 },
                    new ProdutoModel { Id = 3, IdLoja = 3 },
                    new ProdutoModel { Id = 4, IdLoja = 2 },
                    new ProdutoModel { Id = 5, IdLoja = 1 },
                    new ProdutoModel { Id = 6, IdLoja = 2 }
                }.AsQueryable());

            var repo = new ProdutoRepositorio(contextoMock.Object);
            var produtos = repo.ObterDaLoja(2);

            produtos.Should()
                .NotBeNullOrEmpty().And
                .HaveCount(3);
        }
    }
}