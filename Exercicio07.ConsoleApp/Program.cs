// Crie um programa para calcular o salário total de um vendedor. Deverá ser
// informado o salário base e o total de vendas. A comissão é calculada com um
// percentual (informado pelo usuário) sobre o total de vendas.

using Exercicio07.ConsoleApp;

Vendedor vendedor = new Vendedor();

Console.Write("Informe o salário base: ");
vendedor.SalarioBase = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o total de vendas: ");
vendedor.TotalVendas = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o percentual da comissão: ");
vendedor.PercentualComissao = Convert.ToDouble(Console.ReadLine());

double salarioTotal = vendedor.CalcularSalarioTotal();

Console.WriteLine($"O salário total é: {salarioTotal:F2} reais");

Console.ReadLine();