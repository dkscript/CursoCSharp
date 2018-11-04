using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadorTernario {
        public static void Executar() {
            //(expressao ? operando1 : operando2)
            var nota = 6.0;
            var resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
