
using xadrez.tabuleiro.Enum;
using tabuleiro;

namespace xadrez.xadrez
{
    internal class Torre : Peca

    {
        public Torre(Cor cor, Tabuleiro tabuleiro) : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "T";
        }

    }
}
