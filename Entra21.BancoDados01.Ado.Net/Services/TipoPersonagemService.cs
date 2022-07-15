using Entra21.BancoDados01.Ado.Net.DataBase;
using Entra21.BancoDados01.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal class TipoPersonagemService : ITipoPersonagemService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM tipos_perosnagens Whres id = " + id;

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(TipoPersonagem tipoPersonagem)
        {
            //sera descrito a implementacao do contrato defonoido na interface    

            //criado conexao com o banco de dados 
            var conexao = new Conexao().Conectar();

            //criar o comando para executar no banco de dados
            SqlCommand comando = conexao.CreateCommand();

            //especificando o comando que sera executado
            comando.CommandText = "INSERT INTO tipos_personagens (tipo) VALUES ( ' " +
                tipoPersonagem.Tipo + "')";

            //executando o comando de insert na tabela de tipos persnagens
            comando.ExecuteNonQuery();

            conexao.Close();

        }

        public List<TipoPersonagem> ObterTodos()
        {
            
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, tipo FROM tipos_personagens";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var tiposPersonagens = new List<TipoPersonagem>();

            for (int i = 0; i< tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];

                var tipoPersonagem = new TipoPersonagem();
                tipoPersonagem.Id = Convert.ToInt32(linha["id"].ToString());
                tipoPersonagem.Tipo = linha["tipo"].ToString();

                tiposPersonagens.Add(tipoPersonagem);
            }

            comando.Connection.Close();
            return tiposPersonagens;

        }

    }

   

    
          
                   

         
}

   
