using Entra21.BancoDados01.Ado.Net.DataBase;
using Entra21.BancoDados01.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal interface ITipoPersonagemService
    {
        public void Apagar(int id);
       public  void Cadastrar(TipoPersonagem tipoPersonagem);

        List<TipoPersonagem> ObterTodos();

    }
}
