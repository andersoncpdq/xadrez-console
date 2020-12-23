using System;
using tabuleiro;
using xadrez;
using Exceptions;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos.ToString());

            Console.WriteLine(pos.ToPosicao());
        }
    }
}
