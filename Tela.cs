using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Tabuleiro;

namespace Xadrez
{
    internal class Tela
    {
        public static void ImprimirTabuleiro (tabuleiro tab)
        {
            for (int i = 0; i < tab.Linha; i++)
            {
                for(int j = 0; j < tab.Colunas; j++)
                {
                    if(tab.peca(i, j) == null)
                    {
                        Console.Write($"- ");
                    }
                    else
                    {
                        Console.Write($"{tab.peca(i, j)} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
