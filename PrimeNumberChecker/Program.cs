using System;

namespace PrimeNumberChecker
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("enter a number to generate all of the primary numbers before it");

			int input = 0;

			try
			{
				input = Int32.Parse(Console.ReadLine());
			}

			catch
			{
				Console.WriteLine("invalid input");
			}

			for (int i = 2; i <= input; i++)
			{
				if (i == 2 || i == 3 || i == 5 || i == 7 || i == 11)
				{
					Console.WriteLine(i);
				}
				else if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i % 11 != 0)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}

