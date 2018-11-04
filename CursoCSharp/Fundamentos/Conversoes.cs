using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            int interiro = 10;
            double quebrado = interiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notatruncada = (int) nota;
            Console.WriteLine("Nota truncada {0}",notatruncada);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("idade inserida: {0}", idadeInteiro);
            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.Write("digite o segundo numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2 : {0}", numero2 );

        }
    }
}
