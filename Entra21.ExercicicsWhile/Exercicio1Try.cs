using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio1Try
    {
        public void Executar()
        {
            string peca = "";
            var preco = 0.0;
            int indice = 0;

            while (indice <= 0) ;
            {
                try
                {
                    Console.WriteLine("Digite o nome da peça");
                    peca = Console.ReadLine();

                    Console.WriteLine("Digite o preço da peça");
                    preco = Convert.ToDouble(Console.ReadLine());
                }
                catch ( Exception ex)
                {
                    Console.WriteLine("Digito esta invalido");

                }
            }




        }
    }
}

            
            

            

            
              
            
               

                


            

           

            
            
        

        


    

