using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class OutConceito {
        public static void Executar() {
            string str = "100";
            if (int.TryParse(str, out int num)) {
                Console.WriteLine("{0}", num + 1);
            } else {
                Console.WriteLine("A conversão falhou!");
            }
        }
    }
}
