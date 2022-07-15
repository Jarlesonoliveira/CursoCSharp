using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"VáiavesECostantes - Fundamentos", VariaveisECostantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores é Atibuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternário - Fundamentos", OperadorTernario.Executar},
                //Estruturas de controle
                {"Estrutura if ", EstruturaIf.Executar},
                {"Estrutura If é Else", EstruturaIfElse.Executar},
                {"Estrutura If é Else If", EstruturaIfElseIf.Executar},
                {"Estrutura Switch", EstruturaSwitch.Executar},
                {"Estrutura While", EstruturaWhile.Executar},
                {"Estrutura Do While", EstruturaDoWhile.Executar},
                {"Estrutura for", EstruturaFor.Executar},
                {"Estrutura forheach", EstruturaForEach.Executar},
                {"Estrutura break", EstruturaBreak.Executar},
                {"Estrutura continue", EstruturaContinue.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}