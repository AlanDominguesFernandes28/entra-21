using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio01Vetor
    {
        public void Executar()
        {
            int[] numeros = new int[16];
            var soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                try
                {
                    Console.WriteLine("Digite o numero inteiro desejado");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Esse numero não é inteiro,digite novamente: ");
                }
            
                soma = soma + numeros[i];
            }
            Console.WriteLine(@$"a soma total é:  {soma} ");
            
        }

    }
}
