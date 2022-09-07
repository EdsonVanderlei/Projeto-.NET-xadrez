using System;
using tabuleiro;
using xadrez.xadrez;
using xadrez.tabuleiro.Enum;


namespace xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Posicao P = new Posicao(4, 5);
                Console.WriteLine("Posição: " + P.ToString());


                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(Cor.Branca, tab), new Posicao(0, 4));


                Tela.ImprimirTabuleiro(tab);
              }
            catch(TabuleiroException e )
            {
                Console.WriteLine(e.Message);  
            }


        }
    }
}
