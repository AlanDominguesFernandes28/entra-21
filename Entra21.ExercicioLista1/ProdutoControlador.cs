using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExercicioLista1
{
    internal class ProdutoControlador
    {
        private ProdutoServico produtoServico = new ProdutoServico();
        private string nome;

        public void GerenciarMenu()
        {
            int codigo = 0;
            //repete enquanto o codigo nao for o menu sair(6)
            while (codigo != 6)
            {
                Console.Clear();
                // apresentar o menu e solicitar o codigo
                codigo = ApresentarSolicitarMenu();

                if (codigo == 1)
                {
                    //menu escolhido para listar produtos
                    ApresentarProdutos();
                }
                else if (codigo == 2)
                {
                    //menu escolhido para cadastrar produto
                    Cadastrar();
                }
                else if (codigo == 3)
                {
                    //menu escolhido para editar produto
                    Editar();
                }
                else if (codigo == 4)
                {
                    Apagar();
                }
                else if (codigo == 5)
                {
                    //apresentarProduto();
                }
                Thread.Sleep(1000);
            }

        }
        private void Apagar()
        {
            ApresentarProdutos();

            Console.WriteLine("Digite o Codigo do produto para apagar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var registroApagado = produtoServico.Apagar(codigo);
            Console.WriteLine(registroApagado == true
                                                ? " Registro removido com sucesso"
                                                : " nenhum produto cadastrado com o codigo informado");

        }
        private void ApresentarProduto()
        {
            ApresentarProdutos();

            Console.Write("Digite o codigo do produto a ser detalhado: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var produto = produtoServico.ObterPorCodigo(codigo);

            // verifica se o produto nao esta cadastrado na lista de produtos
            if (produto == null)
            {
                Console.WriteLine("Produto nao esta cadastrado");
                return;
            }
            Console.Clear();
            Console.WriteLine($@"Codigo: { produto.Codigo}
            Nome: { produto.Nome}
            Preco Unitario: { produto.PrecoUnitario}
            Quantidade: { produto.Quantidade}
            Total: { produto.CalcularPrecoTotal}");

        }
        private void Editar()
        {
            ApresentarProdutos();

            Console.WriteLine("Codigo produto desejado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preco Unitario: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@" localizacoes disponiveis: - Armazem 
                                                           - area venda 
                                                           - loja");


            Console.Write("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            var alterou = produtoServico.Editar(codigo, nome, precoUnitario, localizacaoProduto, quantidade);

            if (alterou == false)
            {
                Console.WriteLine("Codigo digitado nao existe");
            }
            else
            {
                Console.WriteLine("Produto alterado com sucesso");
            }


        }

        private int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@" Menu:
             1- Listar todos
             2- Cadastrar
             3- Editar
             4- Apagar
             5-Apresentar produto desejado
             6-Sair");

            int codigo = SolicitarCodigo();
            return codigo;
        }
        private int SolicitarCodigo()
        {
            int codigo = 0;
            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.Write("Digite o codigo: ");
                    codigo = Convert.ToInt32(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine(" Digite um menu valido");
                }
            }
            return codigo;
        }


        private void Cadastrar()
        {
            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preco Unitario: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@" localizacoes disponiveis: - Armazem 
                                                           - area venda 
                                                           - loja");



            Console.Write("Localizacao: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            produtoServico.Adicionar(nome, precoUnitario, localizacaoProduto, quantidade);



        }

        private ProdutoLocalizacao ObterLocalizacaoProduto(string localizacao)
        {
            if (localizacao.ToLower() == "armazem")
            {
                return ProdutoLocalizacao.Armazem;
            }
            else if (localizacao.ToLower() == "loja")
            {
                return ProdutoLocalizacao.Loja;
            }
            else
            {
                return ProdutoLocalizacao.AreaVenda;

            }
        }
        private void ApresentarProdutos()
        {
            var produtos = produtoServico.ObterTodos();

            if (produtos.Count == 0)
            {
                Console.WriteLine("nenhum produti cadastrado :(");
                //para a execucao deste metodo

                return;
            }

            Console.WriteLine("lista de produtos");

            for (var i = 0; i < produtos.Count; i++)
            {
                var produtoAtual = produtos[i];


                Console.WriteLine(
                    "\nCodigo: " + produtoAtual.Codigo +
                    "\nNome: " + produtoAtual.Nome + "\n");

            }


        }

    }
}
