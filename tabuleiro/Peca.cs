namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QtdMovimentos { get; set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            Posicao = posicao;
            Cor = cor;
            Tabuleiro = tab;
            QtdMovimentos = 0;
        }
    }
}
