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
        public static String[] SHIP_IDENTIFIERS = new string[] {"c", "b", "d", "b", "s"};

                                     //  ACC BS DR PB SUB
        public static int[] SHIP_SIZE = { 5, 4, 3, 2, 3 };
        enum StrikeResult {Sink, Hit, Miss};

        

        public static int rowPickCarrier;
        public static int columnPickCarrier;
        public static int axisPickCarrier;

        public static Random columnCarrier = new Random();
        public static Random rowCarrier = new Random();
        public static Random axisCarrier = new Random();

        public static int rowPickBattle;
        public static int columnPickBattle;
        public static int axisPickBattle;

        public static Random columnBattle = new Random();
        public static Random rowBattle = new Random();
        public static Random axisBattle = new Random();


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



            


            for (int k = 0; k < 10; k++)
            {

                for (int j = 0; j < 10; j++)
                {            
                        grid[k, j] = "~";

                }
            }

            columnPickCarrier = columnCarrier.Next(0, 3);
            rowPickCarrier = rowCarrier.Next(0, 3);
            axisPickCarrier = axisCarrier.Next(0, 2);

            if (axisPickCarrier == 1)
            {
                for (int i = 0; i < SHIP_SIZE[0]; i++)
                {
                    grid[columnPickCarrier, rowPickCarrier] = SHIP_IDENTIFIERS[0];
                    rowPickCarrier++;
                }
                
            }
            if (axisPickCarrier == 0)
            {
                for (int i = 0; i < SHIP_SIZE[0]; i++)
                {
                    grid[columnPickCarrier, rowPickCarrier] = SHIP_IDENTIFIERS[0];
                    columnPickCarrier++;
                }
            }

            columnPickBattle = columnBattle.Next(5, 6);
            rowPickBattle = rowBattle.Next(5, 6);
            

            if (axisPickCarrier == 0)
            {
                
                for (int i = 0; i < SHIP_SIZE[1]; i++)
                {
                    grid[columnPickBattle, rowPickBattle] = SHIP_IDENTIFIERS[1];
                    rowPickBattle++;
                }
                
            }
            if (axisPickCarrier == 1)
            {
                
                for (int i = 0; i < SHIP_SIZE[1]; i++)
                {
                    grid[columnPickBattle, rowPickBattle] = SHIP_IDENTIFIERS[1];
                    columnPickBattle++;
                }
            }
            /*
            for (int i = 0; i < SHIP_SIZE[2]; i++)
            {

                grid[columnPick, rowPick] = SHIP_IDENTIFIERS[2];

                rowPick += 1;
            }

            for (int i = 0; i < SHIP_SIZE[3]; i++)
            {

                grid[columnPick, rowPick] = SHIP_IDENTIFIERS[3];

                rowPick += 1;
            }

            for (int i = 0; i < SHIP_SIZE[4]; i++)
                {

                    grid[columnPick, rowPick] = SHIP_IDENTIFIERS[4];

                    rowPick += 1;
                }

            */

            for (int k = 0; k < 10; k++)
            {

                for (int j = 0; j < 10; j++)
                {
                    Write(grid[k, j]);

                    Write(" ");

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
