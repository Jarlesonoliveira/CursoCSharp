using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;

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
                {"Estrutura if - Estrutura de Controle ", EstruturaIf.Executar},
                {"Estrutura If é Else - Estrutura de Controle", EstruturaIfElse.Executar},
                {"Estrutura If é Else If - Estrutura de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estrutura de Controle", EstruturaDoWhile.Executar},
                {"Estrutura for - Estrutura de Controle", EstruturaFor.Executar},
                {"Estrutura forheach - Estrutura de Controle", EstruturaForEach.Executar},
                {"Estrutura break - Estrutura de Controle", EstruturaBreak.Executar},
                {"Estrutura continue - Estrutura de Controle", EstruturaContinue.Executar},

                // Classes e Membros
                {"Membros - Classes e Métodos ", Membros.Executar},
                {"Construtores - Classes e Métodos ", Construtores.Executar},
                {"Metodos Com Retorno - Classes e Métodos ", MetodosComRetorno.Executar},
                {"Metodos Estáticos - Classes e Métodos ", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Métodos ", AtributosEstaticos.Executar},
                {"Desafio Atributo  - Classes e Métodos ", DesafioAtributo.Executar},
                {"Params - Classes e Métodos ", Params.Executar},
                {"Get Set - Classes e Métodos ", GetSet.Executar},
                {"Propriedades - Classes e Métodos ", Props.Executar},
                {"Readonly - Classes e Métodos ", Readonly.Executar},
                {"Exemplos Enum - Classes e Métodos ", ExemploEnum.Executar},
                {"Struct - Classes e Métodos ", ExemploStruct.Executar},
                {"Struct Vs Classe - Classes e Métodos ", StructVsClasse.Executar},
                {"Valor Vs Referencia - Classes e Métodos ", ValorVsReferencia.Executar},
                {"Parametros Por Referencia - Classes e Métodos ", ParametrosPorReferencia.Executar},
                {"Out Conceito - Classes e Métodos ", OutConceito.Executar},
                {"ParametroPadrao - Classes e Métodos ", ParametroPadrao.Executar},

                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}