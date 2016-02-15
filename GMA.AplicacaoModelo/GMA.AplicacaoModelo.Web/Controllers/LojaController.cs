using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GMA.AplicacaoModelo.Dominio.Entidades;
using GMA.AplicacaoModelo.Dominio.Repositorios;
using GMA.AplicacaoModelo.Web.Models;
using GMA.AplicacaoModelo.Web.Servicos;

namespace GMA.AplicacaoModelo.Web.Controllers
{
    public class LojaController : ApiController
    {

     private LojaServico _lojaServico;



     public LojaController(LojaServico lojaServico)
     {
      _lojaServico = lojaServico;
     }
     
     //TODO Fazer teste unitario
     
     [Route("api/v1/lojas")]
     [HttpGet]
     public HttpResponseMessage  ObterListaLoja()
     {
       var ret=_lojaServico.ObterListaLoja();
      
       //TODO alterar para tratar erros
       return Request.CreateResponse(HttpStatusCode.OK, ret);

     }


   
     [Route("api/v1/lojas")]
     [HttpPost]
     public HttpResponseMessage NovaLoja([FromBody ]LojaViewModel lojaViewModel)
     {

      if (lojaViewModel == null) return Request.CreateResponse(HttpStatusCode.BadRequest, new String[] { "Valor Loja Invalido" });


      _lojaServico.NovaLoja(lojaViewModel);
      
      return Request.CreateResponse(HttpStatusCode.OK);
     }
     
    }
}
