using System;
using System.Collections.Generic;
using System.Text;

namespace TestePOO.br.com.gft.main
{
	class Pessoa
	{

		public Pessoa(string nome, int idade)
		{
			this.Nome = nome;
			this.Idade = idade;

		}

		private string nome;
		private int idade;

		public string Nome { get; set; }
		public int Idade { get; set; }


	}
}
