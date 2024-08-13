using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Board
    {
        public string[] TheBoard { get; set; } = new string[9];
        public string VisualBoard()
        {
            string row = "---+---+---";
            string col = "|";

            string[] visualBoard = new string[9];

            for (int i = 0; i < TheBoard.Length; i++)
            {
                if (TheBoard[i] == null)
                    visualBoard[i] = " ";
                else
                    visualBoard[i] = TheBoard[i];
            }

            return $" {visualBoard[6]} {col} {visualBoard[7]} {col} {visualBoard[8]}\n{row}\n" +
                   $" {visualBoard[3]} {col} {visualBoard[4]} {col} {visualBoard[5]}\n{row}\n" +
                   $" {visualBoard[0]} {col} {visualBoard[1]} {col} {visualBoard[2]}\n";
        }
    }
}
