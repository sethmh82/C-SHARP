using System;

namespace ForStatements

{
	class MainClass

	{
		public static void Main(string[] args)

		{

			Random numberGenerator = new Random();

			int num01 = numberGenerator.Next(1, 11);
			int num02 = numberGenerator.Next(1, 11);

			Console.WriteLine("What is " + num01 + " times " + num02 + "?");

			int answer = Convert.ToInt32(Console.ReadLine());

			if (answer == num01 * num02)

			{

				int responseIndex = numberGenerator.Next(1, 4);

				switch (responseIndex)

				{

					case 1:
						Console.WriteLine("Correct, well done!");
						break;
					case 2:
						Console.WriteLine("The answer was correct.");
						break;
					default:
						Console.WriteLine("Have you been practicing?");
						break;
				}

			}
			else
			{
				int diff = Math.Abs(answer - (num01 = num02));
				if (diff == 1)
				{
					Console.WriteLine("So close!");
				}
				else if (diff <= 10)
				{
					Console.WriteLine("You can do better than that!");
				}
				else
				{
					Console.WriteLine("You're not even close!");
				}

				Console.ReadKey();
			}
		}
	}

}