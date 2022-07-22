using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public class Carro {
        //Protected um modificador que trabalha por herança
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int alterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }
        //virtual é um modificador que autoriza ser sobrescrito
        //Se não colocar o metodo virtual não pode ser sobrescrito
        public virtual int Acelerar() {
            return alterarVelocidade(5);
        }

        public int Frear() {
            return alterarVelocidade(-5);
        }
    }
    //No caso abaixo nçao tem o construtor padrão que seria "public Carro() { };"
    //No caso abaixo precisa definir um construtor que seria Ex:"public Uno() :base()"
    //Com a ausencia do contrutor padrão abaixo precisa explicitamente chamar o construtor padrão
    public class Uno : Carro {
        public Uno() : base(200) {

        }
    }

    public class Ferrari : Carro {
        public Ferrari() : base(350) {

        }
        //override vai sobrescrever um metodo que foi definido na classe pai
        //pra sobscrever precisa marcar como virtual "Acelerar" para a alteração de compatibilidade 
        public override int Acelerar() {
            return alterarVelocidade(15);
        }

        //Oculta o metodo da classe pai
        //Precisa do tipo da variável ser referênciada nesse caso o tipo "new" é "Ferrari"
        public new int Frear() {
            return alterarVelocidade(-15);
        }
    }
    class Heranca {
        public static void Executar() {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com o tipo Carro...");
            Carro carro3 = new Ferrari();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com o tipo Carro...");
            carro3 = new Uno();// Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
        }
    }
}
