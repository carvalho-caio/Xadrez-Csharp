using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace Xadrez.Tabuleiro
{
    internal class Peca
    {
        public Position posicao { get; set; }
        public Cor Color { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; }
        public tabuleiro Tab { get; protected set; }

        public Peca(tabuleiro tab, Cor cor)
        {
            posicao = null;
            Tab = tab;
            Color = cor;

            this.QuantidadeMovimentos = 0;
        }

    }
}
