using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto
    {
        // Atributos
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        // Construtor

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        // construtor padrao

        public Produto()
        {

        }

        // Metodo para calculo de desconto

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }



    class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.2, 0.1);
            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3,
                //Desconto = 0.3

            };
            Produto.Desconto = 0.5;
            Console.WriteLine("Preco com desconto {0}",produto1.CalcularDesconto());
            Console.WriteLine("Preco com desconto {0}",produto2.CalcularDesconto());
        }
    }
}
