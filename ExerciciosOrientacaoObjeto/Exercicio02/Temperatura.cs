using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOrientacaoObjeto.Exercicio02
{
    internal class Temperatura
    {
        /* uma classe chamada Temperatura, armazenar as seguintes propriedades:
           temperatura de origem
           Temperatura de destino
           Temperatura*/



        public string TemperaturaOrigem;
        public string TemperaturaDestino;
        public double ValorTemperatura;


        public void CalcularCelsiusParakelvin()
        {   
            ValorTemperatura = ValorTemperatura + 273.15;
            Console.Write("Tempearatura em Kelvin: " + (ValorTemperatura));
        }
        public void CalcularCelsiusParaFahrenheit()
        {
            ValorTemperatura = ValorTemperatura * 1.8 + 32;
            Console.Write("Temperatura em Fahrenheit: " + (ValorTemperatura));
        }
        public void CalcularKelvinParaCelsius()
        {
            ValorTemperatura = ValorTemperatura - 273.15;
            Console.Write("Temperatura em Celsius: " + (ValorTemperatura));
        }
        public void CalcularKelvinParaFarehnheit()
        {
            ValorTemperatura = (ValorTemperatura - 273.15) * 1.8 + 32;
            Console.Write("Temperatura em Fahrenheit: " + (ValorTemperatura));
        }
        public void CalcularFahrenheitParaCelsius()
        {
            ValorTemperatura = (ValorTemperatura - 32) * 5/9;  
            Console.Write("Temperatura em Celsius: " + (ValorTemperatura));
        }
        public void CalcularFahrenheitParaKelvin()
        {
            ValorTemperatura = (ValorTemperatura - 32) * 5/9 + 273.15;
            Console.Write("Temperatura em Kelvin: " + (ValorTemperatura));
        }
        public void Conversor()
        {
            if (TemperaturaOrigem == "celsius" && TemperaturaDestino == "kelvin")
            {
                CalcularCelsiusParakelvin();
            }
            

        }


    }
}
