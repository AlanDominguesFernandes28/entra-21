using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class ExercicioWhile11
    {
        public void Executar()
        {
            int numeroUm = 0;
            int numeroDois = 0;
            int indice = 0;
            int opcaoDesejada = 0;
            int soma = 0;
            
            while (opcaoDesejada != 5)
            {
                Console.WriteLine("Digite o numero desejado");
                numeroUm = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o numero desejado");
                numeroDois = Convert.ToInt32(Console.ReadLine());

                
                Console.Write(@"
                                  ----------------------------------------------
                                  |                      MENU                   |
                                  -----------------------------------------------
                                  |  1|                  |SOMAR                 |
                                  |  2|                  |SUBTRAIR              |
                                  |  3|                  |MULTÍPLICAR           |
                                  |  4|                  |DIVIDIR               |
                                  |  5|                  |SAIR                  |
                                  -----------------------------------------------
");


                opcaoDesejada = Convert.ToInt32(Console.ReadLine());

                if (opcaoDesejada == 1)
                {
                    soma = (numeroUm + numeroDois);
                    Console.WriteLine("A soma é:" + numeroUm + "+" + numeroDois + "=" + soma);
                }
                else if (opcaoDesejada == 2)
                {
                    soma = (numeroUm - numeroDois);
                    Console.WriteLine("A soma é:" + numeroUm + "-" + numeroDois + "=" + soma);
                }
                else if (opcaoDesejada == 3)
                {
                    soma = (numeroUm * numeroDois);
                    Console.WriteLine("A soma é:" + numeroUm + "*" + numeroDois + "=" + soma);
                }
                else if (opcaoDesejada == 4)
                {
                    soma = (numeroUm / numeroDois);
                    Console.WriteLine("A soma é:" + numeroUm + "/" + numeroDois + "=" + soma);
                }
                else if (opcaoDesejada == 5)
                {
                    Console.WriteLine("A soma esta finalizada");
                }



            }
        }
         

           

         



         
           
       
       

    }
}
