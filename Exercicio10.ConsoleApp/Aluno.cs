using System;

namespace Exercicio10.ConsoleApp;

public class Aluno
{
    public double PrimeiraNota;
    public double SegundaNota;

    public double PesoPrimeiraNota;
    public double PesoSegundaNota;

    public double CalcularMediaPonderada()
    {
        return ((PrimeiraNota * PesoPrimeiraNota) +
               (SegundaNota * PesoSegundaNota))
               / (PesoPrimeiraNota + PesoSegundaNota);
    }
}
