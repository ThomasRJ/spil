using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    public class Edge
    {
        public Room Room1 { get; set; }
        public Room Room2 { get; set; }
        public Item Required { get; set; }

        public Edge(Room r1, Room r2)
        {
            Room1 = r1;
            Room2 = r2;
        }
        public Room GetNeighbour(Room r)
        {
            if (Room1.Equals(r))
            {
                return Room2;
            }
            else
            {
                return Room1;
            }
        }

    }
}
