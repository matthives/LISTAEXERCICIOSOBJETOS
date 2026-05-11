using System;

namespace Exercicio06.ConsoleApp;

public class TemperaturaCelsius
{
    public decimal graus;

    public TemperaturaFahrenheit ConverterParaFahrenheit()
    {
        TemperaturaFahrenheit fahrenheit = new TemperaturaFahrenheit();

        fahrenheit.graus = (graus * 9 / 5) + 32;

        return fahrenheit;
    }
}
