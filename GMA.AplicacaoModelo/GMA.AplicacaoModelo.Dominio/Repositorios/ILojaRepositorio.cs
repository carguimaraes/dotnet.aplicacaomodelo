using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMA.AplicacaoModelo.Dominio.Entidades;

namespace GMA.AplicacaoModelo.Dominio.Repositorios
{
  public interface ILojaRepositorio
  {

   IEnumerable<Loja> ObterListaLoja();

   void Salvar(Loja loja);
   Loja ObterPorId(int lojaId);


  }
}
