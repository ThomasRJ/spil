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
            Room r1 = new Room("Tog", "det var her du kom fra men du kan ikke komme ind igen");
            Room r2 = new Room("Indgangen", "Indgangen til et mørkt Bygningskompleks");
            Room r3 = new Room("Gården", "Du kan se en masse meget tynde mænd gå i ring");
            Room r4 = new Room("Vagtlokale", "Døren er solid men der står på at det er vagternes omklædnings rum");

            rooms.Add(r1);
            rooms.Add(r2);
            rooms.Add(r3);
            rooms.Add(r4);

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