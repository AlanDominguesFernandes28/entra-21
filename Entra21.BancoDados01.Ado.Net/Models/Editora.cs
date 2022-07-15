using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Models
{
    internal class Editora
    {
        // Oque e get set sera apresentado posteriormente
        public int id { get; set; }
        public string Nome { get; set; }
        public decimal Faturamento { get; set; }

        public DateTime  DataCriacao { get; set; }
        public string Apelido { get; set; }
    }
}
