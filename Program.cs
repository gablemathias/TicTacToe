namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // 0.  Start the turn
            // 0.1 Ask player to choose a position
            // 1.   Check if a play is valid
            // 2.   if valid
            // 2.1     insert the numerical position into player's choices array
            // 2.2     replace the position with the player's piece
            // 2.3     check if the player is winner
            // 2.4         if it is, stop the game and announce the winner 
            // 2.5         else change the turn to the other player.
            // 3.   else
            // 4.      Ask player again to choose a position 

            Board board = new Board();

            Console.WriteLine(board.VisualBoard());

            //Game game = new Game();

            //Console.WriteLine(game.IsWinner(new Player()));
        }
    }
}
