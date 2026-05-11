using System;

namespace Exercicio09.ConsoleApp;

public class Aluno
{
    public double PrimeiraNota;
    public double SegundaNota;

    public double CalcularMediaHarmonica()
    {
        return 2 / ((1 / PrimeiraNota) + (1 / SegundaNota));
    }
}
