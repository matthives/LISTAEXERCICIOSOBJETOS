// Crie um programa para calcular o volume de uma lata de óleo

using Exercicio08.ConsoleApp;

LataDeOleo lata = new LataDeOleo();

Console.Write("Informe o raio da lata: ");
lata.Raio = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a altura da lata: ");
lata.Altura = Convert.ToDouble(Console.ReadLine());

double volume = lata.CalcularVolume();

Console.WriteLine($"O volume da lata de óleo é: {volume:F2}");

Console.ReadLine();