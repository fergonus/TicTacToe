// C# Programming For Beginners Part 3 - Our First Iteration Of Tic Tac Toe-Va9woWTloVk.mp4
// Date: 10-10-2015
// TicTacToe Console Version
// C# Programming For Beginners Part 4 - Single Responsibility Principle-XuKmI6OsjbU.mp4
// Date: 10-12-2015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class GameManager
    {
        private readonly GameVisualizer _gameVisualizer;
        private readonly GameEngine _gameEngine;

        public GameManager(GameVisualizer gameVisualizer, GameEngine gameEngine)
        {
            _gameVisualizer = gameVisualizer;
            _gameEngine = gameEngine;
        }

        public void StartGame(string[,] TicTacToeBoard)
        {
            var player1 = string.Empty;
            var player2 = string.Empty;

            _gameVisualizer.InitializeBoard(TicTacToeBoard);

            ChoosePlayer(ref player1, ref player2);

            PlayGame(TicTacToeBoard, player1, player2);
        }

        public void ChoosePlayer(ref string player1, ref string player2)
        {
            //Console.WriteLine("Player1, Do you want to be X or O?");
            while (true)
            {
                Console.WriteLine("Player1, Do you want to be X or O?");
                player1 = Console.ReadLine().ToUpper();

                if (player1.ToUpper().Equals("X") || player1.ToUpper().Equals("0"))
                    break;
            }

            player2 = player1.ToUpper().Equals("X") ? "O" : "X";
        }

        public void PlayGame(string[,] ticTacToeBoard, string player1, string player2)
        {
            var Winner = String.Empty;
            var currentPlayer = player1;

            while (Winner.Equals(string.Empty))
            {
                Console.WriteLine("Enter position X for {0}", currentPlayer);
                int positionX = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter position Y for {0}", currentPlayer);
                int positionY = Int32.Parse(Console.ReadLine());

                if (ticTacToeBoard[positionX, positionY].Equals(" "))
                    ticTacToeBoard[positionX, positionY] = currentPlayer;

                _gameVisualizer.PrintTicTacToeBoard(ticTacToeBoard);

                Winner = _gameEngine.CheckForVictory(ticTacToeBoard, currentPlayer);

                currentPlayer = currentPlayer.Equals(player1) ? player2 : player1;
            }

            Console.WriteLine("The winner is {0}", Winner);
        }
    }
}
