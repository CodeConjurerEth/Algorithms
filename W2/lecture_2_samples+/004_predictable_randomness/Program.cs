using System;

class Program
{
	static void Main(string[] args)
	{
		randomDemo1();

		Console.ReadLine();
	}

	/**
	 * Demonstrate random without explicit seed
	 */
	static void randomDemo1()
	{
		//no seed will use the current system time as seed
		Random random = new Random();
		for (int i = 0; i < 10; i++)
		{
			//use 10 as maximum for easier recognition in the output
			Console.WriteLine(random.Next(10));
		}
	}

	/**
	 * Demonstrate random with explicit seed
	 */
	static void randomDemo2()
	{
		//no seed will use the current system time as seed
		Random random = new Random(1000);
		for (int i = 0; i < 10; i++)
		{
			//use 10 as maximum for easier recognition in the output
			Console.WriteLine(random.Next(10));
		}
	}

	/**
	 * Self check: why is this demo giving you the same numbers most of the time?
	 */
	static void randomDemo3()
	{
		//no seed will use the current system time as seed
		for (int i = 0; i < 10; i++)
		{
			Random random = new Random();
			//use 10 as maximum for easier recognition in the output
			Console.WriteLine(random.Next(10));
		}
	}

}

