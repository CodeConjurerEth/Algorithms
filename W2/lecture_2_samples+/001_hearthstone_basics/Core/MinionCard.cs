class MinionCard : HearthStoneCard
{
	public readonly int attack;
	public readonly int health;
	public readonly MinionRace minionType;

	public MinionCard(HeroClass pHeroClass, int pManaCost, string pName, string pCardText, MinionRace pMinionType, int pAttack, int pHealth) : base(pHeroClass, pManaCost, pName, pCardText)
	{
		minionType = pMinionType;
		attack = pAttack;
		health = pHealth;
	}
}

