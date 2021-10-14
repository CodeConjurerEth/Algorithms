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
	public Room (Rectangle pArea)
	{
		area = pArea;
	}
	
	public List<Room> Split (int minimumRoomSize, List<Door> doors)
	{
		List<Room> newRooms = new List<Room>();
		if (area.Width >= minimumRoomSize * 2 + 1) {
			split(newRooms, doors, minimumRoomSize, true); //split width
		}else if (area.Height >= minimumRoomSize * 2 + 1) {	
			split(newRooms, doors, minimumRoomSize, false); //split height
		}
		else {
			newRooms.Add(this); //because we remove the room we split in dungeon.generate()
		}
		return newRooms;
	}

	private void split(List<Room> newRooms, List<Door> doors, int minimumRoomSize, bool splitIsWidth)
	{
		//no checks, they happen in Split(...)
		Random random = new Random();
		if (splitIsWidth) {
			int newWidth = random.Next(minimumRoomSize, area.Width - minimumRoomSize ); //TODO: check add +1 || +2?
			var overlappingDoor = false;
			foreach(Door door in doors) {
				if (door.location == new Point(area.X + newWidth, area.Y)) {
					overlappingDoor = true; //refer room to linked doors somehow
				}
			}
			if (!overlappingDoor) {
				newRooms.Add(new Room(new Rectangle(area.X, area.Y, newWidth + 1, area.Height)));
				newRooms.Add(new Room(new Rectangle(area.X + newWidth, area.Y, area.Width - newWidth, area.Height)));
			}
		}
		else{
			int newHeight = random.Next(minimumRoomSize, area.Height - minimumRoomSize); //add +1 || +2?
			var overlappingDoor = false;
			foreach(Door door in doors) {
				if (door.location == new Point(area.X, area.Y + newHeight)) {
					overlappingDoor = true;	//refer room to linked doors somehow
				}
			}
			if (!overlappingDoor) {
				newRooms.Add(new Room(new Rectangle(area.X, area.Y, area.Width, newHeight + 1)));
				newRooms.Add(new Room(new Rectangle(area.X, area.Y + newHeight, area.Width, area.Height - newHeight)));
			}
		}
		
	}

	// Implement a toString method for debugging?
	//Return information about the type of object and it's data
	//eg Room: (x, y, width, height)

	public override string ToString()
	{
		if (area != Rectangle.Empty && area != null)
			return "Room: " + area.ToString();
		else {
			return "room has no area";
		}
	}
}
