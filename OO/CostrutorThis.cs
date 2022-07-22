using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    public class Animal {
        public string Nome { get; set; }

        public Animal(string nome) {
            Nome = nome;
        }
    }

    public class Cachorro : Animal {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome) {
            Console.WriteLine($"Cachorro {nome} inicializando");
        }

        public Cachorro(string nome, double altura) : this(nome) {
            Altura = altura;
        }
        //ToString() ele é responsável por transformar uma instância em uma string
        //Converte um objeto em string
        public override string ToString() {
            return $"{Nome} tem {Altura}cm de Altura!";
        }
    }
    class CostrutorThis {
        public static void Executar() {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40.0);

            //Console.WriteLine(spike); chamou de forma implicita o ToString()
            Console.WriteLine(spike);
            //Abaixo foi chamado de forma explicita o ToString()
            Console.WriteLine(max.ToString());
        }
    }
}
