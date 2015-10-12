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
    public class GameEngine
    {
        //public void StartGame(string[,] TicTacToeBoard)
        //{
        //    var player1 = string.Empty;
        //    var player2 = string.Empty;

        //    InitializeBoard(TicTacToeBoard);

        //    ChoosePlayer(ref player1, ref player2);

        //    PlayGame(TicTacToeBoard, player1, player2);
        //}

        //private void PlayGame(string[,] ticTacToeBoard, string player1, string player2)
        //{
        //    var Winner = String.Empty;
        //    var currentPlayer = player1;

        //    while(Winner.Equals(string.Empty))
        //    {
        //        Console.WriteLine("Enter position X for {0}", currentPlayer);
        //        int positionX = Int32.Parse(Console.ReadLine());

        //        Console.WriteLine("Enter position Y for {0}", currentPlayer);
        //        int positionY = Int32.Parse(Console.ReadLine());

        //        if (ticTacToeBoard[positionX, positionY].Equals(" "))
        //            ticTacToeBoard[positionX, positionY] = currentPlayer;

        //        PrintTicTacToeBoard(ticTacToeBoard);

        //        Winner = CheckForVictory(ticTacToeBoard, currentPlayer);

        //        currentPlayer = currentPlayer.Equals(player1) ? player2 : player1;
        //    }

        //    Console.WriteLine("The winner is {0}", Winner);
        //}

        public string CheckForVictory(string[,] ticTacToeBoard, string currentPlayer)
        {
            var horizontalVictory = 0;
            var verticalVictory = 0;
            var diagonalVictory = 0;

            for (int i = 0; i < ticTacToeBoard.GetLength(0); i++)
            {
                if (horizontalVictory == 3)
                    break;
                else
                    horizontalVictory = 0;

                for (int j = 0; j < ticTacToeBoard.GetLength(0); j++)
                {
                    if (ticTacToeBoard[i, j].Equals(currentPlayer))
                        horizontalVictory++;
                }
            }

            for (int i = 0; i < ticTacToeBoard.GetLength(0); i++)
            {
                if (verticalVictory == 3)
                    break;
                else
                    verticalVictory = 0;

                for (int j = 0; j < ticTacToeBoard.GetLength(0); j++)
                {
                    if (ticTacToeBoard[j, i].Equals(currentPlayer))
                        verticalVictory++;
                }
            }

            for (int i = 0; i < ticTacToeBoard.GetLength(0); i++)
            {
                if (ticTacToeBoard[i, i].Equals(currentPlayer))
                    diagonalVictory++;
            }

            if (diagonalVictory != 3)
            {
                diagonalVictory = 0;
                for (int i = 0; i < ticTacToeBoard.GetLength(0); i++)
                {
                    if (ticTacToeBoard[(ticTacToeBoard.GetLength(0) - 1) - i,
                                       (ticTacToeBoard.GetLength(0) - 1) - i].Equals(currentPlayer))
                        diagonalVictory++;
                }
            }

            return horizontalVictory == 3 || verticalVictory == 3 || diagonalVictory == 3 ?
                   currentPlayer : string.Empty;

        }

        //private void PrintTicTacToeBoard(string[,] ticTacToeBoard)
        //{
        //    for (int i = 0; i < ticTacToeBoard.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < ticTacToeBoard.GetLength(0); j++)
        //        {
        //            Console.Write(ticTacToeBoard[i, j]);
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //private void InitializeBoard(string[,] ticTacToeBoard)
        //{
        //    for (int i = 0; i < ticTacToeBoard.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < ticTacToeBoard.GetLength(0); j++)
        //        {
        //            ticTacToeBoard[i, j] = " ";
        //        }
        //    }
        //}

        //private void ChoosePlayer(ref string player1, ref string player2)
        //{
        //    //Console.WriteLine("Player1, Do you want to be X or O?");
        //    while(true)
        //    {
        //        Console.WriteLine("Player1, Do you want to be X or O?");
        //        player1 = Console.ReadLine().ToUpper();

        //        if (player1.ToUpper().Equals("X") || player1.ToUpper().Equals("0"))
        //            break;
        //    }

        //    player2 = player1.ToUpper().Equals("X") ? "O" : "X";
        //}
    }
}
