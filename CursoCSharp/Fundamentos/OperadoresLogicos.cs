using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var ExecutouTrabalho1 = true;
            var ExecutouTrabalho2 = false;

            var comprouTV50 = ExecutouTrabalho1 && ExecutouTrabalho2;
            Console.WriteLine("Comprou a tv 50? {0}", comprouTV50);

            var comprouSorvete = ExecutouTrabalho1 || ExecutouTrabalho2;
            Console.WriteLine("Comprou sorvete? {0}", comprouSorvete);

            var comprouTv32 = ExecutouTrabalho1 ^ ExecutouTrabalho2;
            Console.WriteLine("Comprou tv 32? {0}",comprouTv32);
            //operador unario
            Console.WriteLine("Mais saudavel? {0}", !comprouSorvete);
        }
    }
}
