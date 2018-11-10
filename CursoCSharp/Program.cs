using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() 
            {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"VariaveisEConstantes - Fundamentos", VariaveisEConstantes.Executar},
                { "inferencia - Fundamentos", inferencia.Executar},
                { "Interpolacao - Fundamentos", Interpolacao.Executar},
                { "NotacaoPonto - Fundamentos", NotacaoPonto.Executar},
                { "LendoDados - Fundamentos", LendoDados.Executar},
                { "FormatandoNumero - Fundamentos", FormatandoNumero.Executar},
                { "Conversoes - Fundamentos", Conversoes.Executar},
                { "OperadoresAritimeticos - Fundamentos", OperadoresAritimeticos.Executar},
                { "OperadoresRelacionais - Fundamentos", OperadoresRelacionais.Executar},
                { "OperadoresLogicos - Fundamentos", OperadoresLogicos.Executar},
                { "OperadoresAtribuicao - Fundamentos", OperadoresAtribuicao.Executar},
                { "OperadorUnario - Fundamentos", OperadorUnario.Executar},
                { "OperadorTernario - Fundamentos", OperadorTernario.Executar},
                //Estruturas de controle
                { "EstruturaIf - Estruturas de controle", EstruturaIf.Executar},
                { "EstruturaIfElse - Estruturas de controle", EstruturaIfElse.Executar},
                { "EstruturaSwitch - Estruturas de controle", EstruturaSwitch.Executar},
                { "EstruturaWhile - Estruturas de controle", EstruturaWhile.Executar},
                { "EstruturaDoWhile - Estruturas de controle", EstruturaDoWhile.Executar},
                { "EstruturaFor - Estruturas de controle", EstruturaFor.Executar},
                { "EstruturaForEach - Estruturas de controle", EstruturaForEach.Executar},
                { "UsandoBreak - Estruturas de controle", UsandoBreak.Executar},
                //Classes e Metodos
                { "Membros - Classes e Metodos", Membros.Executar},
                { "Construtores - Classes e Metodos", Construtores.Executar},
                { "MetodosComRetorno - Classes e Metodos", MetodosComRetorno.Executar},
                { "MetodosEstaticos - Classes e Metodos", MetodosEstaticos.Executar},
                { "AtributosEstaticos - Classes e Metodos", AtributosEstaticos.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}