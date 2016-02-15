using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMA.AplicacaoModelo.Dominio.Entidades;
using GMA.AplicacaoModelo.Dominio.Repositorios;
using GMA.AplicacaoModelo.Infra.Db.Entity;

namespace GMA.AplicacaoModelo.Infra.Bd.Entity.RepositorioImpl
{
 internal class LojaRepositorio :ILojaRepositorio
 {
  private VendaContext _context;

  public LojaRepositorio(VendaContext context)
  {
   _context = context;
  }

  public IEnumerable<Loja> ObterListaLoja()
  {
   return _context.Lojas.ToList();
  }


  public void Salvar(Loja loja)
  {
   _context.Lojas.Add(loja);
   _context.SaveChanges();
  }

  public Loja ObterPorId(int lojaId)
  {
   return _context.Lojas.Find(lojaId);
  }


 }
}
