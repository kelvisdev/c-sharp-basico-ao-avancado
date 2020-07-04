using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    public class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + "."); // Concatenar
            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco); // Com indices
            Console.WriteLine($"A marca {marca} é legal! {1 + 1}"); // String Interpolation
        }
    }
}
