// Crie um programa para calcular a média ponderada de duas provas realizadas
// por um aluno

using Exercicio10.ConsoleApp;

Aluno aluno = new Aluno();

Console.Write("Digite a nota da primeira prova: ");
aluno.PrimeiraNota = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o peso da primeira prova: ");
aluno.PesoPrimeiraNota = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a nota da segunda prova: ");
aluno.SegundaNota = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o peso da segunda prova: ");
aluno.PesoSegundaNota = Convert.ToDouble(Console.ReadLine());

double mediaPonderada = aluno.CalcularMediaPonderada();

Console.WriteLine($"A média ponderada do aluno é: {mediaPonderada:F2}");

Console.ReadLine();