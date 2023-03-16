using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez.Tabuleiro
{
    internal class Tabuleiro
    {
        public int Linha { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linha, int coluna)
        {
            Linha = linha;
            Colunas = coluna;
            Pecas = new Peca[linha, coluna];
        }
    }
}
