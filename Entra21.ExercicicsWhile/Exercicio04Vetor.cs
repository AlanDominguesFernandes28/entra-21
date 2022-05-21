using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio04Vetor
    {
        public void Executar()
        {
            double[] notas = new double[4];
            string disciplinas = "";
            int number = 1;
            Console.WriteLine("Informe a Disciplina");
            disciplinas = Console.ReadLine();

            for (int i = 0; i < notas.Length; i = i + 1)
            {
                try
                {

                    Console.WriteLine($"Informe a nota {number} ");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine(" ");
                }
                number = number + 1;



            }

        }
    }
}
