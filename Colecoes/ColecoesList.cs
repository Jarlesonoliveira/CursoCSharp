using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
    class ColecoesList {
        public static void Executar() {
            var livro = new Produto("Game of thrones", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);//Add para adicionar um elemento na lista

            //Criando uma lista com os proprios produtos diretamente na construção
            var combo = new List<Produto> {
            new Produto("Camisa", 29.9),
            new Produto("8º Temporada Game of thrones", 89.9),
            new Produto("Poster", 10.9)
            };

            //AddRange adiciona os itens de uma so vez
            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);//Count você exibe o tamanho da lista
            carrinho.RemoveAt(3);//RemoveAt remove por indice o elemento de uma lista

            foreach(var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
