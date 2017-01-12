using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    public class Room
    {
        //Tilføjer retningerne altså nord, syd, øst og vest. 
        public Room north;
        public Room south;
        public Room west;
        public Room east;
        //Navn og beskrivelse af rummene der bliver printet. 
        public string navn;
        public string beskrivelse;

        public Room(string navn, string beskrivelse)
        {
            this.navn = navn;
            this.beskrivelse = beskrivelse;
        }
        //Tilføjer retninger til alle rum (public)
        public void AddNorth(Room r)
        {
            north = r;
        }

        public void AddSouth(Room r)
        {
            south = r;
        }
        public void AddWest(Room r)
        {
            west = r;
        }
        public void AddEast(Room r)
        {
            east = r;
        }
        //Hvad der kommer ud i konsollen når man går fra rum til andet. 
        public override string ToString()
        {
            string s = "";
            s += "Navn: " + navn + "\n";
            s += "Beskrivelse: " + beskrivelse + "\n";
            if (north != null) s += "Udgang til nord: " + north.navn + "\n";
            if (south != null) s += "Udgang til south: " + south.navn + "\n";
            if (west != null) s += "Udgang til vest: " + west.navn + "\n";
            if (east != null) s += "Udgang til oest: " + east.navn + "\n";
            return s;
        }


    }
}