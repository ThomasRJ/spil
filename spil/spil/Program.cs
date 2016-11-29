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
                char c = Console.ReadKey(true).KeyChar;
                switch (c)
                {
                    case 'w':
                        if (world.p.currentRoom.north != null)
                        {
                            world.p.currentRoom = world.p.currentRoom.north;
                        }
                        break;

                    case 'a':
                        if (world.p.currentRoom.west != null) 
                        {
                            world.p.currentRoom = world.p.currentRoom.west;
                        }
                        break;

                    case 's':
                        if (world.p.currentRoom.south != null) 
                        {
                            world.p.currentRoom = world.p.currentRoom.south;
                        }
                        break;

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