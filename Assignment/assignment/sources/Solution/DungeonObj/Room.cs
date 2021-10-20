using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;

/**
 * This class represents (the data for) a Room, at this moment only a rectangle in the dungeon.
 */
class Room
{
	public Rectangle area;
	public List<Door> connectedDoors;
	public Room (Rectangle pArea) {
		area = pArea;
		connectedDoors = new List<Door>();
	}
	
	public List<Room> Split (int minimumRoomSize)
	{
		List<Room> newRooms = new List<Room>();
		if (area.Width >= minimumRoomSize * 2 + 1) {
			split(newRooms, minimumRoomSize, true); //split width
		}else if (area.Height >= minimumRoomSize * 2 + 1) {	
			split(newRooms, minimumRoomSize, false); //split height
		}
		else {
			newRooms.Add(this); //because we remove the room we split in dungeon.generate()
			Console.WriteLine("splitting failed, added back " + this);
			//TODO: can there be the connectedDoors removed? seemingly no but keep sharp
		}
		return newRooms;
	}

	private void split(List<Room> newRooms, int minimumRoomSize, bool splitIsHorizontal)
	{
		//no checks, they happen in Split(...)
		Random random = new Random();
		if (splitIsHorizontal) {
			int newWidth = random.Next(minimumRoomSize, area.Width - minimumRoomSize ); //TODO: check add +1 || +2?

			if (!isWallOnDoorPos(splitIsHorizontal, newWidth)) {
				var newRoom = new Room(new Rectangle(area.X, area.Y, newWidth + 1, area.Height));
				newRooms.Add(newRoom);
				Console.WriteLine("Added " + newRoom);
				
				newRoom = new Room(new Rectangle(area.X + newWidth, area.Y, area.Width - newWidth, area.Height));
				newRooms.Add(newRoom);
				Console.WriteLine("Added " + newRoom);
			}
			else {
				newRooms.Add(this); //because we remove the room we split in dungeon.generate()
				Console.WriteLine("splitting failed, added back " + this);
			}
		}
		else{
			int newHeight = random.Next(minimumRoomSize, area.Height - minimumRoomSize); //add +1 || +2?

			if (!isWallOnDoorPos(splitIsHorizontal, newHeight)) {
				var newRoom = new Room(new Rectangle(area.X, area.Y, area.Width, newHeight + 1));
				Console.WriteLine("Added " + newRoom);
				newRooms.Add(newRoom);
				
				newRoom = new Room(new Rectangle(area.X, area.Y + newHeight, area.Width, area.Height - newHeight));
				Console.WriteLine("Added " + newRoom);
				newRooms.Add(newRoom);
			}
			else {
				newRooms.Add(this); //because we remove the room we split in dungeon.generate()
				Console.WriteLine("splitting failed, added back " + this);
			}
		}
	}

	private bool isWallOnDoorPos(bool splitIsHorizontal, int newDirectionRand)	//check if new wall will overlap door
	{
		if (splitIsHorizontal) {
			foreach (Door connectedDoor in connectedDoors) {
				if (connectedDoor.Location.X == area.X + newDirectionRand) { //check new wall same X location as existing connected door
					if (connectedDoor.Location.Y == area.Y || connectedDoor.Location.Y == area.Y + area.Height -1) { //check both top and bottom corners for overlap
						Console.WriteLine("Blocking:" + connectedDoor.ToString() + ", skipping " + this);
						Console.WriteLine("newDirRand is: " + newDirectionRand);
						return true;
					}
				}
			}
			return false;
		}
		else {
			foreach (Door connectedDoor in connectedDoors) {
				if (connectedDoor.Location.Y == area.Y + newDirectionRand) { //check new wall same Y location as existing connected door
					if (connectedDoor.Location.X == area.X || connectedDoor.Location.X == area.X + area.Width -1) { //check both left and right corners for overlap
						Console.WriteLine("Blocking " + connectedDoor.ToString() + ", skipping " + this);
						Console.WriteLine("newDirRand is: " + newDirectionRand);
						return true;
					}
				}
			}
			return false;
		}
	}

	public override string ToString()
	{
		if (area != Rectangle.Empty && area != null)
			return "Room: " + area.ToString();
		else {
			return "room has no area";
		}
	}
}