using ExerciciosOrientacaoObjeto.Exercicio01;
using ExerciciosOrientacaoObjeto.Exercicio02;

Console.WriteLine(@"---------------MENU------------
1-ExercicioLivro 
2-ExercicioTemperatura");



Console.Write("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    ExemploLivro exemplolivro = new ExemploLivro();
    exemplolivro.Executar();
}
if (opcaoDesejada == 2)
{
    ExemploTemperatura exemplotemperatura = new ExemploTemperatura();
    exemplotemperatura.Executar();
}



