using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;

/**
 * This class represents (the data for) a Door, at this moment only a position in the dungeon.
 * Changes to this class might be required based on your specific implementation of the algorithm.
 */
class Door
{
    public readonly Point location;

    //Keeping tracks of the Rooms that this door connects to,
    //might make your life easier during some of the assignments
    public Room roomA = null;
    public Room roomB = null;

    //You can also keep track of additional information such as whether the door connects horizontally/vertically
    //Again, whether you need flags like this depends on how you implement the algorithm, maybe you need other flags
    public bool horizontal = false;

    public Door(Point pLocation)
    {
        location = pLocation;
    }

    public Door(Room roomToBeSplit, List<Room> connectingRooms)
    {
        if (connectingRooms.Count == 2) {
            roomA = connectingRooms[0];
            roomB = connectingRooms[1];
        }
        Random random = new Random();
        var toBeSplitArea = roomToBeSplit.area;
        bool splitIsWidth = roomA.area.Y == roomB.area.Y;
        
        if (splitIsWidth) {
            int randDoorPos = random.Next(1, toBeSplitArea.Height - 1);
            location = new Point(roomA.area.X + roomA.area.Width - 1, roomA.area.Y + randDoorPos); //random Y axis door position on a set X axis wall
        }
        else {
            int randDoorPos = random.Next(1, toBeSplitArea.Width - 1);
            location = new Point(roomA.area.X + randDoorPos, roomA.area.Y + roomA.area.Height - 1); //random X axis door position on a set Y axis wall
        }
    }

    // Implement a toString method for debugging
    //Return information about the type of object and it's data
    //eg Door: (x,y)

    public override string ToString()
    {
        if (location != Point.Empty && location != null)
            return "Door location: " + location.ToString() + "\n A: " + roomA.ToString() + "\n B: " + roomB.ToString();
        else
            return "Door has no location";
    }
}