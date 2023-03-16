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
        public Tabuleiro Tab { get; protected set; }

        public Peca(Position posicai, Tabuleiro tab, Cor cor)
        {
            posicao = posicai;
            Tab = tab;
            Color = cor;

            this.QuantidadeMovimentos = 0;
        }

    }
}
