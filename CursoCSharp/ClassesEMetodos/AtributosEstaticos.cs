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
        public double Desconto = 0.1;

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

       
        
        }
    }
}
