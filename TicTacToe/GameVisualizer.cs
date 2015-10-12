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
    public class GameVisualizer
    {
        public void PrintTicTacToeBoard(string[,] ticTacToeBoard)
        {
            for (int i = 0; i < ticTacToeBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ticTacToeBoard.GetLength(0); j++)
                {
                    Console.Write(ticTacToeBoard[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void InitializeBoard(string[,] ticTacToeBoard)
        {
            for (int i = 0; i < ticTacToeBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ticTacToeBoard.GetLength(0); j++)
                {
                    ticTacToeBoard[i, j] = " ";
                }
            }
        }
    }
}
