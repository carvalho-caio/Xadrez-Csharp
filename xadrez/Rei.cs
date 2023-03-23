using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Tabuleiro;

namespace Xadrez.xadrez
{
    internal class Rei : Peca
    {

        //construtor
        public Rei(tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        //when log the class, will return R;
        public override string ToString()
        {
            return "R";
        }
    }
}
