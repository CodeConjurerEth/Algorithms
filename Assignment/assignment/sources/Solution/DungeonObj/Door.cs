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
    public readonly Point Location;

    //Keeping tracks of the Rooms that this door connects to,
    //might make your life easier during some of the assignments
    public Room RoomA = null;
    public Room RoomB = null;

    //You can also keep track of additional information such as whether the door connects horizontally/vertically
    //Again, whether you need flags like this depends on how you implement the algorithm, maybe you need other flags
    public bool SplitIsWidth = false;

    public Door(Point pLocation)
    {
        Location = pLocation;
    }

    public Door(Room roomToBeSplit, List<Room> connectingRooms)
    {
        if (connectingRooms.Count == 2) {
            RoomA = connectingRooms[0];
            RoomB = connectingRooms[1];

            Random random = new Random();
            var toBeSplitArea = roomToBeSplit.area;
            SplitIsWidth = RoomA.area.Y == RoomB.area.Y;

            if (SplitIsWidth) {
                int randDoorPos = random.Next(1, toBeSplitArea.Height - 1);
                Location = new Point(RoomA.area.X + RoomA.area.Width - 1,
                    RoomA.area.Y + randDoorPos); //random Y axis door position on a set X axis wall
            }
            else {
                int randDoorPos = random.Next(1, toBeSplitArea.Width - 1);
                Location = new Point(RoomA.area.X + randDoorPos,
                    RoomA.area.Y + RoomA.area.Height - 1); //random X axis door position on a set Y axis wall
            }
            
            //add this door to ConnectedDoors list inside room class
            RoomA.connectedDoors.Add(this); 
            RoomB.connectedDoors.Add(this);
        }
    }

    // Implement a toString method for debugging
    //Return information about the type of object and it's data
    //eg Door: (x,y)

    public override string ToString()
    {
        if (Location != Point.Empty && Location != null)
            return "Door location: " + Location.ToString();
        else
            return "Door has no location";
    }
}