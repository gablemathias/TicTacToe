using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Game
    {
        public int[,] winConditions = new int[7, 3] { 
            { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 1, 5, 9 }, { 1, 4, 7 }, { 8, 5, 2 }, { 9, 6, 3 } 
        };

        public Game()
        {
            Player[] players = { 
                new() { Id = 1, Name = "Gabriel", Piece = "O" }, 
                new() { Id = 2, Name = "Mathias", Piece = "X" } 
            };

            Board board = new();
        }
    }
}
