using System;

namespace Exercicio05.ConsoleApp;

public class Esfera
{
    // Propriedade
    public double Raio { get; set; }

    // Método para calcular o volume
    public double CalcularVolume()
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(Raio, 3);
    }
}
