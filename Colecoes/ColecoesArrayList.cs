using System;
using System.Collections;// ArrayList não usa Generic 
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesArrayList {
        public static void Executar() {
            var arrayList = new ArrayList {
                //uma lista de tipos de dados heterogeneos 
                "Palavra",
                3,
                true
            };

            arrayList.RemoveAt(2);
            arrayList.Add(3.14);
            //arrayList.Count;

            foreach(var item in arrayList) {
                //GetType pra saber qual foi o tipo inferido a parte do array
                //com multiplos valores heterogeneos
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}
