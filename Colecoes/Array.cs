using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Array {
        public static void Executar() {
            //Array é uma estrutura homogênea so pode ter um tipo dentro do Array ex: string
            //Array também é uma estrutura estática tem um tamanhã fixo e posições
            //Array é uma estrutura indexada acessa os elemento a partir do indice
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Jarleson";
            alunos[2] = "Raynara";
            alunos[3] = "Christian";
            alunos[4] = "Caio";
            foreach(var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 8.5, 7.6, 6.8, 8.6 };
            foreach(var nota in notas) {
                somatorio += nota;
            }
            //Ambos os exemplos tanto forech quanto o for dar o mesmo resultado
            //for (int i = 0; i < notas.length; i++) {
            //    somatorio += notas[i]
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
