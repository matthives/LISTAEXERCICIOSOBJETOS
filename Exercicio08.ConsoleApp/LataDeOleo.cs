using System;

namespace Exercicio08.ConsoleApp;

public class LataDeOleo
{
    public double Raio;
    public double Altura;

    public double CalcularVolume()
    {
        return Math.PI * Math.Pow(Raio, 2) * Altura;
    }
}
