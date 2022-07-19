using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class CalculadoraEstatica {
        //Método de intância
        public int Somar(int a, int b) {
            return a + b;
        }
        //Método de Classe ou Método estático!!!
        public static int Multiplicar(int a, int b) {
            return a * b;
        }
    }

    class MetodosEstaticos {
        //Quando é utilizado o "static" o médodo não pertence ao objeto é sim a classe
        //o mesmo tem que ser instânciado com o "new"
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));
            Console.WriteLine(CalculadoraEstatica.Multiplicar(2, 2));


        }
    }
}
