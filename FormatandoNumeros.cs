using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));//"F1" formata para uma única casa décimal
            Console.WriteLine(valor.ToString("C"));//"C" transforma em um valor monetário
            Console.WriteLine(valor.ToString("P"));//"P" transforma em um valor pércentual 
            Console.WriteLine(valor.ToString("#.##"));//"P" um número com duas casas decimais

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura));/*"C0"Inprimir em dinheiro sem 
            casa decimal*/

            CultureInfo culturas = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", culturas));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
