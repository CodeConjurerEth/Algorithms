using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
	static void Main(string[] args)
	{
		
		List<HearthStoneCard> deck = Challenge1_RandomDeck.Run();
		printCardList(deck);

		Console.ReadLine();
	}

	//no conditional code
	static void printCardList (List<HearthStoneCard> pCardList)
	{
		if (pCardList == null) return;

		foreach (HearthStoneCard card in pCardList)
		{
			System.Console.WriteLine(card);
		}
	}

	[Conditional("DEBUG")]
	static void printCardListConditional(List<HearthStoneCard> pCardList)
	{
		if (pCardList == null) return;

		foreach (HearthStoneCard card in pCardList)
		{
			System.Console.WriteLine(card);
		}
	}

	//Example of conditional log statement
	[Conditional("DEBUG")]
	public static void Log (string pInfo)
	{
		Console.WriteLine(pInfo);
	}

}
