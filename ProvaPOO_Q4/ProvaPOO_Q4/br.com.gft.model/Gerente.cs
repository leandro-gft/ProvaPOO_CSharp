using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO_Q4.br.com.gft.model
{
    class Gerente : Funcionario
    {
        public Gerente(String nome, int idade, double salario) : base(nome, idade, salario)
        {

        }
        public override double bonificacao()
        {
            return Salario + 10000.00;
        }
    }
}
