using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GMA.AplicacaoModelo.Dominio.Entidades;
using GMA.AplicacaoModelo.Dominio.Repositorios;

namespace GMA.AplicacaoModelo.Web.Controllers
{
    public class LojaController : ApiController
    {

     private ILojaRepositorio _lojaRepositorio;

     public LojaController(ILojaRepositorio  repo)
     {
      _lojaRepositorio = repo;
     }



     //TODO so teste!!!
     [Route("api/v1/lojas")]
     [HttpGet]
     public string[] ObterListaSolicitacao()
     {

    
      var loja = new Loja { Nome = "Teste GMA Loja01" };

      _lojaRepositorio.Salvar(loja);



      return new string[] { "feito" };
     }
    }
}
