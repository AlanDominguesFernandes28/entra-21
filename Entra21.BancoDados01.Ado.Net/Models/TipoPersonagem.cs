using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Models
{
    internal class TipoPersonagem
    {
        public int id { get; set; }
        public object Id { get; internal set; }
        public string Tipo { get; set; }
    }
}
