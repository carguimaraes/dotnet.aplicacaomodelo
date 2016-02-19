using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMA.AplicacaoModelo.Dominio.Repositorios;
using GMA.AplicacaoModelo.Infra.Bd.Entity.RepositorioImpl;
using GMA.AplicacaoModelo.Infra.Db.Entity;
using Ninject;
using Ninject.Parameters;

namespace GMA.AplicacaoModelo.Infra.Bd.Entity
{
 internal class UnitOfWork : IUnitOfWork 
 {
  private VendaContext _context;
  private Resolver _resolver;
  private readonly  Dictionary<Type, object> _configuredServices = new Dictionary<Type, object>();


  private ILojaRepositorio _lojaRepositorio;

  public UnitOfWork(Resolver resolver)
  //public UnitOfWork()
  {
   _context = new VendaContext();
   _resolver = resolver;
  }
 

  public void Dispose()
  {
   _context.Dispose();
  }

  
  public  T Repositorio<T>() where T : IRepositorio
        {
    
           object obj = null; 
           if ( _configuredServices.ContainsKey(typeof(T)))
           {
                 obj = _configuredServices[typeof(T)];
            }
           else
           {
                obj = _configuredServices[typeof(T)] = _resolver.Get<ILojaRepositorio>(new ConstructorArgument("context", _context));
           }

            return (T) obj;
        }
    

  #region Contrle Transacao


  public void BeginTransaction()
  {
   throw new NotImplementedException();
  }

  public void CommitTransaction()
  {
   throw new NotImplementedException();
  }

  public void RollBackTransaction()
  {
   throw new NotImplementedException();
  }

  #endregion
 }
}
