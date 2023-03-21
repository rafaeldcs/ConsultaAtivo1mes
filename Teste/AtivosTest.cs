using Microsoft.Extensions.Configuration;
using Moq;
using Newtonsoft.Json;
using testeVariacaoAtivo.Controllers;
using testeVariacaoAtivo.Models;
using testeVariacaoAtivo.Repositorio;
using testeVariacaoAtivo.Repositorio.Interface;
using testeVariacaoAtivo.Services;
using testeVariacaoAtivo.Services.Interface;
using Xunit;

namespace Teste
{
    public class AtivosTest
    {
        [Fact]
        public void TesteNomeInválidoRetornaListaVaziaPoremNaoRetornaNulo()
        {
            //Arrange
            string ativo = "petr4";
            var mock = new Mock<IAtivoRepository>();
            mock.Setup(x => x.SalvarAtivo(It.IsAny<Ativos>()));

            var service = new AtivoService(mock.Object);

            //Act
            var ativos = service.BuscarAtivos(ativo);

            //Assert
            Assert.Equal(0, ativos.Count);
            Assert.NotNull(ativos);
        }

        [Fact]
        public void TesteNomeVazioRetornaListaVaziaNaoNula()
        {
            //Arrange
            string ativo = "petr4";
            var mock = new Mock<IAtivoRepository>();
            mock.Setup(x => x.SalvarAtivo(It.IsAny<Ativos>()));

            var service = new AtivoService(mock.Object);

            //Act
            var ativos = service.BuscarAtivos(ativo);

            //Assert
            Assert.Equal(0, ativos.Count);
            Assert.NotNull(ativos);
        }

        [Fact]
        public void TesteNomeExistenteDeveRetornarListaDados()
        {
            //Arrange
            string ativo = "PETR4.SA";
            var mock = new Mock<IAtivoRepository>();
            mock.Setup(x => x.SalvarAtivo(It.IsAny<Ativos>()));

            var service = new AtivoService(mock.Object);

            //Act
            var ativos = service.BuscarAtivos(ativo);

            //Assert
            Assert.NotEqual(0,ativos.Count);
            Assert.NotNull(ativos);
        }
    }
}