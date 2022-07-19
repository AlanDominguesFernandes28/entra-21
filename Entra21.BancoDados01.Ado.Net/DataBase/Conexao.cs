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
            // Instanciando um objeto da classe SqlConnection
            // que permitirá fazer selects, inserts, updates, deletes, etc.
            SqlConnection conexao = new SqlConnection();

            // string que contém o caminho para o banco de dados, o 
            // que permititra conectar ao banco de dados
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Server\c#-noturno\alan.fernandes\Documents\ExemploBancoDados01AdoNet.mdf;Integrated Security=True;Connect Timeout=30";

            // Definir o caminho da conexão para o SqlConnection
            conexao.ConnectionString = connectionString;

            // Abrir a conexao com o banco de dados
            conexao.Open();

            return conexao;
        }
    }
}
