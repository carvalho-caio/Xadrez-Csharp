using System;
using Tabuleiro;
using Xadrez.Tabuleiro;
using Xadrez.xadrez;

namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tabuleiro tab = new tabuleiro(8, 8);

            //colocando peças;
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Position(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Position(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Position(2, 4));

            Tela.ImprimirTabuleiro(tab);

            //to declar a CHAR variable, it NEEDS to be in simple ', otherwise is considered a string;
            PosicaoXadrez teste = new PosicaoXadrez('c', 7);

            Console.WriteLine(teste.ToPosicao());
            Console.WriteLine(teste);
        }
    }
}