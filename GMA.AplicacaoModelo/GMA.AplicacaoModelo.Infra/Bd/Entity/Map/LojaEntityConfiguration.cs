using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMA.AplicacaoModelo.Dominio.Entidades;

namespace GMA.AplicacaoModelo.Infra.Bd.Entity.Map
{
 internal class LojaEntityConfiguration : EntityTypeConfiguration<Loja>
 {

  public LojaEntityConfiguration()
  {
   this.ToTable("LOJA_TB");

   this.Property(p => p.Id).HasColumnName("LOJA_ID");
   this.HasKey<long>(o => o.Id);

   this.Property(p => p.Nome).HasColumnName("NOME").HasMaxLength(30).IsRequired();
   
  }

 }
}
