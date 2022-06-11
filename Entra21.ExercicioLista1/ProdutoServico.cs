namespace Entra21.ExercicioLista1
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();


        // armazenar codigo do proximo produto
        private int codigoAtual = 1;

        // encapsulamento + tiporetorno + nomemetodo
        public void Adicionar(string nome, double precoUnitario,
                              ProdutoLocalizacao localizacao, int quantidade)
        {
            //instanciar um objeto da classe produto
            Produto produto = new Produto();

            // atribuir valor para as propriedades com os dados passados com parametro
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            //atribuir o codigo novo para o objeto do produto
            produto.Codigo = codigoAtual;

            // adicionar 1 no codigo atual para quando criar um novo produto o produto conter outro codigo
            codigoAtual = codigoAtual + 1;


            // adicionar o produto instanciado na lista de produtos
            produtos.Add(produto);

        }

        public bool Editar(int codigoParaAlterar, string nome, double precoUnitario,
                            ProdutoLocalizacao localizacao, int quantidade)
        {

            //obten o produto desejado da lista de produto
            Produto produtoParaAlterar = ObterPorCodigo(codigoParaAlterar);

            //verifica se nao foi possivel encontrar o produto
            if (produtoParaAlterar == null)
            {
                //retorna falso pq nao existe produto com o codigo dos parametros
                return false;


            }
            // atualiza as propriedades (campos) do produto desejado
            produtoParaAlterar.Nome = nome;
            produtoParaAlterar.Localizacao = localizacao;
            produtoParaAlterar.PrecoUnitario = precoUnitario;
            produtoParaAlterar.Quantidade = quantidade;

            // retorna verdadeiro pq foi possivel alterar o produto
            return true;

        }

        public bool Apagar(int codigo)
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                // resgatando de uma lista de tipos primitivos
                //int numero = numeros[i];

                //resgatando de uma lista de objetos
                Produto produto = produtos[i];
                if (produto.Codigo == codigo)
                {
                    //posso remover com o indice do objeto desejado

                    // produtos.RemoveAt(i);

                    //posso remover com o objeto desejado
                    produtos.Remove(produto);
                    //retorna verdadeiro pq o produto com o codigo desejado foi removido da lista
                    return true;

                }

            }
            // retorna falso pq nao foi encontrado produto com o codigo desejado ou seja nenhum 
            //elemnto foi remeovido da lista
            return false;

        }

        public List<Produto> ObterTodos()
        {
            return produtos;

        }
        public Produto ObterPorCodigo(int codigo)
        {
            //percorrer todos os elementos para encontrar o produto
            //filtrando por codigo
            for (int i = 0; i < produtos.Count; i++)
            {
                //obter o produto da lista e produtos em determinado indice
                var produtoAtual = produtos[i];

                //verificar se o produto atual da lista percorrida e po desejado
                if (produtoAtual.Codigo == codigo)
                {
                    //retorna o produto encontrado
                    return produtoAtual;
                }
            }
            //retorna null,caso nao encontre um produto com o codigo passado como parametro
            return null;




        }
        public Produto ObterMenorPrecoUnitario()
        {
            double menorPrecoUnitario = double.MaxValue;
            Produto produtoMenorPrecoUnitario = null;

            //percorre a lista de produtos para obter o prduto com o menor preco unitario
            for (int i = 0; i < produtos.Count; i++)
            {
                //obterm o produto atual da lista que esta sendo percorrido
                Produto produto = produtos[i];
                //verifica se o produto atual possui o menor preco unitario
                if (produto.PrecoUnitario < menorPrecoUnitario)
                {
                    //armazena o preco unitario pois e o menor preco unitrio ate o momento
                    menorPrecoUnitario = produto.PrecoUnitario;
                    //armazena o produto para posteriormente sabeer qual o produto com o menor preco unitario
                    produtoMenorPrecoUnitario = produto;

                }


            }
            return produtoMenorPrecoUnitario;

        }
        public List<double> ObterTodosPrecos()
        {
            //criar uma lista de precos totais
            var precos = new List<double>();
             //percorre todos os produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                //obtem o produto atual da lista de produtos
                var produto = produtos[i];
                // adiciona o preco total na lista de precos
                precos.Add(produto.CalcularPrecoTotal());
            }
            return precos;
        }
        public List<double> ObterPrecosTotaisFiltrandoPorLocalizacao(ProdutoLocalizacao localizacao)
        {
            //criar uma lista de precos totais
            var precos = new List<double>();
            //percorre todos os produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                //obtem o produto atual da lista de produtos
                var produto = produtos[i];
                //verifica se alocalizacao do produto atual e a localizacao passada no parametro
                if (produto.Localizacao == localizacao)
                {
                    //adiciona o preco total do produto atual que foi filtrado por localizacao
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }
            return precos;
        }
        public List<double> ObterPrecosTotaisDoArmazem()
        {
            //criar uma lista de precos totais
            var precos = new List<double>();
            //percorre todos os produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                //obtem o produto atual da lista de produtos
                var produto = produtos[i];
                //verifica se alocalizacao do produto atual e armazem
                if (produto.Localizacao == ProdutoLocalizacao.Armazem)
                {
                    //adiciona o preco total do produto atual que foi filtrado por armazem
                    precos.Add(produto.CalcularPrecoTotal());
                }
            }
            return precos;

        }

        public double ObterMediaPrecosTotais()
        {
            
            var somaPrecosTotais = 0.0;
            //percorre todos os produtos
            for (int i = 0; i < produtos.Count; i++)
            {
                //obtem o produto atual da lista de produtos
                var produto = produtos[i];
               // adiciona o preco total do produto na varialvel soma de precos totais
                somaPrecosTotais += produto.CalcularPrecoTotal();

            }
            // calcula a media de acorso com a qualidade de produtos.
            var media = somaPrecosTotais / produtos.Count;
            return media;
        }




    }
}
