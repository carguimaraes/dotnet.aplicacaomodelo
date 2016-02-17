using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMA.AplicacaoModelo.Infra.Db.Entity;
using Ninject;
using Ninject.Parameters;

namespace GMA.AplicacaoModelo.Infra
{
 public class Resolver
 {
  private IKernel _resolver;

  public Resolver(IKernel kernel)
  {
   _resolver = kernel;
  }

  //TODO Melhorar
  public T Get<T>(ConstructorArgument constructorArgument)
  {
   return _resolver.Get<T>(constructorArgument);
  }
  public T Get<T>()
  {
   return _resolver.Get<T>();
  }

 }

 public interface IResolver : IKernel
 {
 }
}



