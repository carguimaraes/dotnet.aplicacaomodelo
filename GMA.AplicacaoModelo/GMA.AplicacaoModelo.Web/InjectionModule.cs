using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GMA.AplicacaoModelo.Web.Servicos;
using Ninject.Modules;

namespace GMA.AplicacaoModelo.Web
{
 public class InjectionModule : NinjectModule
 {

  public override void Load()
  {
   Bind<LojaServico>().ToSelf();
  }
 } 
}