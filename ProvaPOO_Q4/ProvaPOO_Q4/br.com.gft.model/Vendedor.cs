using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO_Q4.br.com.gft.model
{
    class Vendedor : Funcionario
    {
        public Vendedor(String nome, int idade, double salario) : base(nome, idade, salario)
        {

        }
        public override double bonificacao()
        {
            return Salario + 3000.00;
        }
    }
}
