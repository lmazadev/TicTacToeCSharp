using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player = 2;
            int entry = 0;
            bool correctEntry = true;
            


            do
            {
                if (player == 2)
                {
                    player = 1;
                    XOrO(player,entry);
                } else if (player == 1)
                {
                    player = 2;
                    XOrO(player, entry);
                }

                CreateBoard();

                #region

                char[] anyFigure = { 'X', 'O'};

                foreach (char figure in anyFigure)
                {
                    if ((GameBoard[0, 0] == figure) && (GameBoard[0, 1] == figure) && (GameBoard[0, 2] == figure)
                        || (GameBoard[1, 0] == figure) && (GameBoard[1, 1] == figure) && (GameBoard[1, 2] == figure)
                        || (GameBoard[2, 0] == figure) && (GameBoard[2, 1] == figure) && (GameBoard[2, 2] == figure)
                        || (GameBoard[0, 0] == figure) && (GameBoard[1, 0] == figure) && (GameBoard[2, 0] == figure)
                        || (GameBoard[0, 1] == figure) && (GameBoard[1, 1] == figure) && (GameBoard[2, 2] == figure)
                        || (GameBoard[0, 2] == figure) && (GameBoard[1, 2] == figure) && (GameBoard[2, 2] == figure)
                        || (GameBoard[0, 0] == figure) && (GameBoard[1, 1] == figure) && (GameBoard[2, 2] == figure)
                        || (GameBoard[0, 2] == figure) && (GameBoard[1, 1] == figure) && (GameBoard[2, 0] == figure))

                    {
                        if (figure == 'X')
                            Console.WriteLine("Congratulations, player 2 has won.");
                        else
                            Console.WriteLine("Congratulations, player 1 has won.");

                        Console.WriteLine("Press any key to restart the game");
                        Console.Read();
                        entry = 0;
                        ResetGame();
                        break;
                    }

                    else if (shifts == 10) 
                    {
                        Console.WriteLine("\nTie!");
                        Console.WriteLine("Press any key to restart the game");
                        Console.Read();
                        entry = 0;
                        ResetGame();
                        break;
                    }
                }          

                #endregion

                //This code checks if the value entered is valid.
                #region
                do
                {
                    Console.WriteLine("\nPlayer {0}: Please choose a number.", player);
                    try
                    {
                        entry = Convert.ToInt32(Console.ReadLine());
                    }
                    catch 
                    {
                        Console.WriteLine("Please select a number.");
                    }
                    
                    if ((entry == 1) && (GameBoard[0, 0] == '1' ))
                        correctEntry= true;
                    else if ((entry == 2) && (GameBoard[0, 1] == '2'))
                        correctEntry = true;
                    else if ((entry == 3) && (GameBoard[0, 2] == '3'))
                        correctEntry = true;
                    else if ((entry == 4) && (GameBoard[1, 0] == '4'))
                        correctEntry = true;
                    else if ((entry == 5) && (GameBoard[1, 1] == '5'))
                        correctEntry = true;
                    else if ((entry == 6) && (GameBoard[1, 2] == '6'))
                        correctEntry = true;
                    else if ((entry == 7) && (GameBoard[2, 0] == '7'))
                        correctEntry = true;
                    else if ((entry == 8) && (GameBoard[2, 1] == '8'))
                        correctEntry = true;
                    else if ((entry == 9) && (GameBoard[2, 2] == '9'))
                        correctEntry = true;
                    else
                    {
                        Console.WriteLine("\nPlease select another number.");
                        correctEntry= false;
                    }

                } while (!correctEntry);
                #endregion  


            } while (true);    



        }

        //This method identifies the player.
        public static void XOrO(int player, int entry)
        {
            char figure = ' ';

            if (player == 1)
            { 
                figure = 'X'; 
            }
            else if (player == 2)
            { 
                figure = 'O'; 
            }

            switch (entry)
            {
                case 1: GameBoard[0, 0] = figure; break;
                case 2: GameBoard[0, 1] = figure; break;
                case 3: GameBoard[0, 2] = figure; break;
                case 4: GameBoard[1, 0] = figure; break;
                case 5: GameBoard[1, 1] = figure; break;
                case 6: GameBoard[1, 2] = figure; break;
                case 7: GameBoard[2, 0] = figure; break;
                case 8: GameBoard[2, 1] = figure; break;
                case 9: GameBoard[2, 2] = figure; break;
            }          


        }

        //This array contains variables of the game.
        static char[,] GameBoard =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };

        //This array contains initials variables of the game.
        static char[,] InitialGameBoard =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };

        static int shifts = 0;

        //This method creates the game board.
        public static void CreateBoard()
        {
            Console.Clear();
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", GameBoard[0, 0], GameBoard[0, 1], GameBoard[0,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", GameBoard[1, 0], GameBoard[1, 1], GameBoard[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine("  {0}  |  {1}  |  {2}", GameBoard[2, 0], GameBoard[2, 1], GameBoard[2, 2]);
            Console.WriteLine("     |     |");
            shifts++;
        }

        //
        public static void ResetGame()
        {
            GameBoard = InitialGameBoard;
            CreateBoard();
            shifts= 0;
        }
    }
}
