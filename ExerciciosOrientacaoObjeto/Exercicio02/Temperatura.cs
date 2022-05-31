using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOrientacaoObjeto.Exercicio02
{
    public class Temperatura
    {
        /* uma classe chamada Temperatura, armazenar as seguintes propriedades:
           temperatura de origem
           Temperatura de destino
           Temperatura*/



        public string TemperaturaOrigem;
        public string TemperaturaDestino;
        public double ValorTemperatura;
       


        public double CalcularCelsiusParakelvin()
        {
            var temperaturaConvertida = ValorTemperatura + 273.15;
            return temperaturaConvertida;
        }

        public double CalcularCelsiusParaFahrenheit()
        {   
            var temperaturaConvertida = ValorTemperatura * 1.8 + 32;
            return temperaturaConvertida;
        }

        public double CalcularKelvinParaCelsius()
        {
            var temperaturaConvertida = ValorTemperatura - 273.15;
            return temperaturaConvertida;
        }

        public double CalcularKelvinParaFarehnheit()
        {
            var temperaturaConvertida = (ValorTemperatura - 273.15) * 1.8 + 32;
            return temperaturaConvertida;
        }

        public double CalcularFahrenheitParaCelsius()
        {
            var temperaturaConvertida = (ValorTemperatura - 32) * 5 / 9;
            return temperaturaConvertida;
        }

        public double CalcularFahrenheitParaKelvin()
        {
            var temperaturaConvertida = (ValorTemperatura - 32) * 5 / 9 + 273.15;
            return temperaturaConvertida;
        }

        public double ObterTemperaturaConvertida()
        {

            var temperaturaConvertida = 00.0;
            if (TemperaturaOrigem == "celsius" && TemperaturaDestino == "kelvin")
            {
                temperaturaConvertida = CalcularCelsiusParakelvin();
                
            }
            else if (TemperaturaOrigem == "celsius" && TemperaturaDestino == "fahrenheit")
            {
                temperaturaConvertida = CalcularCelsiusParaFahrenheit();
            }
            else if (TemperaturaOrigem == "kelvin" && TemperaturaDestino == "celsius")
            {
                temperaturaConvertida = CalcularKelvinParaCelsius();
            }
            else if (TemperaturaOrigem == "kelvin" && TemperaturaDestino == "fahrenheit")
            {
                temperaturaConvertida = CalcularKelvinParaFarehnheit();
            }
            else if (TemperaturaOrigem == "fahrenheit" && TemperaturaDestino == "celsius")
            {
                temperaturaConvertida = CalcularFahrenheitParaCelsius();
            }
            else if (TemperaturaOrigem == "fahrenheit" && TemperaturaDestino == "kelvin")
            {
                temperaturaConvertida = CalcularFahrenheitParaKelvin();
            }
            return temperaturaConvertida;



        }


    }




}