using System;


namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "flavio";
            sicrano.Idade = 33;
            Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");
        }
    }
}
