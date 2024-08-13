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
                // Check if it's a valid play:
                // Valid plays are between 1 and 9, integers and weren't chosen before. 
                
                Console.WriteLine("Choose a valid position from 1 to 9 (keyboard orientation) to play");
                string strChoice = Console.ReadLine();
                int.TryParse(strChoice, out numChoice); // Check if valid integer 
                if (numChoice < 1 || numChoice > 9 || board.TheBoard[numChoice - 1] != null) // Check if the position wasn't chosen yet. // index-0 based.
                        continue;

                // fill the board with the player piece
                board.TheBoard[numChoice - 1] = actualPlayer.Piece;

                // insert the value on players choices array
                // Since players choices is an array that is initially a bunch of zeros, we loop through the array and fill the next zero found.
                for (int i = 0; i < actualPlayer.Choices.Length; i++)
                {
                    if (actualPlayer.Choices[i] == 0)
                    {
                        actualPlayer.Choices[i] = numChoice;
                        break;
                    }
                        
                }
                Console.WriteLine(board.VisualBoard());

                // Check if player is the Winner to finish the game OR if it is a draw
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
                else // If none of them, change the player (new turn);
                {
                    actualPlayer = actualPlayer.Piece == "O" ? game.Players[1] : game.Players[0]; 
                    Console.WriteLine("Now it is your turn {0}!", actualPlayer.Name);
                }
            }
        }
    }
}
