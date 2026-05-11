// 2) Crie um programa para converter a temperatura de graus Fahrenheit para graus celsius
using Exercicio02.ConsoleApp;

TemperaturaFahrenheit fahrenheit = new TemperaturaFahrenheit();
fahrenheit.graus = 100;

TemperaturaCelsius celsius = fahrenheit.ConverterParaCelcius();

Console
    .WriteLine($"A conversão de {fahrenheit.graus:F1} ºF resultou em: {celsius.graus:F1} ºC");