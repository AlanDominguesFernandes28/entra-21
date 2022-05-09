using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class ExercicioWhile04
    {
        public void Executar()
        {
            double peso = 0;
            int quantidadePessoas = 0;
            int indice = 0;

            while ((peso > -1) || (peso < 301))
            {
                Console.WriteLine("Digite seu peso");
                peso = Convert.ToDouble(Console.ReadLine());
                indice = indice + 1;

                quantidadePessoas = quantidadePessoas + 1;
                Console.WriteLine(quantidadePessoas);

            }
        }
    }

}








