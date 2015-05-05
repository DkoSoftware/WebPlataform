using FamintusApi.Models;
using FamintusApi.Repositorios.Loja;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;

namespace FamintusApi.Tests.Repositorios
{
    [TestClass]
    public class LojaRepositorioTest
    {
        [TestMethod]
        public void Dado_3_lojas_quando_obter_produto_pelo_id_2_deve_retornar_produto()
        {
            var contextoMock = new Mock<IFamintusDataContext>();
            contextoMock.SetupGet(c => c.Lojas)
                .Returns(() => new[]
                {
                    new LojaModel { Id = 1 },
                    new LojaModel { Id = 2 },
                    new LojaModel { Id = 3 }
                }.AsQueryable());

            var repo = new LojaRepositorio(contextoMock.Object);
            var loja = repo.ObterPeloId(3);

            loja.Should().NotBeNull();
            loja.Id.Should().Be(3);
        }
    }
}