using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            //uma casa decimal
            Console.WriteLine(valor.ToString("F1"));
            //valor monetario
            Console.WriteLine(valor.ToString("C"));
            //percentual
            Console.WriteLine(valor.ToString("P"));
            //formatacao especifica
            Console.WriteLine(valor.ToString("#.##"));
            //padrao monetario diferente
            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0",cultura));
            int inteiro = 256;
            //forcar completar com zeros
            Console.WriteLine(inteiro.ToString("D10"));

        }
    }
}
