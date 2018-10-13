using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace TestTicTacToe
{
    public class UnitTest1
    {        
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

        //Test for switch in players between turns
        [Fact]
        public void TestForCorrectSwitchAfterTurns()
        {
            //Set up test game
            Player player1 = new Player();
            player1.Name = "Foo";
            player1.IsTurn = true;
            Player player2 = new Player();
            player2.Name = "Bar";

            Game testGame = new Game(player1, player2);
            Player playerBeforeSwitch = testGame.NextPlayer();
            testGame.SwitchPlayer();
            Player playerAfterSwitch = testGame.NextPlayer();

            Assert.NotEqual(playerBeforeSwitch.Name, playerAfterSwitch.Name);
        }

        //Test to confirm player position correlates to correct index of board
        [Fact]
        public void TestPositionCorrelatesToIndex()
        {
            int boardPosition = 5;
            Position positionCoordinates = Player.PositionForNumber(boardPosition);
            Assert.True(positionCoordinates.Row == 1 && positionCoordinates.Column == 1);
        }

        //Test to confirm that non-existent position returns null when passed to PositionForNumber
        [Fact]
        public void TestNonexistentBoardPositionCoordinateIsNull()
        {
            int boardPosition = 10;
            Position positionCoordinates = Player.PositionForNumber(boardPosition);
            Assert.Null(positionCoordinates);
        }
    }
}
