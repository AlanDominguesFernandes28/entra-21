namespace Entra21.ExercicioLista1
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();
             // encapsulamento + tiporetorno + nomemetodo
        public void Adicionar(string nome,double precoUnitario,ProdutoLocalizacao localizacao, int quantidade) 
        { 
            //instanciar um objeto da classe produto
            Produto produto = new Produto();

            // atribuir valor para as propriedades com os dados passados com parametro
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            // adicionar o produto instanciado na lista de produtos
            produtos.Add(produto);
            

        }

        public void Editar() { }

        public void Apagar() { }

        public List<Produto> ObterTodos()
        {
            return produtos;

        }
        public Produto ObterPorCodigo()
        {
            return null;
        }
    }
}
