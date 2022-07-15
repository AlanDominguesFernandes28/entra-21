using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.DataBase
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {
            //instanciado um objeto da classe sqlconnection que peritira fazer selects,inserts,deletes
            SqlConnection conexao = new SqlConnection();

            //string que contem o caminho para o banco de dados,oq ue permitira conectar ao banco de dados
            //server explorer,propriedades e copia e cola aqui
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Server\c#-noturno\alan.fernandes\Documents\ExemploBancoDados01AdoNet.mdf;Integrated Security=True;Connect Timeout=30";

            //definir ocaminho da conexao para o sqlconnection
            conexao.ConnectionString = connectionString;

            //abrir a conexao com o banco de dados
            conexao.Open();

            return conexao;
        }

        
    }
}
