using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesQueue {
        //Queue é uma estrutura da pra adicionar valores heterogeneos e dinamica que aceita 
        //repetição sem problema
        public static void Executar() {
            var fila = new Queue<string>();//Queue<string>() usa o Generic

            fila.Enqueue("Fulano");//Enqueue faz a ordem de fila na lista 
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Beltrano");//A estrutura Queue aceita repetição

            Console.WriteLine(fila.Peek());//Peek vai pegar o primeiro elemento que sera 
            //o proximo a sair da fida e exibi no console
            Console.WriteLine(fila.Count);
            Console.WriteLine(fila.Dequeue());//Dequeue desenfilera da fila
            Console.WriteLine(fila.Count);

            foreach(var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();//Queue() utiliza o Collections
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item"));//Contains informa se o item está 
            //contido na lista da a resposta true ou false
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
