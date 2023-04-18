﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;
using Xadrez.Tabuleiro;

namespace Xadrez.xadrez
{
    internal class Rei : Peca
    {

        //construtor
        public Rei(tabuleiro tab, Cor cor) : base(tab, cor)
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

            //acima
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
            }

            //nordeste
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
            }

            //direita
            pos.DefinirValores(posicao.Linha, posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
            }

            //sudeste
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
            }

            //abaixo
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
            }

            //sudoeste
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
            }

            //esqueda
            pos.DefinirValores(posicao.Linha, posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
            }

            //noroeste
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
            }

            return Mat;
        }


        //when log the class, will return R;
        public override string ToString()
        {
            return "R";
        }
    }
}
