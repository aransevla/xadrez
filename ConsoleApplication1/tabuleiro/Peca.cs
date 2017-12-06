﻿using System;
using xadrez;
using tabuleiro;

namespace tabuleiro {
    class Peca {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor) {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qMovimentos = 0;

        }

        public Peca(Tabuleiro tab, Cor cor) {
            this.tab = tab;
            this.cor = cor;
        }

        public void incrementarQteMovimentos () {
            qMovimentos++;
        }
    }
}
