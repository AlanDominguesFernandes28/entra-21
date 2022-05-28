using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOrientacaoObjeto.Exercicio01
{
    public class Livro
    {
        /*Crie uma classe chamada Livro para armazenar as seguintes informações
            Título
            Autor
            Código ISBN
            Idioma original
            Data de lançamento
            Quantidade de páginas
            Quantidade de páginas lidas
            Quantidade de releituras
            Crie os seguintes métodos:
            ApresentarTituloAutor
            ApresentarQuantidadePaginasParaLer
            ApresentarQuantidadePaginasLidasNoTotal
            Criar testes unitários validando os métodos criados acima*/

        public string Titulo;
        public string Autor;
        public string CodigoISBN;
        public string Idioma;
        public DateTime  DataLancamento;
        public int QuantidadePaginas;
        public int PaginasLidas;
        public int QuantidadeReleitura;
        public int QuantidadeAnos;

        public void ApresentarTituloAutor()
        {
            Console.Write("Titulo: " + Titulo  + "\nAutor: " + Autor);

        }
        public void ApresentarQuantidadePaginasParaLer()
        {
            Console.WriteLine("Quantidade Paginas para Ler: " + (QuantidadePaginas - PaginasLidas));

        }
        public void ApresentarQuantidadePaginasLidasNoTotal()
        {
            Console.WriteLine("Quantidade de Paginas Lidas no total: " + (PaginasLidas * QuantidadeReleitura));
        }
        public void ApresentarQuantidadeAnosAposPublicacao()
        {
            Console.WriteLine("A quantidade de anos apos a publicação: " + (DateTime.Now.Year - DataLancamento.Year));
        }
    }

}
