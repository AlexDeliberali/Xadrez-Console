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
    }
}
