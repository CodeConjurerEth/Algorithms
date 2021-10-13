using System.Collections.Generic;

class CardCollection
{
	public static readonly List<HearthStoneCard> cards = new List<HearthStoneCard>() { 
		//0 minions 
		new MinionCard (HeroClass.NEUTRAL	, 0, "Wisp" , "", MinionRace.NONE, 1, 1),

		//1 minions
		new MinionCard (HeroClass.NEUTRAL   , 1, "Abusive Sergeant" , "Battlecry: Give a minion +2 Attack this turn", MinionRace.NONE, 1, 1),
		new MinionCard (HeroClass.HUNTER    , 1, "Timber Wolf" , "Your other Beasts have +1 Attack", MinionRace.BEAST, 1, 1),
		new MinionCard (HeroClass.MAGE      , 1, "Daring Fire-Eater" , "Battlecry: Your next Hero Power this turn deals 2 more damage", MinionRace.NONE, 1, 1),
		new MinionCard (HeroClass.PALADIN   , 1, "Glow-Tron" , "Magnetic", MinionRace.MECH, 1, 3),
		new MinionCard (HeroClass.SHAMAN    , 1, "Dust Devil" , "Windfury Overload(2)", MinionRace.ELEMENTAL, 3, 1),

		//2 minions
		new MinionCard (HeroClass.NEUTRAL   , 2, "Acidic Swamp Ooze" , "Battlecry: Destroy your opponent's weapon", MinionRace.NONE, 3, 2),
		new MinionCard (HeroClass.HUNTER	, 2, "Hunting Mastiff" , "Echo Rush", MinionRace.BEAST, 2, 1),
		new MinionCard (HeroClass.MAGE		, 2, "Mana Wyrm" , "Whenever you cast a spell, gain +1 Attack", MinionRace.NONE, 1, 3),
		new MinionCard (HeroClass.PRIEST    , 2, "Dead Ringer" , "Deathrattle: Draw a Deathrattle minion from your deck", MinionRace.MECH, 2, 1),
		new MinionCard (HeroClass.ROGUE     , 2, "Lab Recruiter" , "Battlecry: Shuffle 3 copies of a friendly minion into your deck", MinionRace.NONE, 3, 2),
		new MinionCard (HeroClass.SHAMAN	, 2, "Ghost Light Angler" , "Echo", MinionRace.MURLOC, 2, 2),
		new MinionCard (HeroClass.WARRIOR   , 2, "Cruel Taskmaster" , "Battlecry: Deal 1 damage to a minion and give it +2 Attack", MinionRace.NONE, 2, 2),

		//3 minions
		new MinionCard (HeroClass.NEUTRAL   , 3, "Acolyte of Pain" , "Whenever this miinion takes damage, draw a card", MinionRace.NONE, 1, 3),
		new MinionCard (HeroClass.DRUID     , 3, "Druid of the Scythe" , "Choose One - Transform into a 4/2 with Rush;or a 2/4 with Taunt", MinionRace.NONE, 2, 2),
		new MinionCard (HeroClass.HUNTER    , 3, "Bloodscalp Strategist" , "Battlecry: If you have a weapon equipped, Discover a spell", MinionRace.NONE, 2, 4),
		new MinionCard (HeroClass.PALADIN   , 3, "Bronze Herald" , "Deathrattle: Add two 4/4 Dragons to your hand", MinionRace.DRAGON, 3, 2),
		new MinionCard (HeroClass.PRIEST    , 3, "Omega Medic" , "Battlecry: If you have 10 Mana Crystals, restore 10 Health to your hero", MinionRace.NONE, 3, 4),
		new MinionCard (HeroClass.SHAMAN    , 3, "Unbound Elemental" , "Whenever you play a card with Overload, gain +1/+1", MinionRace.ELEMENTAL, 2, 4),
		new MinionCard (HeroClass.WARRIOR   , 3, "Frothing Berserker" , "Whenever a minion takes damage, gain +1 Attack", MinionRace.NONE, 2, 4),

		//4 minions
		new MinionCard (HeroClass.NEUTRAL   , 4, "Chillwind Yeti" , "", MinionRace.NONE, 4,5),
		new MinionCard (HeroClass.HUNTER    , 4, "Toxmonger" , "Whenever you play a 1-Cost minion, give it Poisonous", MinionRace.NONE, 2, 4),
		new MinionCard (HeroClass.MAGE      , 4, "Cosmic Anomaly" , "Spell Damage +2", MinionRace.ELEMENTAL, 4, 3),
		new MinionCard (HeroClass.ROGUE     , 4, "Blightnozzle Crawler" , "Deathrattle: Summon a 1/1 Ooze with Poisonous and Rush", MinionRace.MECH, 2, 4),
		new MinionCard (HeroClass.SHAMAN    , 4, "Totem Cruncher" , "Taunt Battlecry: Destroy your Totems. Gain +2/+2 for each destroyed", MinionRace.BEAST, 2, 3),
		new MinionCard (HeroClass.WARLOCK   , 4, "Summoning portal" , "Your minions cost (2) less, but not less than (1)", MinionRace.NONE, 0, 4),
		new MinionCard (HeroClass.WARRIOR   , 4, "Arathi Weaponsmith" , "Battlecry: Equip a 2/2 weapon", MinionRace.NONE, 3, 3),

		//5 minions
		new MinionCard (HeroClass.NEUTRAL   , 5, "Booty Bay Bodyguard" , "Taunt", MinionRace.NONE, 5, 4),
		new MinionCard (HeroClass.DRUID     , 5, "Druid of the Claw" , "Choose one - Transform into a 4/4 with Charge; or a 4/6 with Taunt", MinionRace.NONE, 4, 4),
		new MinionCard (HeroClass.HUNTER    , 5, "Carrion Drake" , "Battlecry: if a minion died this turn gain Poisonous", MinionRace.DRAGON, 3, 7),
		new MinionCard (HeroClass.PALADIN   , 5, "Mechano-Egg" , "Deathrattle: Summon an 8/8 Robosaur", MinionRace.MECH, 0, 5),
		new MinionCard (HeroClass.ROGUE     , 5, "Crazed Chemist" , "Combo: Give a friendly minion +4 Attack", MinionRace.NONE, 4, 4),
		new MinionCard (HeroClass.SHAMAN    , 5, "Earth Elemental" , "Taunt Overload:(3)", MinionRace.ELEMENTAL, 7, 8),
		new MinionCard (HeroClass.WARLOCK   , 5, "Deathweb Spider" , "Battlecry:If your hero took damage this turn, gain Lifesteal", MinionRace.BEAST, 4, 6),

		//6 minions
		new MinionCard (HeroClass.DRUID     , 6, "Tending Tauren" , "Choose One - Give your other minions +1/+1; Or Summon two 2/2 Treants", MinionRace.NONE, 3, 4),
		new MinionCard (HeroClass.MAGE      , 6, "Arcanosaur" , "Battlecry: If you played an Elemental last turn, deal 3 damage to all other minions", MinionRace.ELEMENTAL, 3, 3),
		new MinionCard (HeroClass.PALADIN   , 6, "Glowstone Technician" , "Battlecry: Give all minions in your hand +2/+2", MinionRace.NONE, 3, 4),
		new MinionCard (HeroClass.PRIEST    , 6, "Temple Enforcer" , "Battlecry: Give a friendly minion +3 health", MinionRace.NONE, 6, 6),
		new MinionCard (HeroClass.SHAMAN    , 6, "Fire Elemental" , "Battlecry: Deal 3 damage", MinionRace.ELEMENTAL, 6, 5),
		new MinionCard (HeroClass.WARLOCK   , 6, "Aranasi Broodmother" , "Taunt. When you draw this, restore 4 health to your hero", MinionRace.DEMON, 4, 6),
		new MinionCard (HeroClass.WARRIOR   , 6, "Security Rover" , "Whenever this minion takes damage, summon a 2/3 Mech with Taunt", MinionRace.MECH, 2, 5),

		//7 minions
		new MinionCard (HeroClass.NEUTRAL   , 7, "Core Hound" , "", MinionRace.BEAST, 9, 5),
		new MinionCard (HeroClass.DRUID    ,  7, "Ancient of War" , "Choose One - +5 Attack; or +5 Health and Taunt", MinionRace.NONE, 5, 5),
		new MinionCard (HeroClass.PALADIN   , 7, "Guardian of Kings" , "Battlecry: Restore 6 Health to your hero", MinionRace.NONE, 5, 6),
		new MinionCard (HeroClass.PRIEST    , 7, "Nightscale Matriach" , "Whenever a friendly minion is healed, summon a 3/3 Whelp", MinionRace.DRAGON, 4, 9),
		new MinionCard (HeroClass.ROGUE     , 7, "Tak Nozwhisker" , "Whenever you shuffle a card into your deck, add a copy to your hand", MinionRace.NONE, 6, 6),
		new MinionCard (HeroClass.WARLOCK   , 7, "Blood Troll Sapper" , "After a friendly minion dies, deal 2 damage to the enemy hero", MinionRace.NONE, 5, 8),

		//8 minions
		new MinionCard (HeroClass.NEUTRAL   , 8, "Mosh'Ogg Enforcer" , "Taunt Divine Shield", MinionRace.NONE, 2, 14),
		new MinionCard (HeroClass.DRUID     , 8, "Ironbark Protector" , "Taunt", MinionRace.NONE, 8, 8),
		new MinionCard (HeroClass.PRIEST    , 8, "Cartina Muerte" , "At the end of your turn, summon a friendly minion that died this game", MinionRace.NONE, 6, 8),
		new MinionCard (HeroClass.PALADIN   , 8, "Walking " , "", MinionRace.BEAST, 1, 5),
		new MinionCard (HeroClass.SHAMAN    , 8, "Walking Fountain" , "Lifesteal, Rush, Windfury", MinionRace.ELEMENTAL, 4, 8),
		new MinionCard (HeroClass.WARLOCK	, 8, "Hir'eek, the Bat" , "Battlecry: Fill your board with copies of this minion", MinionRace.BEAST, 1, 1),

		//9 minions
		new MinionCard (HeroClass.DRUID   , 9, "Cenarius" , "Choose One - Give your other minions +2/+2; or Summon two 2/2 Treants with Taunt", MinionRace.NONE, 5, 8),
		new MinionCard (HeroClass.HUNTER  , 9, "King Krush" , "Charge", MinionRace.BEAST, 8, 8),
		new MinionCard (HeroClass.SHAMAN  , 9, "Shudderwock" , "Battlecry: Repeat all other Battlecries from cards you player this game (targets chosen randomly)", MinionRace.NONE, 6, 6),
		new MinionCard (HeroClass.WARLOCK , 9, "Lord Jaraxxus" , "Battlecry: Destroy your hero and replace it with Lord Jaraxxus", MinionRace.DEMON, 3, 15),
		new MinionCard (HeroClass.NEUTRAL , 9, "Bull Dozer" , "Divine Shield", MinionRace.MECH, 9, 7),

		//10 minions
		new MinionCard (HeroClass.DRUID     ,10, "Mulchmuncher" , "Rush. Costs (1) less for each friendly Treant that died this game", MinionRace.MECH, 8, 8),
		new MinionCard (HeroClass.HUNTER    ,10, "Emeriss" , "Battlecry: Double the Attack and Health of all minions in your hand", MinionRace.DRAGON, 8, 8),
		new MinionCard (HeroClass.MAGE      ,10, "Kalecgos" , "Your first spell each turn costs (0). Battlecry: Discover a spell", MinionRace.DRAGON, 4, 12),
		new MinionCard (HeroClass.PALADIN   ,10, "Nozari" , "Battlecry: Restore both heroes to full Health", MinionRace.DRAGON, 4, 12),
		new MinionCard (HeroClass.WARLOCK	,10, "Jumbo Imp" , "Costs (1) less whenever a friendly Demon dies while this is in your hand", MinionRace.DEMON, 8, 8),
		new MinionCard (HeroClass.WARRIOR   ,10, "The Boom Reaver" , "Battlecry: Summon a copy of a minion in your deck and give it Rush", MinionRace.BEAST, 7, 9),

		//10+ minions
		new MinionCard (HeroClass.PRIEST    ,12, "Grave Horror" , "Taunt Costs (1) less for each spell you've cast this game", MinionRace.NONE, 7, 8),
		new MinionCard (HeroClass.NEUTRAL   ,12, "Mountain Giant" , "Costs (1) less for each other card in your hand", MinionRace.ELEMENTAL, 8, 8),

		//0 spells
		new SpellCard (HeroClass.DRUID, 0, "Innervate" , "Gain 1 Mana Crystal this turn only"),
		new SpellCard (HeroClass.MAGE , 0, "Elemental Evocation" , "The next Elemental you play this turn costs (2) less"),
		new SpellCard (HeroClass.PRIEST , 0, "Circle of Healing" , "Restore 4 Health to ALL minions"),
		new SpellCard (HeroClass.ROGUE, 0, "Backstab" , "Deal 2 damage to an undamaged minion"),
		new SpellCard (HeroClass.SHAMAN, 0, "Totemic Might" , "Give your totems +2 Health"),

		//1 spells
		new SpellCard (HeroClass.DRUID  , 1, "Biology Project" , "Each player gains 2 Mana Crystals"),
		new SpellCard (HeroClass.PRIEST , 1, "Holy Smite" , "Deal 2 damage"),
		new SpellCard (HeroClass.ROGUE  , 1, "Deadly Poison" , "Give your weapon +2 Attack"),
		new SpellCard (HeroClass.WARLOCK, 1, "Call of the Void" , "Add a random Demon to your hand"),
		new SpellCard (HeroClass.WARRIOR, 1, "Whirlwind" , "Deal 1 damage to ALL minions"),

		//2 spells
		new SpellCard (HeroClass.HUNTER , 2, "Hunter's Mark" , "Change a minion's Health to 1"),
		new SpellCard (HeroClass.ROGUE  , 2, "Stolen Steel" , "Discover a weapon (from another class)"),
		new SpellCard (HeroClass.SHAMAN , 2, "Windfury" , "Give a minion windfury"),
		new SpellCard (HeroClass.WARLOCK, 2, "Spirit Bomb" , "Deal 4 damage to a minion and a hero"),
		new SpellCard (HeroClass.WARRIOR, 2, "Dragon Roar" , "Add 2 random Dragons to your hand"),

		//3 spells
		new SpellCard (HeroClass.DRUID,   3, "Healing Touch" , "Restore 8 Health"),
		new SpellCard (HeroClass.HUNTER , 3, "Deadly Shot" , "Destroy a random enemy minion"),
		new SpellCard (HeroClass.MAGE   , 3, "Arcane Intellect" , "Draw 2 cards"),
		new SpellCard (HeroClass.SHAMAN , 3, "Feral Spirit" , "Summon two 2/3 Spirit Wolves with Taunt Overload: (2)"),
		new SpellCard (HeroClass.WARRIOR, 3, "Shield Block" , "Gain 5 Armor. Draw a Card."),

		//4 spells
		new SpellCard (HeroClass.DRUID  , 4, "Swipe" , "Deal 4 damage to an enemy and 1 damage to all other enemies"),
		new SpellCard (HeroClass.MAGE   , 4, "Fireball" , "Deal 6 damage"),
		new SpellCard (HeroClass.PALADIN, 4, "Consecration" , "Deal 2 damage to all enemies"),
		new SpellCard (HeroClass.WARLOCK, 4, "Fiendish Circle" , "Summon four 1/1 imps"),
		new SpellCard (HeroClass.WARRIOR, 4, "Mortal Strike" , "Deal 4 damage. If you have 12 or less Health , deal 6 instead."),

		//5 spells
		new SpellCard (HeroClass.DRUID  , 5, "Starfall" , "Choose One - Deal 5 damage to a minion; or 2 damage to all enemy minions"),
		new SpellCard (HeroClass.HUNTER , 5, "Baited Arrow" , "Deal 3 damage. Overkill: Summon a 5/5 Devilsaur."),
		new SpellCard (HeroClass.MAGE   , 5, "Blast Wave" , "Deal 2 damage to all minions. Overkill: Add a random Mage spell to your hand"),
		new SpellCard (HeroClass.PALADIN, 5, "Shrink Ray" , "Set the Attack and Health to all minions to 1"),
		new SpellCard (HeroClass.WARLOCK, 5, "Bane of Doom" , "Deal 2 damage to a character. If that kills it, summon a random Demon"),

		//6 spells
		new SpellCard (HeroClass.DRUID  , 6, "Starfire" , "Deal 5 damage, draw a card"),
		new SpellCard (HeroClass.PRIEST , 6, "Holy Fire" , "Deal 5 damage. Restore 5 Health to your hero."),
		new SpellCard (HeroClass.ROGUE, 6, "Vanish" , "Return all minions to their owner's hand"),
		new SpellCard (HeroClass.SHAMAN , 6, "Rain of Toads" , "Summon three 2/4 Toads with Taunt. Overload: (3)"),
		new SpellCard (HeroClass.WARRIOR, 6, "Heavy Metal!" , "Summon a random minion with Cost equal to your Armor (up to 10)."),

		//7 spells
		new SpellCard (HeroClass.MAGE   , 7, "Flamestrike" , "Deal 4 damage to all enemy minions"),
		new SpellCard (HeroClass.PALADIN , 7, "Kangor's Endless Army" , "Resurrect 3 friendly Mechs. They keep any Magnetic upgrades"),
		new SpellCard (HeroClass.ROGUE , 7, "Sprint" , "Draw 4 cards"),
		new SpellCard (HeroClass.SHAMAN, 7, "The Storm Bringer" , "Transform your minions into Legendary minions"),

		//8 spells
		new SpellCard (HeroClass.DRUID  , 8, "The Forest's Aid" , "Twinspell Summon five 2/2 Treants"),
		new SpellCard (HeroClass.HUNTER , 8, "Flark's Boom-Zooka" , "Summon 3 minions from your deck. They attack enemey minions, then die"),
		new SpellCard (HeroClass.MAGE,	  8, "Power of Creation" , "Discover a 6-Cost minion. Summon two copies of it."),
		new SpellCard (HeroClass.PALADIN, 8, "Lay on Hands" , "Restore 8 Health. Draw 3 cards."),
		new SpellCard (HeroClass.WARLOCK , 8, "Twisting Nether" , "Destroy all minions"),

		//9 spells
		new SpellCard (HeroClass.PRIEST , 9, "Mass Resurrection" , "Summon 3 friendly minions that died this game"),
		new SpellCard (HeroClass.WARRIOR , 9, "The Boomship" , "Summon 3 random minions from your hand. Give them Rush."),

		//10 spells
		new SpellCard (HeroClass.PRIEST , 10, "Mind Control" , "Take control of an enemy minion"),
		new SpellCard (HeroClass.MAGE , 10, "Pyroblast" , "Deal 10 damage"),
		new SpellCard (HeroClass.WARRIOR, 10, "Dimensional Ripper" , "Summon 2 copies of a minion in your deck"),

		//1 weapons
		new WeaponCard(HeroClass.PALADIN, 1, "Bloodclaw", "Battlecry: Deal 5 damage to your hero", 2, 2),
		new WeaponCard(HeroClass.PALADIN, 1, "Light's Justice", "", 1, 4),
		new WeaponCard(HeroClass.ROGUE, 1, "Serrated Tooth", "Deathrattle: Give your minions Rush", 1, 3),

		//2 weapons
		new WeaponCard(HeroClass.HUNTER, 2, "Headhunter's Hatchet", "Battlecry: If you control a Beast, gain +1 Durability", 2, 2),
		new WeaponCard(HeroClass.SHAMAN, 2, "Likkim", "Has +2 Attack while you have overloaded mana crystals", 1, 3),
		new WeaponCard(HeroClass.SHAMAN, 2, "Stormforged Axe", "Overload: (1)", 2, 3),
		new WeaponCard(HeroClass.WARRIOR, 2, "Woodcutter's Axe", "Deathrattle: Give +2/+1 to a random friendly Rush minion", 2, 2),

		//3 weapons
		new WeaponCard(HeroClass.HUNTER, 3, "Eaglehorn Bow", "Whenever a friendly secret is revealed gain +1 Durability", 3, 2),
		new WeaponCard(HeroClass.PALADIN, 3, "Sword of Justice", "After you summon a minion, give it +1/+1 and this loses 1 Durability.", 1, 5),
		new WeaponCard(HeroClass.ROGUE, 3, "Necrium Blade", "Deathrattle: Trigger the Deathrattle of a random friendly minion", 3, 2),
		new WeaponCard(HeroClass.WARRIOR, 3, "Fiery War Axe", "", 3, 2),

		//4 weapons
		new WeaponCard(HeroClass.PALADIN, 4, "Truesilver Champion", "Whenever your hero attacks, restore 2 health to it", 4, 2),
		new WeaponCard(HeroClass.WARRIOR, 4, "Wrenchcalibur", "After your hero attacks, shuffle a bomb in your opponent's deck", 3, 2),

		//5 weapons
		new WeaponCard(HeroClass.PALADIN, 5, "Farraki Battleaxe", "Overkill: Give a minion in your hand +2/+2", 3, 3),
		new WeaponCard(HeroClass.ROGUE, 5, "Assasin's Blade", "", 3, 4),
		new WeaponCard(HeroClass.SHAMAN, 5, "Doomhammer", "Windfury, Overload (2)", 2, 8),
		new WeaponCard(HeroClass.WARRIOR, 5, "Arcanite Reaper", "", 5, 2),

		//6 weapons
		new WeaponCard(HeroClass.WARRIOR, 6, "Sul'thraze", "Overkill: You may attack again", 4, 4),

		//7 weapons
		new WeaponCard(HeroClass.HUNTER, 7, "Gladiator's Longbow", "Your hero is Immune while attacking", 5, 2),
		new WeaponCard(HeroClass.WARRIOR, 7, "Gorehowl", "Attacking a minion costs 1 Attack instead of 1 Durability", 7, 1),

		//8 weapons
		new WeaponCard(HeroClass.PALADIN, 8, "Silver Sword", "After your hero attacks, give your minions +1/+1", 3, 4)
	};
}
