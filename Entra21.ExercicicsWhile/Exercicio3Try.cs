using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio3Try
    {
        public void Executar()
        {
           
            Console.WriteLine("Informe o Numero da Tabuada");
            var numero = Convert.ToInt32(Console.ReadLine());

            var indiceNumero = 0;
            for (var indice= 0; indice <= 1000; indice = indice + 1)
            {
               
                if (numero > 0)
                {
                    Console.WriteLine("   " + numero + " x " + indiceNumero + " = " + (numero * indiceNumero));

                    indiceNumero = indiceNumero + 1;
                }
                else
                {
                    Console.WriteLine(" \n ");
                }
                    
                
                
                    
                


                

            }
          
            
            

        }
    }
}
