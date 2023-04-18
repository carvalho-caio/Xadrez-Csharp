﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;
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
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
                if(Tab.peca(pos) != null && Tab.peca(pos).Color != Color)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }

            //abaixo
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Color != Color)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }

            //direita
            pos.DefinirValores(posicao.Linha, posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Color != Color)
                {
                    break;
                }
                pos.Coluna = pos.Coluna + 1;
            }

            //esquerda
            pos.DefinirValores(posicao.Linha, posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                Mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Color != Color)
                {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
            }

            return Mat;
        }
    }
}
