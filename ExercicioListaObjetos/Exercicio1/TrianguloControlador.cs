using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListaObjetos.Exercicio1
{
    //CRUD
    internal class TrianguloControlador
    {
        private TrianguloServico trianguloServico = new TrianguloServico();

        public void GerenciarMenu()
        {
            int codigo = 0;


            while (codigo != 6)
            {
                Console.Clear();

                codigo = ApresentarMenu();

                if (codigo == 1)
                {

                    ApresentarTriangulo();
                }
                else if (codigo == 2)
                {

                    Cadastrar();
                }
                else if (codigo == 3)
                {

                    Editar();
                }
                else if (codigo == 4)
                {
                    Apagar();
                }
                else if (codigo == 5)
                {

                }
                Thread.Sleep(1000);
            }
        }
        public int ApresentarMenu()
        {
            Console.WriteLine(@" Menu:
             1-Apresentar Triangulo
             2-Cadastrar
             3-Editar
             4-Apagar
             5-sair");

            var opcaoDesejada = Convert.ToInt32(Console.ReadLine());

            return opcaoDesejada;
        }
        public void Cadastrar()
        {
            Console.Write("Digite o lado1 do triangulo ");
            var triangulo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o lado2 do triangulo ");
            var triangulo1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o lado3 do triangulo ");
            var triangulo2 = Convert.ToInt32(Console.ReadLine());
        }

        public void Editar()
        {
            Console.WriteLine("Codigo desejado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

        }
        public void Apagar()
        {
            ApresentarTriangulo();

            Console.Write("Por favor informe o código do triângulo que você deseja apagar: ");
            var codigo = Convert.ToInt32(Console.ReadLine().Trim());

            var ApagarTriangulo = trianguloServico.Apagar(codigo);

            if (ApagarTriangulo == false)
            {
                Console.WriteLine(@"
                Código digitado não existe.");
            }
            else
            {
                Console.WriteLine(@"
                Triângulo apagado com sucesso.");
            }
        }

        private void ApresentarTodos()
        {
            var triangulos = trianguloServico.ObterTodos();

            if (triangulos.Count == 0)
            {
                Console.WriteLine("Nenhum triângulo cadastrado.");

                return;
            }

            Console.WriteLine("Lista de triângulos:");

            for (var i = 0; i < triangulos.Count(); i++)
            {
                var trianguloAtual = triangulos[i];

                Console.WriteLine($@"Código {trianguloAtual.codigo}");
            }
        }
        public void ApresentarTriangulo()
        {
            ApresentarTodos();

            Console.Write("Digite o codigo do triangulo a ser detalhado: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var apresentarTriangulo = trianguloServico.ObterPorCodigo(codigo);

            if (apresentarTriangulo == null)
            {
                Console.WriteLine("triangulo nao esta cadastrado");
                return;
            }

        }
    }
}
