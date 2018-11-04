using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("area é: " + (area + 1000));
            bool EstaChovendo = true;
            Console.WriteLine("Esta chovendo: " + EstaChovendo);
            //byte idade = 45;
            sbyte saldoDeGols = sbyte.MinValue;
        
            Console.WriteLine(saldoDeGols);
            short salario = short.MaxValue;
            Console.WriteLine(salario);
            int menorValorInt = int.MinValue;
            Console.WriteLine(menorValorInt);
            uint populacaoBrasileira = uint.MaxValue;
            Console.WriteLine("Populacao Brasileira " + populacaoBrasileira);

            }
    }
}
