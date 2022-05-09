using Entra21.ExerciciosWhile;

Console.WriteLine(@"---------------MENU------------
1-Exercicio 01
2-Exercicio 02
3-Exercicio 03
4-Exercicio 04
5-Exercicio 05
6-Exercicio 06
7-Exercicio 07
8-Exercicio 08
9-Exercicio 09
10-Exercicio 10
11-Exercicio 11");     







Console.Write("Digite a opção desejada: ");
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
else if (opcaoDesejada == 3)
{
    ExercicioWhile03 Atividade = new ExercicioWhile03();
    Atividade.Executar();
}
else if (opcaoDesejada == 4)
{
    ExercicioWhile04 Atividade = new ExercicioWhile04();
    Atividade.Executar();
}
else if (opcaoDesejada == 5)
{
    ExercicioWhile05 Atividade = new ExercicioWhile05();
    Atividade.Executar();
}
else if (opcaoDesejada == 6)
{
    ExercicioWhile06 Atividade = new ExercicioWhile06();
    Atividade.Executar();
}
else if (opcaoDesejada == 7)
{
    ExercicioWhile07 Atividade = new ExercicioWhile07();
    Atividade.Executar();
}
else if (opcaoDesejada == 8)
{
    ExercicioWhile08 Atividade = new ExercicioWhile08();
    Atividade.Executar();
}
else if (opcaoDesejada == 9)
{
    ExercicioWhile09 Atividade = new ExercicioWhile09();
    Atividade.Executar();
}
else if (opcaoDesejada == 10)
{
    ExercicioWhile10 Atividade = new ExercicioWhile10();
    Atividade.Executar();
}
else if (opcaoDesejada == 11)
{
    ExercicioWhile11 Atividade = new ExercicioWhile11();
    Atividade.Executar();
}