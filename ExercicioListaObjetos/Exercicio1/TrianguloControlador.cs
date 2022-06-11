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
        public void GerenciarMenu()
        {
            int codigo = 0;

            while (codigo != 6)
            {
                Console.Clear();

                codigo = ApresentarSolicitarMenu();

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
        private int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@" Menu:
             1- Listar todos
             2- Cadastrar
             3- Editar
             4- Apagar
             5-Apresentar produto desejado
             6-Sair");
        }
        private void Cadastrar()
        {
            Console.Write("Digite o lado do triangulo ");
            var triangulo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o lado do triangulo ");
            var triangulo1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o lado do triangulo ");
            var triangulo2 = Convert.ToInt32(Console.ReadLine());
        }
        private void Editar()
        {
            Console.WriteLine("Codigo desejado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

        }
        private void Apagar()
        {

            ApresentarTriangulo();

            Console.WriteLine("Digite o Codigo do triangulo para apagar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var registroApagado = trianguloServico.Apagar(codigo);
            Console.WriteLine(registroApagado == true
                                                ? " Registro removido com sucesso"
                                                : " nenhum produto cadastrado com o codigo informado");
        }
        private void ApresentarTriangulo()
        {
            ApresentarTriangulo();

            Console.Write("Digite o codigo do triangulo a ser detalhado: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var produto = trianguloServico.ObterPorCodigo(codigo);

            if (produto == null)
            {
                Console.WriteLine("Produto nao esta cadastrado");
                return;
            }

        }
    }
}
