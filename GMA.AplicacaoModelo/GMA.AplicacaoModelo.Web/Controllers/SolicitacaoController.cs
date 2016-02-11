using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;
using GMA.AplicacaoModelo.Dominio.Repositorios;
using GMA.AplicacaoModelo.Web.Models;

namespace GMA.AplicacaoModelo.Web.Controllers
{
    public class SolicitacaoController : ApiController
    {
     private ISolicitacaoReposotorio _solicitacaoReposotorio;


     public SolicitacaoController(ISolicitacaoReposotorio solicitacaoReposotorio)
     {
      _solicitacaoReposotorio = solicitacaoReposotorio;
     }

     //TODO so teste!!!
     [Route("api/v1/solicitacoes")]
     [HttpGet]
     public string[] ObterListaSolicitacao()
     {



      return _solicitacaoReposotorio.ObterListaSolicitacao();
     }
    }
}
