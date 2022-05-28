using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOrientacaoObjeto.Exercicio01
{
    public class ExemploLivro
    {
        public void Executar()
        {
            Livro livro = new Livro();
           
            livro.Titulo = "Felicidade";
            livro.Autor = "Alan";
            livro.CodigoISBN = "40028922";
            livro.Idioma = "Portugues";
            livro.DataLancamento = new DateTime (2020, 08, 25, 00, 00, 00);
            livro.QuantidadePaginas = 100;
            livro.PaginasLidas = 30;
            livro.QuantidadeReleitura = 1;


            livro.ApresentarTituloAutor();
            Console.WriteLine(
               
                "\nCodigo ISBN: " + livro.CodigoISBN +
                "\nIdioma: " + livro.Idioma +
                "\nData de Lancamento: " + livro.DataLancamento +
                "\nQuantidade de Paginas: " + livro.QuantidadePaginas +
                "\nPaginas Lidas: " + livro.PaginasLidas +
                "\nQuantidade de Reeleitura: " + livro.QuantidadeReleitura);

            livro.ApresentarQuantidadePaginasParaLer();
           
            livro.ApresentarQuantidadePaginasLidasNoTotal();

            livro.ApresentarQuantidadeAnosAposPublicacao();




        }
       

    }
}
