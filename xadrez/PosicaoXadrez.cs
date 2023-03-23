using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace Xadrez.xadrez
{
    internal class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        //constructor
        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        //method that returns a numeric value from the chess position (ex: turns C7 into 1, 2);
        public Position ToPosicao()
        {
            return new Position(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            //as aspas vazias são para forçar uma conversão a string;
            return "" + (char.ToUpper(Coluna)) + Linha;
        }
    }
}
