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
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(Cor.Amarela, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Rei(Cor.Amarela, tab), new Posicao(1, 3));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
