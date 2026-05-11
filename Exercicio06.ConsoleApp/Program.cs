// Crie um programa para converter a temperatura da escala Celsius para a escala
// Fahrenheit

using Exercicio06.ConsoleApp;

TemperaturaCelsius celsius = new TemperaturaCelsius();

Console.Write("Digite a temperatura em Celsius: ");
celsius.graus = Convert.ToDecimal(Console.ReadLine());

TemperaturaFahrenheit fahrenheit = celsius.ConverterParaFahrenheit();

Console.WriteLine(
    $"A conversão de {celsius.graus:F1} ºC resultou em: {fahrenheit.graus:F1} ºF"
);

Console.ReadLine();
