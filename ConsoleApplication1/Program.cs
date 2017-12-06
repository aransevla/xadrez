using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;
using System.Globalization;


namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                Tela.imprimirTabuleiro(partida.tab);
                
            }

            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}