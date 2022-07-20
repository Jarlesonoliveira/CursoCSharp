using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    //Por padrão o metodo de uma interface ele é public
    interface Ponto {
        void MoverParaDiagonal(int Delta);
    }

    struct Coordenada : Ponto {
        public int X;
        public int Y;

        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }

        public void MoverParaDiagonal(int Delta) {
            X += Delta;
            Y = Delta;
        }

    }

    class ExemploStruct {
        public static void Executar() {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada Inicial:");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 9, y: 1);
            coordenadaFinal.MoverParaDiagonal(10);

            Console.WriteLine("Coordenada Final:");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);
        }
    }
}
