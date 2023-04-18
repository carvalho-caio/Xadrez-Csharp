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
    internal class Cavalo : Peca
    {
        public Cavalo(tabuleiro tab, Cor cor) : base(tab, cor)
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

            //1
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna - 2);
            if(Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
            }

            //2
            pos.DefinirValores(posicao.Linha - 2, posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
            }

            //3
            pos.DefinirValores(posicao.Linha - 2, posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
            }

            //4
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna + 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
            }

            //5
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna + 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
            }

            //6
            pos.DefinirValores(posicao.Linha + 2, posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
            }

            //7
            pos.DefinirValores(posicao.Linha + 2, posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
            }

            //8
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna - 2);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
            }

            return Mat;
        }


        //when log the class, will return R;
        public override string ToString()
        {
            return "C";
        }
    }
}
