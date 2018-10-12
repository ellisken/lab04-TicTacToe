using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace TestTicTacToe
{
    public class UnitTest1
    {
        /* REQUIRED TESTS:
         * DONE: Given a game board, test for winners (3 different tests) 
         * TODO: Test for switch in players between turns
         * TODO: Confirm player position correlates to correct index of the board array
         * TODO: Create one other test of your own
         */
        
        //Test CheckForWinner with different boards
        [Fact]
        public void TestForWinnerNoWin()
        {
            //Set up test game
            Position p1 = new Position(0, 0);
            Position p2 = new Position(0, 1);
            Position p3 = new Position(1, 2);
            Player player1 = new Player();
            Player player2 = new Player();
            Game testGame = new Game(player1, player2);

            //Mark positions
            testGame.Board.GameBoard[p1.Row, p1.Column] = "X";
            testGame.Board.GameBoard[p2.Row, p2.Column] = "X";
            testGame.Board.GameBoard[p3.Row, p3.Column] = "X";

            Assert.False(testGame.CheckForWinner(testGame.Board));
        }
        [Fact]
        public void TestForWinnerWithWin1()
        {
            //Set up test game
            Position p1 = new Position(0, 0);
            Position p2 = new Position(0, 1);
            Position p3 = new Position(0, 2);
            Player player1 = new Player();
            Player player2 = new Player();
            Game testGame = new Game(player1, player2);

            //Mark positions
            testGame.Board.GameBoard[p1.Row, p1.Column] = "X";
            testGame.Board.GameBoard[p2.Row, p2.Column] = "X";
            testGame.Board.GameBoard[p3.Row, p3.Column] = "X";

            Assert.True(testGame.CheckForWinner(testGame.Board));
        }
        [Fact]
        public void TestForWinnerWithWinDiagonal()
        {
            //Set up test game
            Position p1 = new Position(0, 0);
            Position p2 = new Position(1, 1);
            Position p3 = new Position(2, 2);
            Player player1 = new Player();
            Player player2 = new Player();
            Game testGame = new Game(player1, player2);

            //Mark positions
            testGame.Board.GameBoard[p1.Row, p1.Column] = "X";
            testGame.Board.GameBoard[p2.Row, p2.Column] = "X";
            testGame.Board.GameBoard[p3.Row, p3.Column] = "X";

            Assert.True(testGame.CheckForWinner(testGame.Board));
        }
    }
}
