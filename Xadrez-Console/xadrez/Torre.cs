using System;
using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        //Criando o objeto Rei
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
