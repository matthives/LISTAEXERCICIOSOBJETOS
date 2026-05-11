using System;

namespace Exercicio04.ConsoleApp;

public class Veiculo
{
    // Propriedades
    public double QuilometragemInicial { get; set; }
    public double QuilometragemFinal { get; set; }
    public double CombustivelConsumido { get; set; }

    // Método para calcular a distância percorrida
    public double CalcularDistancia()
    {
        return QuilometragemFinal - QuilometragemInicial;
    }

    // Método para calcular o consumo médio
    public double CalcularConsumo()
    {
        return CalcularDistancia() / CombustivelConsumido;
    }
}
