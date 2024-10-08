﻿using System.Numerics;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player playerOne = new Player("Matheus", "O");
            Player playerTwo = new Player("Gabe", "X");
            Game game = new Game([playerOne, playerTwo]);
            Board board = new Board();

            Player actualPlayer = game.Players[0];
            int numChoice;
            int[] arrayRange = [1, 9];

            Console.WriteLine("Welcome to TicTacToe, the player {0} with the piece {1} starts the game.", actualPlayer.Name, actualPlayer.Piece);

            while (true) 
            {
                // Check if valid play:
                // Valid plays are between 1 and 9, integers and haven't been chosen yet. 
                
                Console.WriteLine("Choose a valid position from 1 to 9 (keyboard orientation) to play");
                string strChoice = Console.ReadLine();
                int.TryParse(strChoice, out numChoice);
                if (numChoice < 1 || numChoice > 9 || board.TheBoard[numChoice - 1] != null) // index-0 based.
                        continue;

                game.MakePlay(actualPlayer, numChoice, board); // Update board and player choices
                
                Console.WriteLine(board.VisualBoard());

                // Check if player is Winner, Draw or New Turn
                if (game.IsWinner(actualPlayer))
                {
                    Console.WriteLine("Congratulations {0}, you are the Winner!", actualPlayer.Name);
                    break;
                }
                else if (game.IsDraw(board))
                {
                    Console.WriteLine("Aww that's sad, it's a cat. Maybe next time.");
                    break;
                }
                else
                {
                    actualPlayer = game.NewTurn(actualPlayer);
                }
            }
        }
    }
}
