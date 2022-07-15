using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaFor {
        public static void Executar() {
            //Laço for poder ser feito com uma quantidade determinada
            for (int i = 1; i < 10; i++) {
                Console.WriteLine($"O valor de i é {i}.");
            }
        }
    }
}
