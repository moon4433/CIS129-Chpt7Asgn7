using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JohnsonK_Chpt7Asgn7
{
    class Program
    {

        public static String[,] grid = new string[10, 10];
        enum ShipType {Carrier, Battleship, Destroyer, Boat, Submarine};
                                     //  ACC BS CR DS SUB
        public static int[] SHIP_SIZE = { 5, 4, 3, 2, 3 };
        enum StrikeResult {Sink, Hit, Miss};


        static void Main(string[] args)
        {
            // TODO:

            // Populate grid before game loop
            Populate();
            // enter game loop

            // display grid

            // prompt user for a location on grid

            // check shot location for a hit or miss

            // display shot on grid along with the ships and their sizes along with how many are still alive

            // once all ships are sunk game loop ends and player wins
            ReadLine();

        }

        public static void Populate()
        {
            // TODO:

            // choose cell at random

            // choose a direction

            // check if the ships size fits in location

            // if not then find new location

            // if it fits place ship

            // check if any other ships need placing

            ShipType ship1 = ShipType.Battleship;
            ShipType ship2 = ShipType.Boat;
            ShipType ship3 = ShipType.Carrier;
            ShipType ship4 = ShipType.Destroyer;
            ShipType ship5 = ShipType.Submarine;

            int rowPick;
            int columnPick;

            
            
                Random column = new Random();
                Random row = new Random();
               
                columnPick = column.Next(0,10);
                rowPick = row.Next(0,10);

                grid[columnPick, rowPick] = ;
            


            for (int k = 0; k < 9; k++)
            {

                for (int j = 0; j < 9; j++)
                {
                    grid[k, j] = "o";
                  
                      Write(grid[k, j] + " ");

                    

                }
                WriteLine();
            }
            
            
            
        }

        /*
        public static StrikeResult Fire(int[,] grid, String row, int col)
        {
            // TODO:

            // compare shot location with grid location

            // check to see if a ship is there
            
            // return hit if ship is there but it still has life left

            // return sunk if ship is hit but has no health left

            // return miss if no ship is present
            
        }

        public Boolean ShipAfloat(int[,] grid, ShipType type)
        {
            // TODO:

            // runs check to see if specific ship was hit or not

            // return true if hit

            // return false if miss
        }

        public int ShipAfloat(int[,] grid)
        {
            // TODO:

            // check how many ships are still alive

            // return total number of ships still alive 

        }
        */
    }
}
