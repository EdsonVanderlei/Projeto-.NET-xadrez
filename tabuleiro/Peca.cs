using System;
using System.Collections.Generic;
using System.Text;
using xadrez.tabuleiro.Enum;

namespace tabuleiro
{
    internal abstract class Peca
    {

        public Cor Cor { get; protected set; }
        public Posicao Posicao { get; set; }
        public Tabuleiro Tabuleiro { get; set; }
        public int QtdMovimentos { get; set; }

        public  Peca(Cor cor, Tabuleiro tabuleiro)
        {
            Cor = cor;
            Posicao = null;
            Tabuleiro = tabuleiro;
            QtdMovimentos = 0;
        }
    }
}
