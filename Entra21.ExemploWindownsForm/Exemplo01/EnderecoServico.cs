using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemploWindownsForm.Exemplo01
{
    internal class EnderecoServico
    {
        private List<Endereco> enderecos;

        //contrutor 
        public EnderecoServico()
        {
            enderecos = new List<Endereco>();
        }

        // metodo adicionar recebe como parametro o objeto do endereco completo do form(controller)
        public void Adicionar(Endereco endereco)
        {
            enderecos.Add(endereco);

            salvarArquivo();
        }

        public void Editar(Endereco enderecoParaAlterar)
        {
            //percorre a lista de endereco afim de encontrar o endereco que deve ser alterado
            for (int i = 0; i < enderecos.Count; i++)
            {
                //obtem o endereco da lista de enderecos
                var endereco = enderecos[i];
                //verificar se o codigo do endereco percorrido e o mesmo do endereco que deve ser alterado
                if (endereco.Codigo == enderecoParaAlterar.Codigo)
                {
                    //atualiza campos do endereco encontrado
                    endereco.EnderecoCompleto = enderecoParaAlterar.EnderecoCompleto;
                    endereco.Cep = enderecoParaAlterar.Cep;
                    endereco.Paciente = enderecoParaAlterar.Paciente;

                    SalvarArquivio();
                }

            }
            public void Apagar(int codigoParaApagar)
            {
                for (int i = 0; i < enderecos.Count; i++)
                {
                    // obtem o endereco percorrifo
                    var endereco = enderecos[i];

                    if (endereco.Codigo == codigoParaApagar)
                    {
                        //remove o endereco encontrado da lista enderecos
                        enderecos.Remove(endereco);

                        SalvarArquivo();

                        return;
                    }

                }
            }
            //metodo que permite listar todos os enderecos
            public List<Endereco> ObterTodos()
            {
                return enderecos;
            }
            public Endereco ObterPorCodigo(int codigo)
            {
                for (int i = 0; i < enderecos.Count; i++)
                {
                    var endereco = enderecos[i];

                    if (endereco.Codigo == codigo)
                        return endereco;
                }
                return null;
            }
            public void SalvarArquivo()
            {
                var enderecosEmJson = JsonConvert.SerializeObject(enderecos);
                File.WriteAllText("enderecos.json", enderecosEmJson);
            }
            public void LerArquivo()
            {
                //verifica se o enderco nao existe
                if (File.Exists("enderecos.json") == false)
                    return;
                //ler o arquivo json e convert para uma lista de objetos de endereco
                var enderecosEmJson = File.ReadAllText("enderecos.json");
                enderecos = JsonConvert.DeserializeObject<List,Enereco >> (enderecosEmJson);
            }



        }


    }
}
