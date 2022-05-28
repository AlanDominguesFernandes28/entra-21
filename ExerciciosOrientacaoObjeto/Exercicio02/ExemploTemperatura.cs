using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOrientacaoObjeto.Exercicio02
{
    public class ExemploTemperatura
    {
        public void Executar()
        {
            Temperatura temperatura = new Temperatura();

            temperatura.TemperaturaOrigem = "celsius";
            temperatura.TemperaturaDestino = "kelvin";
            temperatura.ValorTemperatura = 10;

            temperatura.Conversor();




        }
    }
}
