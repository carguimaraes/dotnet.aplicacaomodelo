
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GMA.AplicacaoModelo.Web.Controllers;
using GMA.AplicacaoModelo.Web.Models;
using GMA.AplicacaoModelo.Web.Servicos;
using Moq;
using NUnit.Framework;
namespace GMA.AplicacaoModelo.TesteUnitario.Web
{
 [TestFixture]
 public class LojaControllerTeste
 {
  private LojaController _lojaController;
  private Mock<LojaServico> _lojaServicoMock = new Mock<LojaServico>(MockBehavior.Strict);


  [SetUp]
  public void Init()
  {
   _lojaController = new LojaController(_lojaServicoMock.Object)
   {
    Request = new HttpRequestMessage { RequestUri = new Uri("http://localhost/") },
    Configuration = new HttpConfiguration()

   };
  }


  [Test]
  public void ObterListaLoja_Sucesso()
  {
   _lojaServicoMock.Setup(o => o.ObterListaLoja())
     .Returns(new List<LojaViewModel> { new LojaViewModel { Id = 1, Nome = "NOME 01" } }

     );

    

   var response = _lojaController.ObterListaLoja();
   var servicoRetorno = (response.Content as ObjectContent).Value as List<LojaViewModel>;

   var listaLojaModel = servicoRetorno;
   var lojaModel = listaLojaModel.ToArray()[0];
    
   Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
   Assert.AreEqual(lojaModel.Nome,"NOME 01");



  }
 }
}
