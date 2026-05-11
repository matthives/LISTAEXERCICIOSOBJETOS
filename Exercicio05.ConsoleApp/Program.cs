//5) Crie um programa para calcular o volume de uma esfera

// Criando objeto
using Exercicio05.ConsoleApp;

Esfera esfera = new Esfera();

// Entrada de dados
Console.Write("Digite o raio da esfera: ");
esfera.Raio = Convert.ToDouble(Console.ReadLine());

// Calculando volume
double volume = esfera.CalcularVolume();

// Exibindo resultado
Console.WriteLine($"\nO volume da esfera é: {volume:F2}");

Console.ReadLine();
