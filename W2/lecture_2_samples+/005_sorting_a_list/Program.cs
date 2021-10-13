using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		List<int> intList = new List<int>() { 3, 87, 4, 1, 32, 5, 8, 0, 8, 6, 24, 1};
		intList.Sort();
		Console.WriteLine(string.Join(",", intList));

		List<string> stringList = new List<string>("a d e g h i h m n b v c d w q a s e r t g".Split(' '));
		stringList.Sort();
		Console.WriteLine(string.Join(",", stringList));

		Console.ReadLine();
	}
}

