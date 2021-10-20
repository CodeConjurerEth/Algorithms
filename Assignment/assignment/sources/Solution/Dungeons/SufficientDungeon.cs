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
        Rooms.Add(new Room(new Rectangle(0,0, Size.Width, Size.Height)));

        for (int index = 0; index < 15; index++) { //gonna have to change this
	        List<Room> newRooms = new List<Room>();
	        Door newDoor = null;
	        Random random = new Random();
	        var roomToSplit = Rooms[random.Next(0, Rooms.Count-1)];
	        
	        Console.WriteLine("\n" + roomToSplit.ToString() + " to be split into: ");
	        
	        newRooms.AddRange(roomToSplit.Split(pMinimumRoomSize));
	        bool wasSplit = newRooms.Count == 2;
	        if (wasSplit) {
		        newDoor = new Door(roomToSplit, newRooms);
		        Doors.Add(newDoor);
	        }
	        /*Debugging*/
	        if (newDoor != null) {
		        Console.WriteLine(newDoor.ToString());
	        }/**/

	        Rooms.Remove(roomToSplit);
	        Rooms.AddRange(newRooms);
        }
    }

    public override string ToString()
    {
	    string s = "";
	    for (int index = 0; index < Doors.Count; index++) {
		    s += Doors[index].ToString() + "\n";
	    }
		return s;
    }
}