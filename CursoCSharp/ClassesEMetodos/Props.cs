using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Props
    {
        public class CarroOpcional
        {
            // este atributo é privado por padrao
            double desconto = 0.1;

            string nome;
            public string Nome {
                get {
                    return "Opcional " + nome;
                }
                set {
                    // value palavra reservada que pega o parametro digitado
                    nome = value;
                }
            }

            // propriedade autoimplementada
            public double Preco { get; set; }

            // somente leitura
            public double PrecoComDesconto {
                get => Preco - (desconto * Preco); // Lambda

                // outra alternativa

                //get {
                //    return Preco - (desconto * Preco);
                //}
            }

            // construtor padrao

            public CarroOpcional()
            {

            }

            public CarroOpcional(string nome,double preco)
            {
                //alterando diretamente
                //this.nome = nome;
                //alterando atraves da propriedade
                Nome = nome;
                Preco = preco;
            }
        }
        public static void Executar()
        {
            // criando um carro
            var op1 = new CarroOpcional("Ar condicionado", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto);
            //op1.PrecoComDesconto = 3000;
            Console.WriteLine();

            // criando um novo carro

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.9;
            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);
            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);
                                      
            
        }
    }
}
