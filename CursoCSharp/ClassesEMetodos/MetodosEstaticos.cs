using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        // metodo de classe ou metodo estatico!!
        public static int Somar(int a, int b)
        {
            return a + b;

        }
        // metodo de instancia
        public  int Multiplicar(int a ,int b)
        {
            return a * b;
        }
    }



    class MetodosEstaticos
    {
        public static void Executar()
        {
            // não precisa instanciar a variavel, pode chamar a classe direto
            var resultado = CalculadoraEstatica.Somar(2, 2);
            Console.WriteLine(resultado);

            // precisa criar uma instancia para ter acesso aos metodos
            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Multiplicar(2,2));
        }
    }
}
