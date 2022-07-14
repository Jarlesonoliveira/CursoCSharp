using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            //quando não tem posibilidade de perda de informação
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);//implicitamente essa conversão foi feita

            //quando tem posibilidade de perda de informação
            double nota = 9.7;
            int notaTruncada = (int)nota;//conversão conhecida como cash
            Console.WriteLine("Nota Truncada: {0}", notaTruncada);/*conversão numérica 
            explicitamente essa conversão foi feita*/

            //conversões entre string e inteiro
            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);//usando o int.Parse
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);//usando o Try.Parse
            Console.WriteLine("Resultado 1: {0}", numero1);

            //esse metodo ele tenta fazer o Try.Parse
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);//usando o Try.Parse
            Console.WriteLine("Resultado 2: {0}", numero2);
        }
    }
}
