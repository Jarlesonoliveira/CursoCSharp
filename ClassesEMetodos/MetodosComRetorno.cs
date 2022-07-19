using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class CalculadoraComum {
        //Todo método dentro de uma classe tem uma assinatura única
        public int Somar(double a, int b) {
            return (int)a + b;
        }

        public int Substituir(double a, int b) {
            return (int)a - b;
        }

        public int Multiplicar(double a, int b) {
            return (int)a * b;
        }

        public int Dividir(double a, int b) {
            return (int)a / b;
        }
    }

    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Substituir(int a) {
            memoria -= a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Dividir(int a) {
            memoria /= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }

    }
    class MetodosComRetorno {
        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine(calculadoraComum.Substituir(9, 7));
            Console.WriteLine(calculadoraComum.Multiplicar(3, 6));
            Console.WriteLine(calculadoraComum.Dividir(20, 3));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            resultado = calculadoraCadeia.Somar(8).Multiplicar(2).Resultado();
            Console.WriteLine(resultado);
        }
    }
}
