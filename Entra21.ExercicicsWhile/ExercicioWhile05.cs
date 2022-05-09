using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class ExercicioWhile05
    {
        public void Executar()
        {
            Console.WriteLine("Digite a quantidade de carros que queira cadastrar");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            string modelo = "";
            int ano = 0;
            double valor = 0;
            int indice = 0;
            double somaValorCarro = 0;
            int somaAnoCarro = 0;
            double mediaValorCarro = 0;
            int mediaAnoCarro = 0;
            int modeloG = 0;
            int modeloA = 0;


            while (indice < quantidade)
            {

                Console.WriteLine("Digite o modelo do carro");
                modelo = Console.ReadLine();

                Console.WriteLine("Digite o valor do carro");
                valor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o ano do carro");
                ano = Convert.ToInt32(Console.ReadLine());

                indice = indice + 1;

                somaValorCarro = somaValorCarro + valor;
                somaAnoCarro = somaAnoCarro + ano;
                mediaValorCarro = somaValorCarro / quantidade;
                mediaAnoCarro = somaAnoCarro / quantidade;

                if (modelo.StartsWith("g"))
                {
                    modeloG = modeloG + 1;
                }
                else if (modelo.StartsWith("a"))
                {
                    modeloA = modeloA + 1;
                }
            }
             Console.WriteLine(@"A média do ano dos carros é:" + mediaAnoCarro +
                    " A media  do valor dos carros é :" + mediaValorCarro +
                    "A  quantidade de carros que comecam com a letra G é:" + modeloG +
                    "A quantidade de carros que comecam com a letra A é:" + modeloA);

        }

    }
}
