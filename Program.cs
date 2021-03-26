using System;

public class Controlefluxoand
{
	static void Main(string[] args)
	{
		int idade = 20;

		if (idade > 15 &&  idade < 18)
	{
			Console.WriteLine("SUB-17");
		}
	else if (idade > 17 && idade < 21)
	{
			Console.WriteLine("SUB-20");
		}
	else if (idade > 21 && idade < 24)
	{
			Console.WriteLine("SUB-23");
		}
		Console.Read();
	}
}

