using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace GMA.AplicacaoModelo.Web.Controllers
{
    public class SolicitacaoController : ApiController
    {

     //TODO so teste!!!
     [Route("api/v1/solicitacoes")]
     [HttpGet]
     public string[] ObterListaSolicitacao()
     {

      return new string[] { "nome 01", "nome 02", "nome 03" };
     }
    }
}
