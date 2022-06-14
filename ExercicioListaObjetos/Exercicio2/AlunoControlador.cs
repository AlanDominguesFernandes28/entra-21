using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListaObjetos.Exercicio2
{
    internal class AlunoControlador
    {
        private AlunoServico alunoServico = new AlunoServico();
    }
    public void GerenciarMenu()
    {
        int codigo = 0;


        while (codigo != 6)
        {
            Console.Clear();

            codigo = ApresentarMenu();

            if (codigo == 1)
            {

                CadastrarAluno();
            }
            else if (codigo == 2)
            {

                EditarinformacoesAluno();
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
        public int ApresentarMenu()
        {
            Console.WriteLine(@" Menu:
             1-Cadastrar Aluno
             2-Editar Informacoes do Aluno
             3-Alterar notas do aluno
             4-listar todo os alunos
             5-listar o nome dos aprovados
             6-listar o nome de todo os alunos
             7-listar o nome dos reprovados
             8-listar os alunos em exame
             9-Visualizao a media de aluno especifico
             10-visualizao stuatus de aluno especifico
             11-visualizar a media das idades
             12-sair");

            var opcaoDesejada = Convert.ToInt32(Console.ReadLine());

            return opcaoDesejada;
        }
        public void CadastrarAluno()
        {
            Console.WriteLine("Digite seu Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua Idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite sua Materia Favorita: ");
            string materiaFavorita = Console.ReadLine();


            var matricula = 2022000;
            matricula = matricula + 1;


            Console.WriteLine("Digite a Nota 1 : ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a Nota 2 : ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a Nota 3 : ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

        }
        public void EditarinformacoesAluno()
        {

        }

    }

}
