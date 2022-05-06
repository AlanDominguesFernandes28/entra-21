using Entra21.ExerciciosWhile;

Console.WriteLine(@"---------------MENU------------
1-Exercicio 01
2-Exercicio 02
3-Exercicio 03");

Console.Write("Digite a opção desejada");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    ExercicioWhile01 Atividade = new ExercicioWhile01();
    Atividade.Executar();
}
else if (opcaoDesejada == 2)
{
    ExercicioWhile02 Atividade = new ExercicioWhile02();
    Atividade.Executar();
}
else if
