using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;
using Xadrez.Tabuleiro;

namespace Xadrez.xadrez
{
    internal class Bispo : Peca
    {
        public Bispo(tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        private bool PodeMover(Position pos)
        {
            Peca p = Tab.peca(pos);
            return p == null || p.Color != Color;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] Mat = new bool[Tab.Linha, Tab.Colunas];

            Position pos = new Position(0, 0);

            //Noroeste
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Color != Color)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna - 1);
            }

            //Nordeste
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Color != Color)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha - 1, pos.Coluna + 1);
            }

            //Sudeste
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Color != Color)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);
            }

            //Sudoeste
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Color != Color)
                {
                    break;
                }
                pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);
            }

            return Mat;
        }


        //when log the class, will return R;
        public override string ToString()
        {
            return "B";
        }
    }
}
