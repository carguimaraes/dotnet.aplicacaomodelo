using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMA.AplicacaoModelo.Dominio.Repositorios;
using GMA.AplicacaoModelo.Infra.Bd.Entity;
using GMA.AplicacaoModelo.Infra.Bd.Entity.RepositorioImpl;
using Ninject;

namespace GMA.AplicacaoModelo.Infra
{
 public class Map
 {
  public static void SetMap(IKernel kernel)
  {

   kernel.Bind<IUnitOfWork>().To<UnitOfWork>();

  // kernel.Bind<ILojaRepositorio>().To<LojaRepositorio>();

  }
 }
}
