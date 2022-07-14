using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisECostantes {
        public static void Executar() {
            //Area de cincunferência
            Double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1451

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é "+ area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo "+ estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade é "+idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols é "+ saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário é "+ salario);

            int menorValorInt = int.MinValue;// Mais usado dos inteiros!
            Console.WriteLine("Menor valor inteiro é"+menorValorInt);

            uint populacaoBrasileira = 200_600_000;
            Console.WriteLine(" População Brasileira é "+populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Valor Long é "+menorValorLong);

            ulong populaçãoMundial = 7_600_000_000;
            Console.WriteLine(" População Mundial é "+populaçãoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine(" Preço do Computador é "+precoComputador);

            double valorDeMarcadoDaApple = 1000_000_000_000.00;
            Console.WriteLine("Valor de mercado da Apple é "+valorDeMarcadoDaApple);// Mais usados dos reais!

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distácia entre estrelas é "+distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra é "+letra);

            string texto = "Seja bem vindo ao curso C#";
            Console.WriteLine(texto);
        }
    }
}
