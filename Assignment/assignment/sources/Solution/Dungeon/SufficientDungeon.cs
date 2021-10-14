using System;
using System.Collections.Generic;
using GXPEngine;
using System.Drawing;

/**
 * An example of a dungeon implementation.  
 * This implementation places two rooms manually but your implementation has to do it procedurally.
 */
class SufficientDungeon : Dungeon
{
    public SufficientDungeon(Size pSize) : base(pSize) {}

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
        rooms.Add(new Room(new Rectangle(0,0, size.Width, size.Height)));

        for (int index = 0; index < rooms.Count; index++) {
	        List<Room> newRooms = new List<Room>();
	        newRooms.AddRange(rooms[index].Split(pMinimumRoomSize));
	        
	        Console.WriteLine(rooms[index].ToString() + " was split into: "); 
	        Console.WriteLine(newRooms[0].ToString());
	        if(newRooms.Count > 1)
				Console.WriteLine(newRooms[1].ToString());
			
	        rooms.Remove(rooms[index]);
	        rooms.AddRange(newRooms);
	        

        }


        // rooms.Add(new Room(new Rectangle(0, 0, size.Width/2+1, size.Height)));
        // rooms.Add(new Room(new Rectangle(size.Width/2, 0, size.Width/2, size.Height)));
        // doors.Add(new Door(new Point(size.Width / 2, size.Height / 2 + 10)));
    }

    public override string ToString()
    {
	    string s = "";
	    for (int index = 0; index < rooms.Count; index++) {
		    s += rooms[index].ToString() + "\n";
	    }
		return s;
    }
}