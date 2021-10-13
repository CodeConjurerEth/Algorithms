using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		List<string> words = new List<string>() { "this", "awesome", "is" };

		Console.WriteLine(string.Join(" ", words));

		//todo: swap is and awesome

		Console.WriteLine(string.Join(" ", words));

		Console.ReadLine();
	}

}

