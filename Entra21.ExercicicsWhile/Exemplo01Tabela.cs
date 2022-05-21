using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exemplo01Tabela
    {
        public void Executar() 
        {
            var table = new ConsoleTable("nomes");
                  
            Console.WriteLine();
            string[] nomes = new string[10];
            string todosNomes = "";


            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Digite o nome desejado: ");
                nomes[i] = Console.ReadLine();

            }
             for(int i = 0; i < nomes.Length; i++)
            {
                table.AddRow(nomes[i]);

            }
            table.Write();

        }
    }
}
