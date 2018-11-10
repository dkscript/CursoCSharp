using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class DesfioAtributo
    {
        int a = 10;

        public static void Executar()
        {
            // Acessar a variavel a;
            DesfioAtributo valor = new DesfioAtributo();
            Console.WriteLine("O Valor da variavel a é igual = {0}",valor.a);
        }
    }
}
