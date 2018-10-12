using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
            PlayGame();
		}

		static void PlayGame()
		{
            // TODO: Instantiate your players
            // Create the Game
            // Play the Game
            // Output the winner
            Console.WriteLine("Welcome to Tic-Tac-Toe");
            
            //Set player attributes
            Player playerOne = new Player();
            Player playerTwo = new Player();

            Console.WriteLine("Player one, enter your name");
            playerOne.Name = Console.ReadLine();
            Console.WriteLine("Player two, enter your name");
            playerTwo.Name = Console.ReadLine();

            playerOne.Marker = "X";
            playerTwo.Marker = "O";

            playerOne.IsTurn = true;
            playerTwo.IsTurn = false;

            Game currentGame = new Game(playerOne, playerTwo);

            Player winner = currentGame.Play();

            if (winner != null)
            {
                Console.WriteLine($"Congrats, {winner.Name}, you won the game!");
            }
            else
            {
                Console.WriteLine($"It's a draw");
            }

        }
	}
}
