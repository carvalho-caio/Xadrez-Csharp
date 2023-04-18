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
    internal class Peao: Peca
    {
        //construtor
        public Peao(tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        //when log the class, will return R;
        public override string ToString()
        {
            return "P";
        }

        //methods

        //idk
        private bool ExisteInimigo(Position pos)
        {
            Peca p = Tab.peca(pos);
            return p != null && p.Color != Color;
        }

        //livre
        private bool Livre(Position pos)
        {
            return Tab.peca(pos) == null;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linha, Tab.Colunas];

            Position pos = new Position(0, 0);

            if (Color == Cor.Branca)
            {
                pos.DefinirValores(posicao.Linha - 1, posicao.Coluna);
                if(Tab.PosicaoValida(pos) && Livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(posicao.Linha - 2, posicao.Coluna);
                if (Tab.PosicaoValida(pos) && Livre(pos) && QuantidadeMovimentos == 0)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(posicao.Linha - 1, posicao.Coluna - 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(posicao.Linha - 1, posicao.Coluna + 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }
            else
            {
                pos.DefinirValores(posicao.Linha + 1, posicao.Coluna);
                if (Tab.PosicaoValida(pos) && Livre(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(posicao.Linha + 2, posicao.Coluna);
                if (Tab.PosicaoValida(pos) && Livre(pos) && QuantidadeMovimentos == 0)
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(posicao.Linha + 1, posicao.Coluna - 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

                pos.DefinirValores(posicao.Linha + 1, posicao.Coluna + 1);
                if (Tab.PosicaoValida(pos) && ExisteInimigo(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }

            return mat;
        }
    }
}
