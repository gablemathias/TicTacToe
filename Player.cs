using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Piece { get; set; }
        public int[] Choices { get; set; }
    }
}
