﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
    }

    class StructVsClasse {
        public static void Executar() {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };//Se trata de uma "struct"
            SPonto copiaPonto1 = ponto1;// Atribuição por VALOR!!!
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 x:{0}", ponto1.X);
            Console.WriteLine("copiaPonto 1 x:{0}", copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 2, Y = 5 };//Se trata de uma "classe"
            CPonto copiaPonto2 = ponto2;// Atribuição por REFERÊNCIA!!!
            ponto2.X = 4;

            Console.WriteLine("Ponto 2 x:{0}", ponto2.Y);
            Console.WriteLine("copiaPonto 2 x:{0}", copiaPonto2.Y);
        }
    }
}
