using System;
using Tabuleiro;
using xadrez;
using Xadrez.Tabuleiro;
using Xadrez.xadrez;
using System.Collections.Generic;

namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartidaDeXadrez Partida = new PartidaDeXadrez();

            while (!Partida.Terminada)
            {

                try
                {

                    Console.Clear();

                    Tela.ImprimirPartida(Partida);

                    Console.WriteLine("");
                    Console.Write("Origem: ");
                    Position Origem = Tela.LerPosicaoXadrez().ToPosicao();

                    //validando posicao de origem
                    Partida.ValidarPosicaoDeOrigem(Origem);

                    //showing possible path to the piece;
                    bool[,] PosicoesPossiveis = Partida.Tab.peca(Origem).MovimentosPossiveis();

                    Console.Clear();
                    Tela.ImprimirTabuleiro(Partida.Tab, PosicoesPossiveis);

                    //logic ends here;

                    Console.WriteLine("");
                    Console.Write("Destino: ");
                    Position Destino = Tela.LerPosicaoXadrez().ToPosicao();

                    //validando posicao de destino;
                    Partida.ValidarPosicaoDeDestino(Origem, Destino);


                    //executando movimento;
                    Partida.ExecutaMovimento(Origem, Destino);

                    //colocando peças;
                    Tela.ImprimirTabuleiro(Partida.Tab);
                }
                catch (TabuleiroException e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }
            Console.Clear();

            Tela.ImprimirPartida(Partida);
        }
    }
}