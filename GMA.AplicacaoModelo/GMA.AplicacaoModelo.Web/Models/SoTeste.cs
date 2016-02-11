using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GMA.AplicacaoModelo.Dominio.Repositorios;

namespace GMA.AplicacaoModelo.Web.Models
{
 public class SoTeste : ISolicitacaoReposotorio
 {
  
  public string[] ObterListaSolicitacao()
  {
   return new string[] { "nome 01", "nome 02", "nome 03", "nome 04", "nome 05" };
  }

  
 }
}