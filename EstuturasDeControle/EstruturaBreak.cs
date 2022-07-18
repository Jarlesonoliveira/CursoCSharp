using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaBreak {
        public static void Executar() {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("{0} é o numero que queremos {0}. ", numero);

            for (int i = 1; i <= 50; i++) {
                Console.Write("{0} é o numero que queremos? ", i);
                if (i == numero) {
                    Console.WriteLine("Sim!");
                    break;// Depois que encontrou o numero ele sai do laço
                } else {
                    Console.WriteLine("Não!");
                }
            }
            Console.WriteLine("Fim!");
        }

    }
}
