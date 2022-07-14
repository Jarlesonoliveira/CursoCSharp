using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            var nome = "Jarleson";
            Console.WriteLine(nome);
            //nome = 123;
            //Console.WriteLine(nome);

            //int idade;
            var idade = 30;
            Console.WriteLine(idade);

            int a; //declarando uma variável
            a = 3;//declarando é atribuindo uma variável em outra linha
            int b = 2;//declarando uma variável é inicializando a variável

            Console.WriteLine(a + b);
        }
    }
}
