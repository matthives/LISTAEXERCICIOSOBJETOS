using System;

namespace Exercicio03.ConsoleApp;

public class Cilindro
{
    // Atributos
    public double Raio { get; set; }
    public double Altura { get; set; }

    // Método para calcular o volume
    public double CalcularVolume()
    {
        return Math.PI * Raio * Raio * Altura;
    }
}
