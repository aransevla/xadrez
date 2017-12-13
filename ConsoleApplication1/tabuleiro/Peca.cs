using System;
using xadrez;
using tabuleiro;

namespace tabuleiro {
    abstract class Peca {
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
        public void decrementarQteMovimentos()
        {
            qMovimentos--;
        }

        public bool existeMovimentosPossiveis() {
            bool[,] mat = movimentosPossiveis();
            for (int i=0; i<tab.linhas;i++) {
                for (int j=0;j<tab.colunas;j++) {
                    if (mat[i,j]) {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool movimentoPossivel(Posicao pos) {
            return movimentosPossiveis()[pos.linha, pos.coluna];

        }

        public abstract bool[,] movimentosPossiveis();
    }
}
