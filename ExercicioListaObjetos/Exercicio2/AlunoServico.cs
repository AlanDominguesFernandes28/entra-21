using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListaObjetos.Exercicio2
{
    internal class AlunoServico
    {
        private List<Aluno> alunos = new List<Aluno>();     
        public bool RemoverAluno(string nome)
        {
            Aluno removerAluno = new Aluno();

            if(removerAluno == null)
            {
                return false;
            }
            alunos.Remove(removerAluno);
               return true;
        }
        public bool EditarDadosCadastrais(int codigoMatricula, string nome, int idade, string materiaFavorita)
        {
            Aluno editarDadosCadastrais = new Aluno();

            if (EditarDadosCadastrais == null)
            {
                return false;
            }
            editarDadosCadastrais.codigoMatricula = codigoMatricula;
            editarDadosCadastrais.nome = nome;
            editarDadosCadastrais.idade =idade;
            editarDadosCadastrais.materiaFavorita = materiaFavorita;

            return true;
        }
        public bool EditarNotasAlunos( int codigoMatricula,double nota1,double nota2,double nota3)
        {
            Aluno editarNotasAlunos = new Aluno();

            if (EditarNotasAlunos == null)
            {
                return false;
            }
            editarNotasAlunos.codigoMatricula = codigoMatricula;
            editarNotasAlunos.nota1 = nota1;
            editarNotasAlunos.nota2 = nota2;
            editarNotasAlunos.nota3 = nota3;

            return true;

        }
        public List<Aluno> obterNomes()
        {
            return alunos;
        }

        


    }
}
