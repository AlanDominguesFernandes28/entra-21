using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class ExercicioWhile02
    {

        public void Executar()
        {
            string nome = "";
            int indice = 0;

            while (nome != "fim")
            {
                Console.Write("Digite o nome: \n");
                nome = Console.ReadLine();
                indice = indice + 1;
            }

        }
    }
}
