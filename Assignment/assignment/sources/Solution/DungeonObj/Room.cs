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
			addConnectedDoorsToNewRooms(newRooms);
			
		}else if (area.Height >= minimumRoomSize * 2 + 1) {	
			split(newRooms, minimumRoomSize, false); //split height
			addConnectedDoorsToNewRooms(newRooms);
		}
		else {
			newRooms.Add(this); //because we remove the room we split in dungeon.generate()
			Console.WriteLine("splitting failed, added back " + this);
		}
		return newRooms;
	}

	private void split(List<Room> newRooms, int minimumRoomSize, bool splitIsWidth)
	{
		//no checks, they happen in Split(...)
		Random random = new Random();
		if (splitIsWidth) {
			int newWidth = random.Next(minimumRoomSize - 1, area.Width - minimumRoomSize + 1 ); //TODO: check add +1 || +2?

			if (!isWallOnDoorPos(splitIsWidth, newWidth)) {
				
				var newRoom = new Room(new Rectangle(area.X, area.Y, newWidth + 1, area.Height));
				newRooms.Add(newRoom);
				Console.WriteLine("Added " + newRoom);
				
				newRoom = new Room(new Rectangle(area.X + newWidth, area.Y, area.Width - newWidth, area.Height));
				newRooms.Add(newRoom);
				Console.WriteLine("Added " + newRoom);
				
			}
			// else{ 
			// 	newRooms.Add(this); //because we remove the room we split in dungeon.generate()
			// 	Console.WriteLine("splitting failed, added back " + this);
			// }
		}
		else{
			int newHeight = random.Next(minimumRoomSize - 1, area.Height - minimumRoomSize + 1); //add +1 || +2?

			if (!isWallOnDoorPos(splitIsWidth, newHeight)) {
				
				var newRoom = new Room(new Rectangle(area.X, area.Y, area.Width, newHeight + 1));
				Console.WriteLine("Added " + newRoom);
				newRooms.Add(newRoom);
				
				newRoom = new Room(new Rectangle(area.X, area.Y + newHeight, area.Width, area.Height - newHeight));
				Console.WriteLine("Added " + newRoom);
				newRooms.Add(newRoom);
				
			}
			// else {
			// 	newRooms.Add(this); //because we remove the room we split in dungeon.generate()
			// 	Console.WriteLine("splitting failed, added back " + this);
			// }
		}
		if (newRooms.Count == 0) {
			newRooms.Add(this); //because we remove the room we split in dungeon.generate()
            Console.WriteLine("splitting failed, added back " + this);
		}
	}

	private bool isWallOnDoorPos(bool splitIsWidth, int newDirectionRand)	//check if new wall will overlap door
	{
		if (splitIsWidth) {
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

	private bool areRoomsMinMaxSize(int minimumRoomSize, int newSize, bool splitIsWidth)
	{
		if (splitIsWidth) {
			if (newSize == minimumRoomSize || newSize == area.Width - minimumRoomSize){
				Console.WriteLine("removed both rooms, min & max sizes");
				return true;
			}

			return false;
		}
		else {
			if (newSize == minimumRoomSize || newSize == area.Height - minimumRoomSize) {
				Console.WriteLine("removed both rooms, min & max sizes");
				return true;
			}

			return false;
		}
	}

	private void addConnectedDoorsToNewRooms(List<Room> newRooms)
	{
		if (newRooms.Count == 2 && connectedDoors.Count != 0) {
			var roomA = newRooms[0];
			var roomB = newRooms[1];
			var splitIsWidth = roomA.area.Y == roomB.area.Y;
			if (splitIsWidth) {
				foreach (var door in connectedDoors) {
					if (door.Location.X < roomA.area.X + roomA.area.Width) {
						roomA.connectedDoors.Add(door);
					}
					else {
						roomB.connectedDoors.Add(door);
					}
				}
			}
			else {
				foreach (var door in connectedDoors) {
					if (door.Location.Y < roomA.area.Y + roomA.area.Height) {
						roomA.connectedDoors.Add(door);
					}
					else {
						roomB.connectedDoors.Add(door);
					}
				}
			}
		}
	}
	
	private bool isNewRoomMinMaxSize(int newSize, int minimumRoomSize, bool splitIsWidth, bool firstRoom)
	{
		if (splitIsWidth) {
			if (firstRoom) {
				if (newSize == minimumRoomSize || newSize == area.Width - minimumRoomSize) {
					Console.WriteLine("removed left room, equal to MIN/MAX RoomSize");
					return true;
				}

				return false;
			}
			else {	//second room
				if (area.Width - newSize == minimumRoomSize || newSize == minimumRoomSize) {
					Console.WriteLine("removed right room, equal to MIN/MAX RoomSize");
					return true;
				}

				return false;
			}
		}
		else{ //height split
			if (firstRoom) {
				if (newSize == minimumRoomSize || newSize == area.Height - minimumRoomSize) {
					Console.WriteLine("removed top room, equal to MIN/MAX RoomSize");
					return false;
				}
				
				return true;
			}
			else { //second room
				if (area.Height - newSize == minimumRoomSize || newSize == minimumRoomSize) {
					Console.WriteLine("removed bottom room, equal to MIN/MAX RoomSize");
					return false;
				}
				
				return true;
			}
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