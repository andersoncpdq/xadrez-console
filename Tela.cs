using tabuleiro;
using System;
using xadrez;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (tabuleiro.Peca(i, j) != null)
                    {
                        ImprimirPeca(tabuleiro.Peca(i, j));
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirPeca(Peca p)
        {
            if (p.Cor == Cor.Branca)
            {
                Console.Write(p);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(p);
                Console.ForegroundColor = aux;
            }
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");

            return new PosicaoXadrez(coluna, linha);
        }
    }
}
