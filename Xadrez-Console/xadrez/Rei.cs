using System;
using tabuleiro;

namespace xadrez
{
    class Rei : Peca {
        //Criando o objeto Rei
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) { 
        }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            #region validaPosicoes

            //Verificando acima se está livre ou com outra peça
            pos.definirValores(pos.linha - 1, pos.coluna);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Verificando nordeste se está livre ou com outra peça
            pos.definirValores(pos.linha - 1, pos.coluna+1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Verificando leste se está livre ou com outra peça
            pos.definirValores(pos.linha, pos.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Verificando sudeste se está livre ou com outra peça
            pos.definirValores(pos.linha + 1, pos.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Verificando norte se está livre ou com outra peça
            pos.definirValores(pos.linha + 1, pos.coluna);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Verificando sudoeste se está livre ou com outra peça
            pos.definirValores(pos.linha + 1, pos.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Verificando oeste se está livre ou com outra peça
            pos.definirValores(pos.linha, pos.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            //Verificando noroeste se está livre ou com outra peça
            pos.definirValores(pos.linha - 1, pos.coluna- 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            #endregion

            return mat;
        }
    }
}
