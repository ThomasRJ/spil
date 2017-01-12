using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class Program
    {
        static World world;
        static void Main(string[] args)
        {
            world = new World();
    
  
            bool isRunning = true;

            while(isRunning)
            {
                //Gør det muligt at lukke spillet ved skrive exit i konsollen.
                string s = Console.ReadLine();
                if(s.ToLower().Equals("exit"))
                {
                    isRunning = false;
                }
                else
                {
                    HandleGame();
                }
            }
        }

        public static void HandleGame()
        {
            bool readCommands = true;
            Console.WriteLine(world.p.currentRoom.ToString());
            while(readCommands)
            {
                //gør det muligt at bruge taster til at bevæge sige rundt.
                char c = Console.ReadKey(true).KeyChar;
                switch (c)
                {
                    //Laver w til nord
                    case 'w':
                        if (world.p.currentRoom.north != null)
                        {
                            world.p.currentRoom = world.p.currentRoom.north;
                        }
                        break;
                        //Laver a til vest
                    case 'a':
                        if (world.p.currentRoom.west != null) 
                        {
                            world.p.currentRoom = world.p.currentRoom.west;
                        }
                        break;
                        //Laver s til syd
                    case 's':
                        if (world.p.currentRoom.south != null) 
                        {
                            world.p.currentRoom = world.p.currentRoom.south;
                        }
                        break;
                        //Laver d til øst
                    case 'd':
                        if (world.p.currentRoom.east != null) 
                        {
                            world.p.currentRoom = world.p.currentRoom.east;
                        }
                        break;

                    default:
                        readCommands = false;
                        break;
                }
                world.p.EnterRoom();
            }
            
        }
    }
}