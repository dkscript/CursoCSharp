using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaWhile {
        public static void Executar() {
            int palpite = 0;
            Random randon = new Random();
            int numeroSecreto = randon.Next(1, 51);
            bool numeroEncontrado = false;
            int tentativaRestantes = 5;
            int tentativasAtuais = 0;

            while (tentativaRestantes > 0 && !numeroEncontrado) {
                Console.WriteLine("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativasAtuais++;
                tentativaRestantes--;
                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas",tentativasAtuais);
                    Console.BackgroundColor = corAnterior;

                }else if (palpite > numeroSecreto) {
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine("Tentativas restarntes {0}",tentativaRestantes);

                }else {
                    Console.WriteLine("Maior.. Tente novamente!");
                    Console.WriteLine("Tentativas restarntes {0}", tentativaRestantes);
                }
            }
          
        }
    }
}
