using ProvaPOO_Q4.br.com.gft.model;
using System;

namespace ProvaPOO_Q4
{
    class main
    {
        static void Main(string[] args)
        {
            Gerente g = new Gerente("Leandro", 31, 15000.00);
            Supervisor s = new Supervisor("Ariane", 24, 7000.00);
            Vendedor v = new Vendedor("Gabriel", 24, 1500.00);

            Console.WriteLine("Gerente: " + g.Nome + " - Salario: " + g.bonificacao());
            Console.WriteLine("Supervisor: " + s.Nome + " - Salario: " + s.bonificacao());
            Console.WriteLine("Vendedor: " + v.Nome + " - Salario: " + v.bonificacao());

            Console.ReadKey();
        }
    }
}
