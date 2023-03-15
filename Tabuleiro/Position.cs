using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro
{
    internal class Position
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        //constructors
        public Position()
        {

        }

        public Position(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        //methods

        //to string
        public override string ToString()
        {
            return Linha + ", " + Coluna;
        }
    }
}
