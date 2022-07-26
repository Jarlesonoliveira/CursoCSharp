using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class DelegateFunAnonima {
        delegate string StringOperacao(string s);

        public static void Executar() {
            //funão anonima com delegate é com o returno implicito do StringOperacao
            StringOperacao inverter = delegate (string s) {
                //s.ToCharArray(); converte a string em um array de caracteres
                char[] charArray = s.ToCharArray();
                //Reverse vai inverter esses caracteres que estão dentro do array
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine(inverter("C# é show!!!"));
        }
    }
}
