using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        public bool Terminada { get; private set; }
        private int Turno;
        private Cor JogadorAtual;

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;

            ColocarPecas();
        }

        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarQtdMovimentos();
            Peca pecaCapturada = Tab.RetirarPeca(destino);
            Tab.ColocarPeca(p, destino);
        }

        public void ColocarPecas()
        {
            Tab.ColocarPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('c', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Cor.Amarela, Tab), new PosicaoXadrez('c', 8).ToPosicao());
        }
    }
}
