using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListaObjetos.Exercicio1
{
    //-Triangulos:List<Triangulo>
    //-CodigoAtual
    //---------------------------------------
    //+Adicionar(lado1,lado2,lado3):bool
    //+Editar(codigo,lado1,lado2,lado3):bool
    //+Apagar(codigo):bool
    //+ObterTodos():list<Triangulo>
    //+ObterPorCodigo(codigo):Triangulo
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();


        private int codigoAtual = 1;

        public bool Adicionar(int lado1, int lado2, int lado3)
        {

            Triangulo triangulo = new Triangulo();

            triangulo.lado1 = lado1;
            triangulo.lado2 = lado2;
            triangulo.lado3 = lado3;

            triangulo.codigo = codigoAtual;

            codigoAtual = codigoAtual + 1;

            triangulos.Add(triangulo);

            return true;
        }

        public bool Editar(int lado1, int lado2, int lado3, int codigoParaAlterar)
        {
            Triangulo trianguloAlterar = ObterPorCodigo(codigoParaAlterar);

            if (trianguloAlterar == null)
            {

                return false;

            }
            trianguloAlterar.lado1 = lado1;
            trianguloAlterar.lado2 = lado2;
            trianguloAlterar.lado3 = lado3;
            return true;
        }
        public bool Apagar(int codigo)
        {
            Triangulo trianguloParaRemover = ObterPorCodigo(codigo);

            if (trianguloParaRemover == null)
            {
                return false;
            }
            triangulos.Remove(trianguloParaRemover);

            return true;
        }
        public List<Triangulo> ObterTodos()
        {
            return triangulos;

        }
        public Triangulo ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < triangulos.Count; i++)
            {
                var triangulo = triangulos[i];

                if (triangulo.codigo == codigo)
                {
                    return triangulo;
                }
            }
            return null;

        }











    }
}
