using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Player
    {
        public string Name { get; set; }
        public string Piece { get; set; }
        public int[] Choices { get; set; }

        public Player(string name, string piece) {
            this.Name = name;
            this.Piece = piece;
            this.Choices = new int[5];
        }

        
    }
}
