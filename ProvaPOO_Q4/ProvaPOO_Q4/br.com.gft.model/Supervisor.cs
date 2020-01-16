using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO_Q4.br.com.gft.model
{
    class Supervisor : Funcionario
    {
        public Supervisor(String nome, int idade, double salario) : base(nome, idade, salario)
        {

        }
        public override double bonificacao()
        {
            return Salario + 5000.00;
        }
    }
}
