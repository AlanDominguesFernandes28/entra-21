using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entra21.ExercicioLista1
{
    public class ExercicioLista01
    {
        public void Executar()
        {
            List<string> filmes = new List<string>();
            filmes.Add("Dragon Ball Evollution");
            filmes.Add("Titanic");
            filmes.Add("Lanterna verde");
            Console.WriteLine(" Filme 1 : " + filmes[0] +
                            "\n Filme 2 : " + filmes[1] +
                            "\n Filme 3 : " + filmes[2]);

            filmes.Add("");


            var filme = filmes.IndexOf("Dragon Ball Evollution");
            filmes[filme] = "Dragon Ball Super: Broly";

            Console.WriteLine(" Filme 1 : " + filmes[0] +
                            "\n Filme 2 : " + filmes[1] +
                            "\n Filme 3 : " + filmes[2]);
            var filme2 = filmes.IndexOf("Lanterna verde");
            filmes.Remove("Lanterna verde");





            var contemFilme = filmes.Contains("Lanterna verde");
            if (contemFilme == false)
            {
                Console.WriteLine("Filme não esta cadastrado");
            }
            else
            {
                Console.WriteLine("Filme esta cadastrado");
            }


            
            filmes.Add("Quarteto fantástico");

            Console.WriteLine(" Filme 1 : " + filmes[0] +
                           "\n Filme 2 : " + filmes[1] +
                           "\n Filme 3 : " + filmes[2] +
                           "\n Filme 4 : " + filmes[3]);

            var filme3 = filmes.IndexOf("Titanic");
            filmes[filme] = "Titanic 2";

            Console.WriteLine(" Filme 1 : " + filmes[0] +
                          "\n Filme 2 : " + filmes[1] +
                          "\n Filme 3 : " + filmes[2] +
                          "\n Filme 4 : " + filmes[3]);


            var contemFilme5 = filmes.Contains("A Lagoa Azul");
            if (contemFilme5 == false)
            {
                Console.WriteLine("Filme lagoa azul não esta cadastrado");
            }
            else
            {
                Console.WriteLine("Filme esta cadastrado");
            }














        }
    }
}
