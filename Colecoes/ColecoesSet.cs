using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {

    class ColecoesSet {
        public static void Executar() {
            var livro = new Produto("Game of thrones", 49.9);

            //HashSet e uma estrutura que não é indexada o "Set" não aceita repetição
            //não pode ser removido não pode pegar itens
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);//Add para adicionar um elemento na lista

            
            var combo = new HashSet<Produto> {
            new Produto("Camisa", 29.9),
            new Produto("8º Temporada Game of thrones", 89.9),
            new Produto("Poster", 10.9)
            };

            
            carrinho.UnionWith(combo);//Vai alterar o carrinho pra unir ao combo
            Console.WriteLine(carrinho.Count);//Count você ver o tamanho da lista
            //carrinho.RemoveAt(3);

            foreach(var item in carrinho) {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            //Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
