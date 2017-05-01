using System;

namespace WhileLoop
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Random numberGen = new Random();

			int numberOfAttempts = 0;
			int attempt = 0;

			while (attempt != 6)
			{
				attempt = numberGen.Next(1, 7);
				Console.WriteLine("Seth rolled: " + attempt + ".");
				numberOfAttempts++;
			}

			Console.WriteLine("It took Seth " + numberOfAttempts + " attempts to roll a six.");

			Console.ReadKey();



		}
	}
}
