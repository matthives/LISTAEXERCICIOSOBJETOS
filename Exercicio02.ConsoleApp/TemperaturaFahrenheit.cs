namespace Exercicio02.ConsoleApp;

//  (32 °F − 32) × 5/9 = 0 °C
public class TemperaturaFahrenheit
{
    public decimal graus;

    public TemperaturaCelsius ConverterParaCelcius()
    {
        TemperaturaCelsius celsius = new TemperaturaCelsius();
        celsius.graus = (graus - 32) * 5 / 9;

        return celsius;
    }
}