using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class DesafioAtributo {

        int a = 10;

        public static void Executar() {
            //Acessar variável "a" dentro do método Executar!
            //Console.WriteLine(a);
            //Precisa criar uma instância atribuir a uma variável e acessar com a 
            //notação ponto.

            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);

        }
    }
}
