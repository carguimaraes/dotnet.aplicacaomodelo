using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GMA.AplicacaoModelo.Dominio.Entidades;
using GMA.AplicacaoModelo.Dominio.Repositorios;
using GMA.AplicacaoModelo.Web.Models;

namespace GMA.AplicacaoModelo.Web.Servicos
{
 public class LojaServico
 {
  private IUnitOfWork _uwk;

  public LojaServico(IUnitOfWork uwk )
  {
   _uwk = uwk;
  }

  //TODO imp dispose

  //TODO fazer teste unitario
  public virtual List<LojaViewModel> ObterListaLoja()
  {

   var lista=_uwk.Repositorio<ILojaRepositorio>().ObterListaLoja().ToList();
   var listaVwM= new  List<LojaViewModel>(); 

   foreach (var item in lista)
	  {
		   listaVwM.Add( new LojaViewModel {Id=item.Id, Nome=item.Nome});
	  }


   return listaVwM;
  }

  //Fazer teste unitario
  public virtual void NovaLoja(LojaViewModel lojaViewModel)
  {

   //TODO erros nao estao sendo tratado
   var loja = new Loja { Nome = lojaViewModel.Nome};
   
   _uwk.Repositorio<ILojaRepositorio>().Salvar(loja);

   
  }


 }
}