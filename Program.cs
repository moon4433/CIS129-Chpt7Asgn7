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
        public static String[] SHIP_IDENTIFIERS = new string[] {"c", "b", "d", "p", "s"};

                                     //  ACC BS DR PB SUB
        public static int[] SHIP_SIZE = { 5, 4, 3, 2, 3 };

        public static int carrierHit = 5;
        public static int battleHit = 4;
        public static int destroyHit = 3;
        public static int patrolHit = 2;
        public static int subHit = 3;
        public int shipsAlive = 5;
        

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

        public static int rowPickDest;
        public static int columnPickDest;
        public static int axisPickDest;

        public static Random columnDest = new Random();
        public static Random rowDest = new Random();

        public static int rowPickBoat;
        public static int columnPickBoat;

        public static Random columnBoat = new Random();
        public static Random rowBoat = new Random();

        public static int rowPickSub;
        public static int columnPickSub;
        public static int axisPickSub;

        public static Random columnSub = new Random();
        public static Random rowSub = new Random();

        public static Boolean isGamePlaying = true;
        public static Boolean showPieces = false;

        public static Boolean isCarrierAlive = true;
        public static Boolean isBattleAlive = true;
        public static Boolean isDestroyAlive = true;
        public static Boolean isPatrolAlive = true;
        public static Boolean isSubAlive = true;

        public static int descX;
        public static int descY;
        

        static void Main(string[] args)
        {
            

            // Populate grid before game loop
            Populate();
            // enter game loop
            while (isGamePlaying)
            {
                // display grid
                WriteLine("  |1 2 3 4 5 6 7 8 9 10");
                WriteLine("--+---------------------");
                for (int k = 0; k < 10; k++)
                {
                    Write((k + 1));
                    if (k == 9)
                    {
                        Write("|");
                    }
                    else
                    {
                        Write(" |");
                    }
                    for (int j = 0; j < 10; j++)
                    {
                        /*
                        if(grid[k, j] != "~" && grid[k, j] != "H" && grid[k, j] != "M")
                        {
                            Write("~");
                        }
                        else
                        {
                            Write(grid[k, j]);
                        }
                        */
                       Write(grid[k, j]);

                        Write(" ");


                    }
                    WriteLine();
                }
                WriteLine();
                // prompt user for a location on grid
                WriteLine("Enter X");
                descX = Convert.ToInt32(ReadLine());
                WriteLine("Enter Y");
                descY = Convert.ToInt32(ReadLine());
                // check shot location for a hit or miss
                Boolean result = Fire((descX - 1), (descY - 1));
                if (result)
                {
                    WriteLine("Hit");
                }
                else
                {
                    WriteLine("Miss");
                }

                string shipfloat = ShipAfloat();
                if(shipfloat == null)
                {
                    
                }
                else
                {
                    WriteLine(shipfloat);
                }

                
                // display shot on grid along with the ships and their sizes along with how many are still alive

                // once all ships are sunk game loop ends and player wins
                ReadLine();
                Clear();
            }
           
            
        }

        

        public static void Populate()
        {
           
            for (int k = 0; k < 10; k++)
            {

                for (int j = 0; j < 10; j++)
                {            
                        grid[k, j] = "~";

                }
            }

            columnPickCarrier = columnCarrier.Next(0, 2);
            rowPickCarrier = rowCarrier.Next(0, 2);
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
            rowPickBattle = rowBattle.Next(5, 7);
            axisPickBattle = axisCarrier.Next(2, 4);
            

            if (axisPickBattle == 2)
            {
                
                for (int i = 0; i < SHIP_SIZE[1]; i++)
                {
                    grid[columnPickBattle, rowPickBattle] = SHIP_IDENTIFIERS[1];
                    rowPickBattle++;
                }
                
            }
            if (axisPickBattle == 3)
            {
                
                for (int i = 0; i < SHIP_SIZE[1]; i++)
                {
                    grid[columnPickBattle, rowPickBattle] = SHIP_IDENTIFIERS[1];
                    columnPickBattle++;
                }
            }

            columnPickDest = columnDest.Next(6, 8);
            rowPickDest = rowDest.Next(0, 3);
            axisPickDest = axisCarrier.Next(5, 7);

            if (axisPickDest == 5)
            {

                for (int i = 0; i < SHIP_SIZE[2]; i++)
                {
                    grid[columnPickDest, rowPickDest] = SHIP_IDENTIFIERS[2];
                    rowPickDest++;
                }

            }
            if (axisPickDest == 6)
            {

                for (int i = 0; i < SHIP_SIZE[2]; i++)
                {
                    grid[columnPickDest, rowPickDest] = SHIP_IDENTIFIERS[2];
                    columnPickDest++;
                }
            }

            columnPickBoat = columnDest.Next(6, 10);
            rowPickBoat = rowDest.Next(8, 9);

            for (int i = 0; i < SHIP_SIZE[3]; i++)
            {
                grid[columnPickBoat, rowPickBoat] = SHIP_IDENTIFIERS[3];
                rowPickBoat++;
            }

            columnPickSub = columnSub.Next(0, 4);
            rowPickSub = rowSub.Next(5, 7);
            axisPickSub = axisCarrier.Next(7, 9);

            if (axisPickSub == 7)
            {

                for (int i = 0; i < SHIP_SIZE[4]; i++)
                {
                    grid[columnPickSub, rowPickSub] = SHIP_IDENTIFIERS[4];
                    rowPickSub++;
                }

            }
            if (axisPickSub == 8)
            {

                for (int i = 0; i < SHIP_SIZE[4]; i++)
                {
                    grid[columnPickSub, rowPickSub] = SHIP_IDENTIFIERS[4];
                    columnPickSub++;
                }
            }


        }

        
        public static bool Fire(int row, int col)
        {

                    if(grid[col, row] == "c")
                    {
                        grid[col, row] = "H";
                        carrierHit -= 1;


                        return true;
                        
                    }
                    else if(grid[col, row] == "b")
                    {
                        grid[col, row] = "H";
                        battleHit -= 1;

                        return true; 
                    }
                    else if (grid[col, row] == "d")
                    {
                        grid[col, row] = "H";
                        destroyHit -= 1;

                        return true;
                    }
                    else if (grid[col, row] == "p")
                    {
                        grid[col, row] = "H";
                        patrolHit -= 1;

                        return true;
                    }
                    else if (grid[col, row] == "s")
                    {
                        grid[col, row] = "H";
                        subHit -= 1;

                        return true;
                    }
                    else
                    {
                         grid[col, row] = "M";


                         return false;
                    }

            
        }

        public static string ShipAfloat()
        {
            // TODO:

            // runs check to see if specific ship was hit or not

            // return true if hit

            // return false if miss
     
            if (carrierHit == 0 && isCarrierAlive)
            {
                isCarrierAlive = false;
                return "Carrier Sunk";
            }
            if (battleHit == 0 && isBattleAlive)
            {
                isBattleAlive = false;
                return "Battle Ship Sunk";
            }
            if (destroyHit == 0 && isDestroyAlive)
            {
                isDestroyAlive = false;
                return "Destroyer Sunk";
            }
            if (patrolHit == 0 && isPatrolAlive)
            {
                isPatrolAlive = false;
                return "Patrol Boat Sunk";
            }
            if (subHit == 0 && isSubAlive)
            {
                isSubAlive = false;
                return "Submarine Sunk";
            }

            return null;
        }
        /*
        public int ShipAfloat(int[,] grid)
        {
            // TODO:

            // check how many ships are still alive

            // return total number of ships still alive 

        }
        */
    }
}
