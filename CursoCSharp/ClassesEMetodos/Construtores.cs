using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Carro
    {
        // atributos da classe Carro, inicia com a primeira letra maiuscula
        public string Modelo;
        public string Fabricante;
        public int Ano;

        // criando um construtor para a classe Carro, parametros do construtor inicia com letra miniscula, evita conflito de nome
        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;

        }

        // criado construtor padrao de forma implicita

        public Carro()
        {

        }

    }

    class Construtores {
        public static void Executar() {
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;

            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("GM", "Celta", 2004);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            // instaciando um objeto e ja adicionando os seus valores com um construtor padrão
            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");

        }
    
    }
}
