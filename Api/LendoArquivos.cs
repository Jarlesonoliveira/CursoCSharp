using System;
using System.IO;

namespace CursoCSharp.Api {
    class LendoArquivos {
        public static void Executar() {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            if (!File.Exists(path)) {
                //StreamWriter e para escrever no arquivo
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("Produto;Preco;Qtde");
                    sw.WriteLine("Caneta Bic Preta;3.59;89");
                    sw.WriteLine("Borracha Branca;2.89;27");
                }
            }

            try {
                //StreamReader e para ler o que está no arquivo
                using (StreamReader sr = new StreamReader(path)) {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
