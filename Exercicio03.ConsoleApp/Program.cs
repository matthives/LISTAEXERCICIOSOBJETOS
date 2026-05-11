// Crie um programa para calcular o volume de um Cilindro
// V=πr2h

using Exercicio03.ConsoleApp;

Cilindro cilindro = new Cilindro();

Console.Write("Digite o raio do cilindro: ");
cilindro.Raio = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a altura do cilindro: ");
cilindro.Altura = Convert.ToDouble(Console.ReadLine());

// Chamando o método da classe
double volume = cilindro.CalcularVolume();

Console.WriteLine($"O volume do cilindro é: {volume:F2}");