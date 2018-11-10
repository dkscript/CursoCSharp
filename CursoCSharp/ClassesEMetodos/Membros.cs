using System;


namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "flavio";
            sicrano.Idade = 33;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 54;

            var ApresentcaoDefulano = fulano.Apresentar();
            Console.WriteLine(ApresentcaoDefulano);

            fulano.Zerar();
            fulano.ApresentarNoConsole();
        }
    }
}
