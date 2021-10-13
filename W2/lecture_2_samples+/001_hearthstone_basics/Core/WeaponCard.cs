
class WeaponCard : HearthStoneCard
{
	public readonly int attack;
	public readonly int durability;

	public WeaponCard(HeroClass pHeroClass, int pManaCost, string pName, string pCardText, int pAttack, int pDurability) : base(pHeroClass, pManaCost, pName, pCardText)
	{
		attack = pAttack;
		durability = pDurability;
	}
}

