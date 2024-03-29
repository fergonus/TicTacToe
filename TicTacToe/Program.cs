﻿// C# Programming For Beginners Part 3 - Our First Iteration Of Tic Tac Toe-Va9woWTloVk.mp4
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
    class Program
    {
        static void Main(string[] args)
        {
            string[,] TicTacToeBoard = new string[3, 3];

            GameEngine gameEngine = new GameEngine();
            GameVisualizer gameVisualizer = new GameVisualizer();
            GameManager gameManager = new GameManager(gameVisualizer, gameEngine);

            gameManager.StartGame(TicTacToeBoard);
        }
    }
}
