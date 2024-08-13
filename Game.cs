using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Game
    {
        public int[,] WinConditions = new int[7, 3] { 
            { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 1, 5, 9 }, { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } 
        };

        public Game()
        {
            Player[] players = { 
                new() { Id = 1, Name = "Gabriel", Piece = "O" }, 
                new() { Id = 2, Name = "Mathias", Piece = "X" } 
            };

            Board board = new();
        }
        /// <summary>
        /// Checks if player has won after choosing a position for its piece
        /// </summary>
        /// <param name="player"></param>
        public bool IsWinner(Player player)
        {
            // Validates the player's choices and compares it with the winning possibilities
            // Loop through each win condition possibility, if the player has all 3 in one of them, they win. 

            /* Start a loop through each Winning possibility
             * Compare the winning values with players choices
             *   if Player has all values in that winning block
             *      return true and finish the game
             *   else
             *      keep checking until the end of winning blocks
             *          if no valid winning blocks
             *              return false
             *   finish
             */
            //int[] test = new int[] { 7, 4, 6, 5 };

            for (int i = 0; i < WinConditions.GetLength(0); i++)
            {
                int[] block = new int[] { WinConditions[i, 0], WinConditions[i, 1], WinConditions[i, 2] };
                Console.WriteLine("{0}, {1}, {2}", block[0], block[1], block[2]);

                var check = block.Except(player.Choices);
                Console.WriteLine(check);
                if (!check.Any())
                    return true;
                else
                    continue;
            }

            return false;
        }

        public bool IsDraw(Board board)
        {
            return !board.TheBoard.Contains(null);
        }
    }
}
