using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListaObjetos.Exercicio1
{
    //+lado 1
    //+lado 2
    //+lado 3
    //+codigo
    //-----------------------
    //ValidarTriangulo():bool
    internal class Triangulo
    {
        public int lado1;
        public int lado2;
        public int lado3;
        public int codigo;

        

        public bool ValidarTriangulo(int lado1, int lado2,int lado3)
        {
            if ((lado1 < lado2 + lado3) && (lado2 < lado1 + lado3) && (lado3 < lado1 + lado2))
            {
                
                return true;
            }
            else
            {
                
                return false;
            }
            


        }

        internal void Add(Triangulo triangulo)
        {
            throw new NotImplementedException();
        }

        internal void Remove(Triangulo triangulo)
        {
            throw new NotImplementedException();
        }
    }





}
