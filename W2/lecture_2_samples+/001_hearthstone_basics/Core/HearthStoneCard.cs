using System;

class HearthStoneCard 
{
	public readonly HeroClass heroClass;
	public readonly int manaCost;
	public readonly string name;
	public readonly string cardText;

	public HearthStoneCard(HeroClass pHeroClass, int pManaCost, string pName, string pCardText)
	{
		heroClass = pHeroClass;
		manaCost = pManaCost;
		name = pName;
		cardText = pCardText;
	}

}
