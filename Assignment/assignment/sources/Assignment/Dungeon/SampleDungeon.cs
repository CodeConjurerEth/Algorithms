using GXPEngine;
using System.Drawing;

/**
 * An example of a dungeon implementation.  
 * This implementation places two rooms manually but your implementation has to do it procedurally.
 */
class SampleDungeon : Dungeon
{
	public SampleDungeon(Size pSize) : base(pSize) {}

	/**
	 * This method overrides the super class generate method to implement a two-room dungeon with a single door.
	 * The good news is, it's big enough to house an Ogre and his ugly children, the bad news your implementation
	 * should generate the dungeon procedurally, respecting the pMinimumRoomSize.
	 * 
	 * Hints/tips: 
	 * - start by generating random rooms in your own Dungeon class and placing random doors.
	 * - playing/experiment freely is the key to all success
	 * - this problem can be solved both iteratively or recursively
	 */
	protected override void generate(int pMinimumRoomSize)
	{
		//left room from 0 to half of screen + 1 (so that the walls overlap with the right room)
		//(TODO: experiment with removing the +1 below to see what happens with the walls)
		Rooms.Add(new Room(new Rectangle(0, 0, Size.Width/2+1, Size.Height)));
		//right room from half of screen to the end
		Rooms.Add(new Room(new Rectangle(Size.Width/2, 0, Size.Width/2, Size.Height)));
		//and a door in the middle wall with a random y position
		//TODO:experiment with changing the location and the Pens.White below
		Doors.Add(new Door(new Point(Size.Width / 2, Size.Height / 2 + Utils.Random(-5, 5))));
	}

	public override string ToString()
	{
		return base.ToString();
	}
}

