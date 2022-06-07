using Entra21.ExercicioLista1;

Console.WriteLine(@"---------------MENU------------
1-Exercicio 01
2-Exercicio 02
3-Exercicio 03");



Console.Write("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    ExercicioLista01 Atividade = new ExercicioLista01();
    Atividade.Executar();
}
else if (opcaoDesejada == 2)
{
    ExercicioLista02 Atividade = new ExercicioLista02();
    Atividade.Executar();
}
else if (opcaoDesejada == 3)
{
    ExercicioLista03 Atividade = new ExercicioLista03();
    Atividade.Executar();
}


