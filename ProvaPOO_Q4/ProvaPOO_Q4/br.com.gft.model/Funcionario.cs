using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaPOO_Q4.br.com.gft.model
{
	abstract class Funcionario
	{
		private double salario;
		private int idade;
		private String nome;

		public Funcionario(String nome, int idade, double salario)
		{
			this.Salario = salario;
			this.Nome = nome;
			this.Idade = idade;
		}

		public double Salario { get; set; }
		public int Idade { get; set; }
		public string Nome { get; set; }

		public virtual double bonificacao()
		{
			return salario;
		}

	}
}