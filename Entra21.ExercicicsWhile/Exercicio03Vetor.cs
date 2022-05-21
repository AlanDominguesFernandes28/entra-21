using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio03Vetor
    {
        public void Executar()
        {
            double[] precos = new double[7];
            string[] nomes = new string[7];
            string nomePreco = "";
            
            

            
            
            for(int i = 0; i < nomes.Length; i++)
            {
                
                Console.WriteLine("Digite o nome do produto");
                nomes[i] = Console.ReadLine();

                try
                {
                    Console.WriteLine("Digite o preco do produto");
                    precos[i] = Convert.ToDouble(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("A ação desejada esta incorreta,digite novamente");

                }
                 nomePreco = nomePreco + nomes[i] +" R$ " + precos[i] + "\n";
          
            }
            Console.WriteLine(nomePreco);



        }
    }
}
