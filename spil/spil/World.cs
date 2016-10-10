using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    public class World
    {
        List<Room> rooms;
        public World()
        {
            rooms = new List<Room>();
            Room r1 = new Room("Tog", "memes");
            Room r2 = new Room("Indgangen", "memes");
            Room r3 = new Room("Vagtlokale", "memes");
            Room r4 = new Room("Overvågnings Rum", "memes");
            Room r5 = new Room("Gården", "memes");
            Room r6 = new Room("Fængselschefens Kontor", "memes");
            Room r7 = new Room("", "memes");
            Room r8 = new Room("Niggerbasement", "memes");
            Room r9 = new Room("Niggerbasement", "memes");


            rooms.Add(r1);
            rooms.Add(r2);
            rooms.Add(r3);
            rooms.Add(r4);
            rooms.Add(r5);
            rooms.Add(r6);
            rooms.Add(r7);
            rooms.Add(r8);
            rooms.Add(r9);


            r1.AddEast(r2);
            r2.AddWest(r1);
            r2.AddNorth(r3);
            r3.AddSouth(r2);
            r3.AddEast(r4);

        }

        public void PrintWorld()
        {
            foreach (Room r in rooms)
            {
                Console.WriteLine(r.ToString());
            }
        }


    }
}