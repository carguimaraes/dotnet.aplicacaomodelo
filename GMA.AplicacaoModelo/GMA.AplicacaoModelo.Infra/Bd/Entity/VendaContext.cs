using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMA.AplicacaoModelo.Dominio.Entidades;
using GMA.AplicacaoModelo.Infra.Bd.Entity.Map;

namespace GMA.AplicacaoModelo.Infra.Db.Entity 
{
 public class VendaContext :  DbContext
 {
  public DbSet<Loja> Lojas { get; set; }

  public VendaContext(): base("CnxVenda")
  {
  }



  protected override void OnModelCreating(DbModelBuilder modelBuilder)
  {
   
    base.OnModelCreating(modelBuilder);

    modelBuilder.Configurations.Add(new LojaEntityConfiguration());
  

  }
 }
}
