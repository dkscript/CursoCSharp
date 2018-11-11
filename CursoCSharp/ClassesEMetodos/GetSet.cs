using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class GetSet
    {

        public class Moto
        {
            private string Marca;
            private string Modelo;
            private int Cilindrada;

            // construtor da classe Moto
            public Moto(string marca, string modelo, int cilindrada)
            {
                //Marca = marca;
                //Modelo = modelo;
                //Cilindrada = cilindrada;

                SetMarca(marca);
                SetModelo(modelo);
                SetCilindrada(cilindrada);

            }

            // construtor padrao para classe Moto
             public Moto()
            {

            }

            // Metodos para get e set ------

            public string GetMarca()
            {
                return Marca;
            }

            public void SetMarca(string marca)
            {
                Marca = marca;
            }

            public string GetModelo()
            {
                return Modelo;
            }

            public void SetModelo(string modelo)
            {
                Modelo = modelo;
            }

            public int GetCilindrada()
            {
                return Cilindrada;
            }

            public void SetCilindrada(int cilindrada)
            {
                // Para evitar inserir um valor negativo
                //if (cilindrada > 0)
                //{
                //    Cilindrada = cilindrada;
                //}

                //Cilindrada = Math.Abs(cilindrada);

                Cilindrada = cilindrada;
            }

        }

        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());
        }
    }
}
