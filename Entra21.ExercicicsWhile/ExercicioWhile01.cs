using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class ExercicioWhile01
    {
        public void Executar()
        {
            double preco = 0;
            string nome = "";
            int indice = 0;

            while (indice < 13)
            {
                Console.WriteLine("Digite o nome da peça");
                nome = Console.ReadLine();
                Console.WriteLine("Digite o preço da peça");
                preco = Convert.ToDouble(Console.ReadLine());
                indice = indice + 1;

            }




        }
    }
}
