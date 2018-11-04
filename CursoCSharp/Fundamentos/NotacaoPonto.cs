using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "Olá".ToUpper().Insert(3, " World").Replace("World", "Mundo");
            Console.WriteLine(saudacao);
            Console.WriteLine("teste");
            string valorimportante = null;
            // o ponto de interrogação na notação ponto evita que o C# busque por algo que não exista ou esteja vazio
            // navegação segura
            Console.WriteLine(valorimportante?.Length);
        }
    }
}
