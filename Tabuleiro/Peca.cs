using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace Xadrez.Tabuleiro
{
    internal abstract class Peca
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

        //implementação não está nessa classe
        public abstract bool[,] MovimentosPossiveis();


        public bool ExisteMoviemntosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < Tab.Linha; i++)
            {
                for (int j = 0; j < Tab.Colunas; j++)
                {
                    if (mat[i, j] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool MovimentoPossivel(Position pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public void IncrementarQtdMovimentos()
        {
            QuantidadeMovimentos++;
        }

        public void DecrementarQtdMovimentos ()
        {
            QuantidadeMovimentos--;
        }

    }
}
