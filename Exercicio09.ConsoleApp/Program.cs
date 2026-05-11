// Crie um programa para calcular a média harmônica das notas de um aluno

using Exercicio09.ConsoleApp;

Aluno aluno = new Aluno();

Console.Write("Digite a primeira nota: ");
aluno.PrimeiraNota = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
aluno.SegundaNota = Convert.ToDouble(Console.ReadLine());

double mediaHarmonica = aluno.CalcularMediaHarmonica();

Console.WriteLine($"A média harmônica do aluno é: {mediaHarmonica:F2}");

Console.ReadLine();
