using System;

namespace Exercicio07.ConsoleApp;

public class Vendedor
{
    public double SalarioBase;
    public double TotalVendas;
    public double PercentualComissao;

    public double CalcularComissao()
    {
        return TotalVendas * (PercentualComissao / 100);
    }

    public double CalcularSalarioTotal()
    {
        return SalarioBase + CalcularComissao();
    }
}
