// 4) Crie um programa para calcular o consumo de combustível por Km. Deverá ser
// informado a kilometragem Inicial e Final do Percurso do Veículo. Deverá ser
// informado o Consumo de Combustível

// Criando o objeto
using Exercicio04.ConsoleApp;

Veiculo veiculo = new Veiculo();

// Entrada de dados
Console.Write("Digite a quilometragem inicial do veículo: ");
veiculo.QuilometragemInicial = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a quilometragem final do veículo: ");
veiculo.QuilometragemFinal = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a quantidade de combustível consumida: ");
veiculo.CombustivelConsumido = Convert.ToDouble(Console.ReadLine());

// Calculando resultados
double distancia = veiculo.CalcularDistancia();
double consumo = veiculo.CalcularConsumo();

// Exibindo resultados
Console.WriteLine($"\nDistância percorrida: {distancia:F2} Km");
Console.WriteLine($"Consumo médio: {consumo:F2} Km/l");

Console.ReadLine();