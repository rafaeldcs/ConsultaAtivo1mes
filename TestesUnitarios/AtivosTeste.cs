using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using testeVariacaoAtivo.Models;
using testeVariacaoAtivo.Services;
using testeVariacaoAtivo.Services.Interface;
using Assert = NUnit.Framework.Assert;

namespace TestesUnitarios
{
    [TestClass]
    public class AtivosTeste
    {
        [TestMethod]
        public void NaoTrazAtivoSeNaoExistir()
        {
            //Arrange
            string ativo = "petr4";
            var _service = new Mock<AtivoService>();
            _service.Setup(x => x.BuscarAtivos(ativo));


            //Act
            var ativos = _service.Object.BuscarAtivos(ativo);

            //Assert
            Assert.Equals(0,ativos.Count);
        }
    }
}