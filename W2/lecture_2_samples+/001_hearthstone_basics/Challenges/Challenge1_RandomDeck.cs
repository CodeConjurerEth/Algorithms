using System;
using System.Collections.Generic;

class Challenge1_RandomDeck
{
	private static Random random = new Random();

	public static List<HearthStoneCard> Run()
	{
		List<HearthStoneCard> result = new List<HearthStoneCard>();
		
		Console.WriteLine("TODO: Challenge1_RandomDeck.Run -> TODO create a random deck here");

        /** Fisher method
       for i from n−1 downto 1 do
    j ← random integer such that 0 ≤ j ≤ i
    exchange a[j] and a[i]
       */
        for (int i = 0; i < 30; i++)
        {
            result.Add(
            CardCollection.cards[random.Next(CardCollection.cards.Count)]
            );
        }

        return result;
	}
}

