using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Tabuleiro;

namespace Xadrez.xadrez
{
    internal class Torre : Peca
    {
        //constructor
        public Torre (tabuleiro tab, Cor cor) : base (tab, cor)
        {
        }

        //when log the class, will return T;
        public override string ToString()
        {
            return "T";
        }
    }
}
