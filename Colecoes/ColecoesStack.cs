using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesStack {//Stack e o contrario de fila e motodo de pilha
        public static void Executar() {
            var pilha = new Stack();//Não ultiliza o Generic se for instanciar com new
            //Em pilha o Push é para adicionar a pilha
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach(var item in pilha) {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha) {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count);
        }
    }
}
