namespace Exercicio01.ConsoleApp;

public class CaixaRetangular
{
    public decimal comprimento;
    public decimal largura;
    public decimal altura;

    public decimal ObterVolume()
    {
        decimal volume = comprimento * largura * altura;

        return volume;
    }
}