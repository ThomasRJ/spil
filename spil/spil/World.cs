﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    public class World
    {
        public Player p = new Player();
        List<Room> rooms;
        public World()
        {
            
            rooms = new List<Room>();
            Room r1 = new Room("Tog", "Her kom du fra");
            Room r2 = new Room("Indgangen", "En indgang til et mørkt bygnings kompleks");
            Room r3 = new Room("Vagtlokale", "Pauserum for vagterne");
            Room r4 = new Room("Overvågnings Rum", "Et rum med sort/hvid tv-skærme");
            Room r5 = new Room("Gården", "Igennem et vindue, kan du se en masse tynde mænd gå rundt");
            Room r6 = new Room("Fængselschefens Kontor", "Stor boss");
            Room r7 = new Room("Trænings område", "Gains dude");
            Room r8 = new Room("basement", "memes");
            Room r9 = new Room("basement", "memes");


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

            p.currentRoom = r1;

            Console.WriteLine(p.currentRoom.ToString());

            Item i = new Item();
            i.Name = "key";
            Edge e = new Edge(r3, r4);
            e.Required = i;

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