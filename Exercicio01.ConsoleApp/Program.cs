// 1) Crie um programa para calcular o volume de uma caixa retangular
// V = C . L . A
using Exercicio01.ConsoleApp;

CaixaRetangular caixa = new CaixaRetangular();
caixa.comprimento = 50;
caixa.largura = 30;
caixa.altura = 20;

decimal volumeCaixa = caixa.ObterVolume();

Console.WriteLine($"O volume da caixa é de: {volumeCaixa.ToString("F2")} cm³");