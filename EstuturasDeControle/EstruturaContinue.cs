using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaContinue {
        public static void Executar() {
            int intervalo = 50;
            Console.WriteLine("Numeros pares entre 1 {0}!", intervalo);

            for (int i = 1; i <= intervalo; i++) {
                if (i % 2 == 1) {
                    continue;
                }

                Console.Write(i + " ");
            }

            for (int i = 2; i <= intervalo; i += 2) {
                Console.Write(i + " ");
            }

            
        }
    }
}