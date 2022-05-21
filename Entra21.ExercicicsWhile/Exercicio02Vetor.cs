using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio02Vetor
    {
        public void Executar()
        {
            string[] nomes = new string[10];
            string todosNomes = "";


            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Digite o nome desejado: ");
                nomes[i] = Console.ReadLine();

                todosNomes = todosNomes + nomes[i] + ",";


            }
            Console.WriteLine(todosNomes);



        }
    }
}
