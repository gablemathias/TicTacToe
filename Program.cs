﻿namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            Console.WriteLine(board.VisualBoard());
        }
    }
}
