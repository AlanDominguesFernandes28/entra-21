using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio2Try
    {
        public void Executar()
        {

            Console.WriteLine("Digite a quantidade de carros a ser cadastrado");
            var quantidade = Convert.ToInt32(Console.ReadLine());
            var somaAno = 0;
            var somaValor = 0.0;
            var modeloG = "";
            var modeloA = "";

            for (var indice = 0; indice < quantidade; indice = indice + 1)
            {
                var quantidadeValido = false;

                var modelo = "";
                var ano = 0;


                Console.WriteLine("Digite o modelo do carro");
                modelo = Console.ReadLine();


                var valor = 0.0;
                while (quantidadeValido == false)
                {

                    try
                    {
                        Console.WriteLine("Digite o valor do carro");
                        valor = Convert.ToInt32(Console.ReadLine());
                        if (valor > 0)
                        {
                            quantidadeValido = true;
                        }



                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Digito está invalido");
                    }

                    

                    if (modelo.StartsWith("g"))
                    {
                        modeloG = modeloG + 1;
                    }
                    else if (modelo.StartsWith("a"))
                    {
                        modeloA = modeloA + 1;
                    }

                }

                Console.WriteLine("Digite o ano do carro");
                ano = Convert.ToInt32(Console.ReadLine());

                somaAno = somaAno + ano;
                somaValor = somaValor + valor;
            }
            var mediaAnoCarro = somaAno / quantidade;
            var mediaValorCarro = somaValor / quantidade;

            Console.WriteLine(@"A média do ano dos carros é:" + mediaAnoCarro);
            Console.WriteLine(@"A média dos Valores dos carros é:" + mediaValorCarro);

            Console.WriteLine(@"A quantidade de carros que comecam com a letra G é:" + modeloG);
            Console.WriteLine(@"A quantidade de carros que comecam com a letra A é:" + modeloA);








        }
    }
}
