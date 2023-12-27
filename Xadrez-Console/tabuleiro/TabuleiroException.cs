using System;

namespace tabuleiro
{
    internal class TabuleiroException : Exception
    {
        //Criando uma exceção personalizada
        public TabuleiroException(string msg) : base(msg) { }
    }
}
