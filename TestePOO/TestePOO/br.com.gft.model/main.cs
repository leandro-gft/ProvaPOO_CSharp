using System;
using System.Collections.Generic;
using TestePOO.br.com.gft.main;

namespace TestePOO
{
	class main
	{
		static void Main(string[] args)
		{
			Pessoa p1 = new Pessoa("João", 15);
			Pessoa p2 = new Pessoa("Leandro", 21);
			Pessoa p3 = new Pessoa("Paulo", 17);
			Pessoa p4 = new Pessoa("Jessica", 18);

			List<Pessoa> pes = new List<Pessoa>();
			pes.Add(p1);
			pes.Add(p2);
			pes.Add(p3);
			pes.Add(p4);

			Console.WriteLine("Elementos da lista: ");
			foreach (Pessoa pessoas in pes)
			{
				Console.WriteLine(pessoas.Nome + " - " + pessoas.Idade + " anos");

			}
			Console.WriteLine("");

			int older = 0;
			String nome = "";
			foreach (Pessoa pessoas in pes)
			{
				if (older < pessoas.Idade)
				{
					older = pessoas.Idade;
					nome = pessoas.Nome;
				}
			}
			Console.WriteLine("");
			Console.WriteLine("O mais velho é: " + nome);
			Console.WriteLine("");

			Console.WriteLine("Elementos da lista: ");
			foreach (Pessoa pessoas in pes)
			{
				Console.WriteLine(pessoas.Nome + " - " + pessoas.Idade + " anos");

			}
			Console.WriteLine("A lista possui " + pes.Count + " elementos");
			Console.WriteLine("");
			Console.WriteLine("Elementos da lista com idade maior ou igual a 18 anos: ");
			for (int i = 0; i < pes.Count; i++)
			{
				if (pes[i].Idade < 18)
				{
					pes.RemoveAt(i);
				}
				Console.WriteLine(pes[i].Nome + " - " + pes[i].Idade + " anos");

			}
			Console.WriteLine("A lista possui " + pes.Count + " elementos");
			Console.WriteLine("");
			Console.WriteLine("Elementos da lista com nome igual a Jessica: ");
			foreach (Pessoa pessoas in pes)
			{
				if (pessoas.Nome == "Jessica")
				{
					Console.WriteLine(pessoas.Nome + " - " + pessoas.Idade + " anos");
				}

			}
			Console.ReadKey();
		}
	}
}

 

