using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Readonly
    {
        public class Cliente
        {
            public string Nome;
            readonly DateTime Nascimento;

            //construtor
            public Cliente(string nome,DateTime nascimento)
            {
                Nome = nome;
                Nascimento = nascimento;
            }
            //construtor padrao

            public Cliente()
            {

            }

            public string GetDataDeNascimento()
            {
                return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
            }

        }


        public static void Executar()
        {
            var novoCliente = new Cliente("Flavio nunes", new DateTime(1985, 6, 20));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());


        }
    }
}
