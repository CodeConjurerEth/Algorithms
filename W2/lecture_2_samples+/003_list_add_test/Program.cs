using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		List<int> myList = new List<int>();

		while (true)
		{
			Console.WriteLine("Size: {0}, Capacity:{1}", myList.Count, myList.Capacity);

			Console.WriteLine("How many elements would you like to add?");
			int elementCount;
			int.TryParse(Console.ReadLine(), out elementCount);

			for (int i = 0; i < elementCount; i++)
			{
				myList.Add(myList.Count);
			}
			Console.WriteLine();
		}
	}
}

