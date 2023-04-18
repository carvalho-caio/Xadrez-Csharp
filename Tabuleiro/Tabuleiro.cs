using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;
using Xadrez.xadrez;

namespace Xadrez.Tabuleiro
{
    internal class tabuleiro
    {
        public int Linha { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public tabuleiro(int linha, int coluna)
        {
            Linha = linha;
            Colunas = coluna;
            Pecas = new Peca[linha, coluna];
        }
        
        public Peca peca (int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        //sobrecarga;
        public Peca peca(Position pos)
        {
            return Pecas[pos.Linha, pos.Coluna];
        }

        public bool ExistePeca (Position pos)
        {
            ValidarPosicao(pos);
            return peca(pos) != null;
        }

        public void ColocarPeca (Peca p, Position pos)
        {
            //teste para ver se já tem uma peça no local em que a peça vai ser colocada, se tiver, joga um erro;
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peca nessa posicao.");
            }
            Pecas[pos.Linha, pos.Coluna] = p;

            p.posicao = pos;
        }

        public Peca RetirarPeca(Position pos)
        {
            if(peca(pos) == null)
            {
                return null;
            }

            Peca aux = peca(pos);
            aux.posicao = null;
            Pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }

        public bool PosicaoValida(Position pos)
        {
            if(pos.Linha < 0 || pos.Linha >= Linha || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ValidarPosicao(Position pos)
        {
            if(!PosicaoValida(pos))
            {
                throw new TabuleiroException("Invalid position!");
            }
        }
    }
}
