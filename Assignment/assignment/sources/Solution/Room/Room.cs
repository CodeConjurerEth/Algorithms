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

	public List<Room> Split (int minimumRoomSize)
	{
		List<Room> newRooms = new List<Room>();
		if (area.Width >= minimumRoomSize * 2 + 1) {
			split(newRooms, minimumRoomSize, true); //split width
		}else if (area.Height >= minimumRoomSize * 2 + 1) {
			split(newRooms,minimumRoomSize, false); //split height
		}
		else {
			newRooms.Add(this); //because we remove the room we split in dungeon
		}

		return newRooms;
	}

	private void split(List<Room> newRooms, int minimumRoomSize, bool splitIsWidth)
	{
		//no checks, they happen in Split(int minimumRoomSize)
		Random random = new Random();
		if (splitIsWidth) {
			int newWidth = random.Next(minimumRoomSize, area.Width - minimumRoomSize );
				newRooms.Add(new Room(new Rectangle(area.X, area.Y, newWidth + 1, area.Height)));
				newRooms.Add(new Room(new Rectangle(area.X + newWidth, area.Y, area.Width - newWidth, area.Height)));
		}
		else{
			int newHeight = random.Next(minimumRoomSize, area.Height - minimumRoomSize );
			newRooms.Add(new Room(new Rectangle(area.X, area.Y, area.Width, newHeight +1)));
			newRooms.Add(new Room(new Rectangle(area.X, area.Y + newHeight, area.Width, area.Height - newHeight)));
		}
		
	}

	//TODO: Implement a toString method for debugging?
	//Return information about the type of object and it's data
	//eg Room: (x, y, width, height)

	public override string ToString()
	{
		if (area != Rectangle.Empty && area != null)
			return "room area: " + area.ToString();
		else {
			return "room has no area";
		}
	}
}
